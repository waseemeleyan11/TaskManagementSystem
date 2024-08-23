namespace TaskManagementSystem.ViewModel
{
    public class ProjectDTO
    {
        public string Name { get; set; }
        public DateTime ExpectedDateToStart { get; set; }
        public int Status { get; set; }
        public bool Flag { get; set; }
        public string Link { get; set; }
        public int CreatedById { get; set; }
        public int? AddedAttachmentId { get; set; }


    }
}
