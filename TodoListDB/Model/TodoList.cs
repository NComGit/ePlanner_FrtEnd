using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDB.Model
{
    public class TodoList
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
