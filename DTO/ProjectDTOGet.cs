namespace TaskManagementSystem.DTO
{
    public class ProjectDTOGet
    {
        public string Name { get; set; }
        public DateTime ExpectedDateToStart { get; set; }
        public string Status { get; set; }
        public bool Flag { get; set; }
        public string Link { get; set; }
        public int CreatedById { get; set; }
        public int? AddedAttachmentId { get; set; }
    }
}
