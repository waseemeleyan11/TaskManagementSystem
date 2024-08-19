using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//19/8

namespace TaskManagementSystem.Data.Models
{
    public class Sprint
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }

        // Relationships
        public int AgileId { get; set; }
        public Agile Agile { get; set; }
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
