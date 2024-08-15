namespace Project.Data.Model
{
    public class Agile : Project

    {

        public int TimeForEageSprint { get; set; }
        public ICollection<Sprint> Sprints { get; set; }
    }
}
