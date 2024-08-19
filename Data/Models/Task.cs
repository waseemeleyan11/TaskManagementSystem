using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//19/8

namespace TaskManagementSystem.Data.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string DescriptionAttachment { get; set; }
        public string Priority { get; set; }
        public bool IsDeleted { get; set; }

        // Relationships
        public int? SprintId { get; set; }
        public Sprint Sprint { get; set; }
        public int? WaterfallId { get; set; }
        public Waterfall Waterfall { get; set; }
        public int? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
