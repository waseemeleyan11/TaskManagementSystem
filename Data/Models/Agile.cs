namespace TaskManagementSystem.Data.Models
{
    public class Agile : Project

    {

        public int TimeForEageSprint { get; set; }
        public ICollection<Sprint> Sprints { get; set; }
    }
}
