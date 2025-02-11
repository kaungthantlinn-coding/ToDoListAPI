using ToDoListAPI.API.Models;

namespace ToDoListAPI.API.Repositories
{
    public interface IToDoRepository
    {
        Task<IEnumerable<ToDoItem>> GetAllAsync();
        Task<ToDoItem?> GetByIdAsync(int id);
        Task AddAsync(ToDoItem item);
        Task UpdateAsync(ToDoItem item);
        Task DeleteAsync(int id);
    }
}
