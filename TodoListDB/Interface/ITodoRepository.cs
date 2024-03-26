using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDB.Interface
{
    public interface ITodoRepository : IDisposable
    {
        IQueryable<TodoList> GetTodoLists();
        bool IsTodoListExist(string title);
        bool AddTodoList(int userId, string title, string description);

        IQueryable<TodoList> GetTodoItems();
        IEnumerable<TodoItem> GetTodoItems(int todoListId);
      
    }
}
