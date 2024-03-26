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
