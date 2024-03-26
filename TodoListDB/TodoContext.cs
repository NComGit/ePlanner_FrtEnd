using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDB
{
    public class TodoContext
    {
        TodoDBEntities _Ctx;

        public TodoContext()
        {
            _Ctx = new TodoDBEntities();
        }

        public TodoDBEntities Context
        {
            get
            {
                return this._Ctx;
            }
        }

        public void Dispose()
        {
            if (_Ctx != null)
                _Ctx.Dispose();
        }
    }
}
