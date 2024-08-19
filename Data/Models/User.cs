
namespace TaskManagementSystem.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsDeleted { get; set; }

        public int? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Sprint> Sprints { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }

}
