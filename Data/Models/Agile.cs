namespace TaskManagementSystem.Data.Models
{
    public class Agile : Project

    {
        public TimeSpan TimeForEachSprint { get; set; }
        public ICollection<Sprint> Sprints { get; set; }
    }
}
