using Microsoft.Extensions.Hosting;
using TaskManagementSystem.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagementSystem.ViewModel;
using TaskManagementSystem.DTO;

namespace TaskManagementSystem.Data.IServices
{
    public interface IProjectService
    {
        Task<Project> CreateProjectAsync(ProjectDTO post);
        Task<List<ProjectDTO>> GetProjectsAsync();
        Task<ProjectDTO> GetProjectAsyncById(int id);
        Task<Project> UpdateProjectAsync(ProjectDTOWithOutUserid project, int id);
        Task<Project> DeleteProjectAsync(int id);
    }
}
