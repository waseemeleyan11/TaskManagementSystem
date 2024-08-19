﻿namespace TaskManagementSystem.Data.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string PhysicalPath { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
    }
}

