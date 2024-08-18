namespace TaskManagementSystem.Data.Models
{
    public class UserTask
    {
        public ICollection<Task> Tasks { get; set; } = new List<Task>();

        public ICollection<User> Users { get; set; } = new List<User>();


    }
}
