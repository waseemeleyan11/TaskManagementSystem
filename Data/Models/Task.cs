using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Data.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty.ToString();
        public string DescriptionAttachment { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } 

        // Relationships
        public int? SprintId { get; set; }
        public Sprint Sprint { get; set; } 
        public int? WaterfallId { get; set; }
        public Waterfall Waterfall { get; set; } 
        public int? AddedAttachmentId { get; set; }
        public Attachment AddedAttachment { get; set; }
        public int CreatedById { get; set; }
        public User CreatedBy { get; set;}
        public ICollection<UserTask>  UserTasks { get; set; }
        public ICollection<Comment>  addedComments { get; set; }
    }
}