using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TodoListDB.Model
{
    public class SelectLists
    {
        public SelectList TodoListList { get; set; }

        public SelectList TodoItemList { get; set; }
    }
}
