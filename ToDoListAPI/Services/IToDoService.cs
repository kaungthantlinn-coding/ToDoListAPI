using ToDoListAPI.API.Models;

namespace ToDoListAPI.API.Services
{
    public interface IToDoService
    {
        Task<IEnumerable<ToDoItem>> GetAllAsync();
        Task<ToDoItem?> GetByIdAsync(int id);
        Task AddAsync(ToDoItemDTO itemDto);
        Task UpdateAsync(int id, ToDoItemDTO itemDto);
        Task DeleteAsync(int id);
    }
}
