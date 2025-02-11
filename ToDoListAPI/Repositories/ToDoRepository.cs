using Microsoft.EntityFrameworkCore;
using ToDoListAPI.API.Data;
using ToDoListAPI.API.Models;

namespace ToDoListAPI.API.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly AppDbContext _context;

        public ToDoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ToDoItem item)
        {
            _context.ToDoItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = _context.ToDoItems.Find(id);
            if (item != null)
            {
                _context.ToDoItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ToDoItem>> GetAllAsync()
        {
            return await _context.ToDoItems.ToListAsync();
        }

        public async Task<ToDoItem?> GetByIdAsync(int id)
        {
            return await _context.ToDoItems.FindAsync(id);
        }

        public async Task UpdateAsync(ToDoItem item)
        {
            _context.ToDoItems.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
