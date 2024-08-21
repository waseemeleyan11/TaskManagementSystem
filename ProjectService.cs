using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Newtonsoft.Json;
using System.Text;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;
        private readonly ProjectContext _context;

        public ProjectService(ProjectContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

        
        
        public async Task<Project> CreateProjectAsync(Project newProject)
        {
            if (newProject == null)
            {
                throw new ArgumentNullException(nameof(newProject));
            }

            _context.Projects.Add(newProject);
            await _context.SaveChangesAsync();
            return newProject;



        }

        public async Task<Project> Mapping(Project newProject)
        {
            string name = newProject.Name;
            if (newProject == null)
            {
                throw new ArgumentNullException(nameof(newProject));
            }

            _context.Projects.Add(newProject);
            await _context.SaveChangesAsync();
            return newProject;



        }


        public async Task<List<Project>> GetProjectsAsync()
        {
            
                try
                {

                    return await _context.Projects.ToListAsync();
                }
                catch (Exception ex)
                {
                    return new List<Project>();
                }
            
            

            
        }

    }
}
