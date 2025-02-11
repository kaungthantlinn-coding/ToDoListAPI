using ToDoListAPI.API.Models;
using ToDoListAPI.API.Repositories;

namespace ToDoListAPI.API.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        public async Task AddAsync(ToDoItemDTO itemDto)
        {
            var item = new ToDoItem 
            { 
              Title = itemDto.Title, 
              IsCompleted = itemDto.IsCompleted 
            };

            await _toDoRepository.AddAsync(item);
        }

        public async Task DeleteAsync(int id)
        {
            await _toDoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ToDoItem>> GetAllAsync()
        {
            return await _toDoRepository.GetAllAsync();
        }

        public async Task<ToDoItem?> GetByIdAsync(int id)
        {
            return await _toDoRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int id, ToDoItemDTO itemDto)
        {
            var item = await _toDoRepository.GetByIdAsync(id);
            if (item != null)
            {
                item.Title = itemDto.Title;
                item.IsCompleted = itemDto.IsCompleted;
                await _toDoRepository.UpdateAsync(item);
            }
        }
    }
}
