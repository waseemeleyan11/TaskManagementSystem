    using global::TaskManagementSystem.Data.Models;
    using global::TaskManagementSystem;
    using Microsoft.AspNetCore.Mvc;
 using TaskManagementSystem.Services;
using TaskManagementSystem.Data;
using TaskManagementSystem.DTO;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    
         
        [Route("api/[controller]")]
        [ApiController]
        public class AttachmentController : ControllerBase
        {
            private readonly AttachmentService _AttachmentService;
            private readonly ProjectContext _context;




        public AttachmentController(AttachmentService AttachmentService ,ProjectContext projectContext)
            {
            _AttachmentService = AttachmentService ;
            _context = projectContext ;
            
            }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attachment>>> GetAllAttachments()
        {
            var allAttachment = await _AttachmentService.GetAllAttachment();
            return Ok(allAttachment);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AttachmentDTO>> GetProjectsById(int id)
        {
            var Attachment = await _AttachmentService.GetAttachmentById(id);
            return Ok(Attachment);
        }
        [HttpPost]
        public async Task<ActionResult<Project>> Post([FromBody] AttachmentDTO Attachment)

        {

            if (Attachment == null)
            {
                return BadRequest();

            }

            var createdPost = await _AttachmentService.CreateAttachmentAsync(Attachment);
            return CreatedAtAction(nameof(GetProjectsById), new { id = createdPost.Id }, createdPost);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttachment(int id)
        {

            var AttachmentUpdate = await _AttachmentService.DeleteAttachmentAsync(id);
            if (AttachmentUpdate == null)
                return NotFound();

            return Ok(AttachmentUpdate);


        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProjectByIdAsync([FromBody] AttachmentDTO attachmentDto, int id)
        {
            if (attachmentDto == null)
                return BadRequest();

            var updatedAttachment = await _AttachmentService.UpdateAttachment(attachmentDto, id);
            if (updatedAttachment == null)
                return NotFound();

            return Ok(updatedAttachment);
        }


    }

}
