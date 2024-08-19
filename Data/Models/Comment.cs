using TaskManagementSystem.Data.Models;
using Task = TaskManagementSystem.Data.Models.Task;

namespace TaskManagementSystem.Data.Models 
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }
        
        public int TaskId { get; set; }
        public Task Task { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public int? TaskId { get; set; }
    public Task Task { get; set; }
}