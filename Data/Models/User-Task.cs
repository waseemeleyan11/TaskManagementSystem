namespace TaskManagementSystem.Models
{
    public class User_Task
    {
        public ICollection<Task> Tasks { get; set; } = new List<Task>();

        public ICollection<User> Users { get; set; } = new List<User>();


    }
}
