using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication10.Service;
using WebApplication10.Models;
using taskApi.services.Models;
using AutoMapper;
using taskApi.services;

namespace WebApplication10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class TodosController : ControllerBase
    {
        private TodoServices _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepocitory todoRepocitory, IMapper mapper)
        {


        }



        public TodosController()
        {
            _todoService = new TodoServices();
        }



        [HttpGet("{Id?}")]
        public IActionResult GetoneTodo(int? Id)
        {
            var todos = _todoService.Alltodos();
            if (Id is null) return NotFound();

            todos = todos.Where(t => t.Id == Id).ToList();
            return Ok(todos);
        }
        [HttpGet]
        public IActionResult GetTodo()
        {
            var todos = _todoService.Alltodos();
            var todosDto = new List<Tododto>();
            var maped = Mapper.Map<ICollection<Tododto>>(todos);
            return Ok(maped);
            /*foreach (var todo in todos)
            {
                Tododto.Add(new Tododto
                {
                    Id = todo.Id,
                    Title = todo.Title,
                    description = todo.description
                });*/
        }
        [HttpPost]
        public ActionResult<Tododto> CreateTodo(int Id, taskApi.services.Todos.Createtodo create)
        {
            var todoEntity = Mapper.Map<todo>(create);
            var newtodo = _todoService.AddTodo(Id);
            var todoForReturn = Mapper.Map<Tododto>(newtodo);

            return CreatedAtRoute("GetTodo") , new { todoId = Id, id = todoForReturn.Id },todoForReturn);
        }


        [HttpPut ("{Id}")]

        public ActionResult UpdateTodo (int Id , updatetodo update)
        {
            var updating = _todoService.GetTodo(Id);
            if (updating is null)
                return NotFound();
            Mapper.Map(update, updating);
            _todoService.Updatetodo(updating);
            return NoContent();

        }
        

    }

}


    

