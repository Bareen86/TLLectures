using Microsoft.AspNetCore.Mvc;
using WebApi.Domain;
using WebApi.Dto;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private static readonly List<Todo> _todos = new(); 
        /// <summary>
        /// Возвращает все Todo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Анонимный тип
            var result = _todos.Select(t => new { t.Id, t.Title, plannedDay = t.PlannedDay.ToString("yyyy-MM-dd hh:mm:ss") }).ToList();

            return Ok(result);
        }

        /// <summary>
        /// Возвращает Todo по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("(id)")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
        /// <summary>
        /// Создает Todo
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] CreateTodoDto createDto)
        {
            int id = _todos.Count + 1;
            Todo todo = new(id, createDto.Title);
            _todos.Add(todo);

            return Ok();
        }
    }
}
