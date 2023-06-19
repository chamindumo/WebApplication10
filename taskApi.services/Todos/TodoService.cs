using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskApi.services;
using WebApplication10.Models;

namespace WebApplication10.Service
{
    public class TodoServices : ITodoRepocitory
      
    {
        public List<todo> Alltodos()
        {
            {
                var todos = new List<todo>();
                var todo1 = new todo
                {
                    Id = 1,
                    Title = "hello world",
                    description = "hi hi",
                    status = status.New


                };
                todos.Add(todo1);
                return todos;
            }
        }

        public object GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        

       

        public void Updatetodo(todo updating)
        {
           // SaveChangers();
        }

        public object AddTodo(int id, todo to)
        {
            //Add the elemnts to todos
        }
    }
    
}
