namespace ToDoListAPI.API.Models
{
    public class ToDoItemDTO
    {
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
    }
}
