using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem.Data.Models
{
    //SamaComment
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpectedDateToStart { get; set; }
        public string Status { get; set; }
        public string Flag { get; set; }
        public string Link { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
    }
}
