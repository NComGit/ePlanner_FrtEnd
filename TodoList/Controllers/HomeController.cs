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