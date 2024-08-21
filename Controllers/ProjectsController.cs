using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly HttpClient _httpClient;

        public ProjectsController(IProjectService projectService, IHttpClientFactory httpClientFactory)
        {
            _projectService = projectService;
            _httpClient = httpClientFactory.CreateClient("ProjectClient");
        }

        // GET: api/Projects

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            var projects = await _projectService.GetProjectsAsync();
            if (projects == null || projects.Count == 0)
            {
                return NotFound("No projects found.");
            }

            return Ok(projects);
        }
        /*
        // GET: api/Projects/5
/* [HttpGet("{id}")]
 public async Task<ActionResult<Project>> GetProject(int id)
 {
     var project = await _context.Projects.FindAsync(id);

     if (project == null)
     {
         return NotFound();
     }

     return project;
 }*/

        // PUT: api/Projects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject(int id, Project project)
        {
            if (id != project.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

        // POST: api/Projects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Project>> Post([FromBody] Project newPost)

        {

            if (newPost == null)
            {
                return BadRequest();
            }
            var createdPost = await _projectService.CreateProjectAsync(newPost);
            return CreatedAtAction(nameof(GetProjects), new { userId = createdPost.ProjectId }, createdPost);
        }

        // DELETE: api/Projects/5
        /*
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
  
}
}
