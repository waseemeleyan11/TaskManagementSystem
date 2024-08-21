using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Data.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        // Relationships
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public int AddedById { get; set; }
        public User AddedBy { get; set; }
    }
}
