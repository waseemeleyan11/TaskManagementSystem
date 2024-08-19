using System.Collections.Generic;

namespace TaskManagementSystem.Data.Models
{
    public class Waterfall : Project
    {
        public DateTime ExpectedEndTime { get; set; }

        // Relationships
        public ICollection<Task> Tasks { get; set; }
    }
}
