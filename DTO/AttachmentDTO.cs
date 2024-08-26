using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.DTO
{
    public class AttachmentDTO
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string PhysicalPath { get; set; }
        public string Type { get; set; }
    }
}
