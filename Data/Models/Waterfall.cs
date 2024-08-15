namespace Project.Data.Model
{
    public class Waterfall : Project
    {
        //Sama Test
        public DateTime ExpectedEndTime { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
