using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Newtonsoft.Json;
using System.Text;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.IServices;
using TaskManagementSystem.Data.Models;
using TaskManagementSystem.DTO;
using TaskManagementSystem.ViewModel;

namespace TaskManagementSystem.Data.Services
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;
        private readonly ProjectContext _context;
        private readonly IMapper iMapper;

        public ProjectService(ProjectContext context, HttpClient httpClient,IMapper mapper)
        {
            _context = context;
            _httpClient = httpClient;
            iMapper= mapper;
        }



        public async Task<Project> CreateProjectAsync(ProjectDTO newProject)
        {
            if (newProject == null)
            {
                throw new ArgumentNullException(nameof(newProject));
            }
            Project projectEntity =  iMapper.Map<Project>(newProject);

             _context.Projects.Add(projectEntity);
            
            await _context.SaveChangesAsync();
            return projectEntity;



        }


        


        public async Task<List<ProjectDTOGet>> GetProjectsAsync()
        {

            try
            {
                var projects= await _context.Projects.ToListAsync();
                var projectDto = iMapper.Map<List<ProjectDTOGet>>(projects);
                return projectDto;
            }
            catch (Exception ex)
            {
                return new List<ProjectDTOGet>();
            }




        }

        public async Task<ProjectDTOGet> GetProjectAsyncById(int id)
        {
            try
            {
                var projects = await _context.Projects.FindAsync(id);

                var projectDto = iMapper.Map<ProjectDTOGet>(projects);
                return projectDto;
            }
            catch (Exception ex)
            {
                return new ProjectDTOGet();
            }
        }

        public async Task<Project> UpdateProjectAsync(ProjectDTOWithOutUserid updateProject, int id)
        {
            if (updateProject == null)
            {
                throw new ArgumentNullException(nameof(updateProject));
            }
            var update = await _context.Projects.FindAsync(id);
            //update.Status = updateProject.Status;
            update.Flag = updateProject.Flag;   
            update.ExpectedDateToStart = updateProject.ExpectedDateToStart;
            update.Name = updateProject.Name;
            update.Link=updateProject.Link;
            update.AddedAttachmentId = updateProject.AddedAttachmentId;
            update.Status=(EnumProject)updateProject.Status; 


            _context.SaveChangesAsync();



            return update;
        }

        public async Task<Project> DeleteProjectAsync(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }
             _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            return project;
        }
    }
}
