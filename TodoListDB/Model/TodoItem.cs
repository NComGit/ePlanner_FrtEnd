using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDB.Model
{
    public class TodoItem
    {
        public int id { get; set; }
        public int todoListId { get; set; }
        public string title { get; set; }
        public string complete_incomplete { get; set; }
        public int? userDelegatedToId { get; set; }
        public DateTime? dueDate { get; set; }

    }
}
