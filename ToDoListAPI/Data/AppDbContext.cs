using Microsoft.EntityFrameworkCore;
using ToDoListAPI.API.Models;

namespace ToDoListAPI.API.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
