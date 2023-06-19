using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace taskApi.services
{
    public interface ITodoRepocitory
    {
        public List<todo> Alltodos();
        public object GetTodo(int id);
        public todo AddTodo(int Id, todo to);
        public todo Updatetodo(todo to);

    }
}
