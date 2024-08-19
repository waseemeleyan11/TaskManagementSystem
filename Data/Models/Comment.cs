using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.Data.Models;

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
        
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
    }

    
}