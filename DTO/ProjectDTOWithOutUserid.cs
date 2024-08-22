namespace TaskManagementSystem.DTO
{
    public class ProjectDTOWithOutUserid
    {
        public string Name { get; set; }
        public DateTime ExpectedDateToStart { get; set; }
        public string Status { get; set; }
        public bool Flag { get; set; }
        public string Link { get; set; }
        public int? AddedAttachmentId { get; set; }
    }
}
