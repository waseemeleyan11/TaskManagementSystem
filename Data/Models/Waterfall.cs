namespace Project.Data.Model
{
    public class Waterfall : Project
    {
        public DateTime ExpectedEndTime { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
