using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.API.Models;
using ToDoListAPI.API.Services;

namespace ToDoListAPI.API.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class ToDoController : Controller
    {
        private readonly IToDoService _toDoService;
        
        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItem>>> GetAll()
        {
            var items = await _toDoService.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItem>> GetById(int id)
        {
            var item = await _toDoService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ToDoItemDTO itemDto)
        {
            await _toDoService.AddAsync(itemDto);
            return CreatedAtAction(nameof(GetById), new { id = itemDto.Title }, itemDto);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ToDoItemDTO itemDto)
        {
            await _toDoService.UpdateAsync(id, itemDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _toDoService.DeleteAsync(id);
            return NoContent();
        }

    }
}
