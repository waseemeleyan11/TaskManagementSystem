using Microsoft.Extensions.Hosting;
using TaskManagementSystem.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public interface IProjectService
    {
        Task<Project> CreateProjectAsync(Project post);
        Task<List<Project>> GetProjectsAsync();
    }
}
