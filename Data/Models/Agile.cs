namespace TaskManagementSystem.Data.Models
{
    public class Agile : Project

    {

        public int TimeForEageSprint { get; set; }
       // User User { get; set; }
        //public int UserId { get; set; }

        public ICollection<Sprint> Sprints { get; set; }
    }
}
