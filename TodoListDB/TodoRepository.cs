using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListDB.Interface;

namespace TodoListDB
{
    public class TodoRepository : ITodoRepository
    {
        TodoContext _Ctx;

        public TodoRepository(TodoContext Context)
        {
            _Ctx = Context;
            _Ctx.Context.Configuration.LazyLoadingEnabled = false;
            _Ctx.Context.Configuration.ProxyCreationEnabled = false;
        }

        public bool AddTodoList(int userId, string title, string description)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TodoList> GetTodoItems()
        {
            return (IQueryable<TodoList>)_Ctx.Context.TodoItems;
        }
        public IEnumerable<TodoItem> GetTodoItems(int todoListId)
        {
            return _Ctx.Context.TodoItems.Where(t => t.todoListId == todoListId).ToList();
        }

        public IQueryable<TodoList> GetTodoLists()
        {
            return _Ctx.Context.TodoLists;
        }

        public bool IsTodoListExist(string title)
        {
            throw new NotImplementedException();
        }
    }
}
