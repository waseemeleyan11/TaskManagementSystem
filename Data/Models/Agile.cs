using System.Collections.Generic;
namespace TaskManagementSystem.Data.Models
{
    public class Agile : Project
    {
        public int TimeForEageSprint { get; set; }

        // Relationships
        public ICollection<Sprint> Sprints { get; set; }
    }
}
