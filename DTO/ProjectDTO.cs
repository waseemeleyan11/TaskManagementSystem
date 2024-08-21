namespace TaskManagementSystem.ViewModel
{
    public class ProjectDTO
    {
        public string Name { get; set; }
        public DateTime ExpectedDateToStart { get; set; }
        public string Status { get; set; }
        public bool Flag { get; set; }
        public string Link { get; set; }
        public int UserId { get; set; }
        public int? AttachmentId { get; set; }


    }
}
