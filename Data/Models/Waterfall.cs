using System.Collections.Generic;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    public class Waterfall : Project
    {
        public DateTime ExpectedEndTime { get; set; }

        // Relationships
        public ICollection<Task> Tasks { get; set; }
    }
}
