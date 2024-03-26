using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDB.Model
{
    public class ModelMapping
    {
        public TodoItem GetTodoItem(TodoListDB.TodoItem item)
        {
            return new TodoItem
            {
                id = item.id,
                todoListId = item.todoListId,
                title = item.title,
                complete_incomplete = item.complete_incomplete,
                userDelegatedToId = item.userDelegatedToId,
                dueDate = (DateTime?)item.dueDate ?? default(DateTime?),
            };
        }

        public TodoList GetTodoList(TodoListDB.TodoList tdlst)
        {
            return new TodoList
            {
                id = tdlst.id,
                userId = tdlst.userId,
                description = tdlst.description,
                title = tdlst.title,
            };
        }

    }
}
