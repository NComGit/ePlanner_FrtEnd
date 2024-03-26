using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoListDB.Interface;
using TodoListDB.Model;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        ITodoRepository _Repo;
        ModelMapping _ModelMapping;

        public HomeController(ITodoRepository Repo, ModelMapping ModelMapping)
        {
            _Repo = Repo;
            _ModelMapping = ModelMapping;
        }

        public ActionResult Index()
        {
            SelectLists ddlFilter = new SelectLists();
            ddlFilter.TodoListList = new SelectList((from a in _Repo.GetTodoLists()
                                                     select new
                                                     {
                                                         Value = a.id,
                                                         Text ="Title: " +  a.title + " " + "Description: " + a.description
                                                     }).Distinct(), "Value", "Text");

            return View(ddlFilter);
        }
        /*
        [HttpPost]
        public ActionResult ChangeStatus(int id)
        {
            try
            {
                // Use the repository to change the status
                bool result = _Repo.UpdateTodoItemStatus(id, "complete");
                if (result)
                {
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Todo item not found or could not be updated." });
                }
            }
            catch (Exception ex)
            {
                // Log the exception...
                return Json(new { success = false, message = "An error occurred." });
            }
        }
        */
        [HttpPost]
        public ActionResult ChangeStatus(int id, string newStatus)
        {
            try
            {
                // Use the repository to change the status
                bool result = _Repo.UpdateTodoItemStatus(id, newStatus);
                if (result)
                {
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Todo item not found or could not be updated." });
                }
            }
            catch (Exception ex)
            {
                // Log the exception...
                return Json(new { success = false, message = "An error occurred." });
            }
        }
        public JsonResult GetTodoItems(int todoListId)
        {
            var todoItems = _Repo.GetTodoItems(todoListId).Select(_ModelMapping.GetTodoItem).ToList();
            return Json(todoItems, JsonRequestBehavior.AllowGet);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}