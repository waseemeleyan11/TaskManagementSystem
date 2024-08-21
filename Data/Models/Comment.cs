using System.ComponentModel.DataAnnotations;
//19/8 v2

namespace TaskManagementSystem.Data.Models 
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        
        public int TaskId { get; set; }
        public Task Task { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }

    
}