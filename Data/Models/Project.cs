using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//19/8 v2

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
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public int? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
    }
}
