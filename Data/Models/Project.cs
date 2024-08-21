using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Data.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public DateTime ExpectedDateToStart { get; set; }
        [Required]
        [StringLength(128)]
        public string Status { get; set; }
        [Required]
        public bool Flag { get; set; }
        [StringLength(256)]
        public string Link { get; set; }
        public bool IsDeleted { get; set; }

        // Relationships
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public int? AddedAttachmentId { get; set; }
        public Attachment AddedAttachment { get; set; }
    }
}
