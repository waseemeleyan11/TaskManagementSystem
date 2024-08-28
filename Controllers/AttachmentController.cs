using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.Models;
using TaskManagementSystem.DTO;
using TaskManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly AttachmentService _attachmentService;
        private readonly ProjectContext _context;

        public AttachmentController(AttachmentService attachmentService, ProjectContext projectContext)
        {
            _attachmentService = attachmentService;
            _context = projectContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attachment>>> GetAllAttachments()
        {
            var allAttachments = await _attachmentService.GetAllAttachment();
            return Ok(allAttachments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttachmentDTO>> GetAttachmentById(int id)
        {
            var attachment = await _attachmentService.GetAttachmentById(id);
            if (attachment == null)
                return NotFound();

            return Ok(attachment);
        }

        [HttpPost]
        public async Task<ActionResult<Attachment>> CreateAttachment([FromBody] AttachmentDTO attachmentDto)
        {
            if (attachmentDto == null)
                return BadRequest();

            var createdAttachment = await _attachmentService.CreateAttachmentAsync(attachmentDto);
            return CreatedAtAction(nameof(GetAttachmentById), new { id = createdAttachment.Id }, createdAttachment);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttachment(int id)
        {
            var deletedAttachment = await _attachmentService.DeleteAttachmentAsync(id);
            if (deletedAttachment == null)
                return NotFound();

            return Ok(deletedAttachment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAttachment(int id, [FromBody] AttachmentDTO attachmentDto)
        {
            if (attachmentDto == null)
                return BadRequest();

            var updatedAttachment = await _attachmentService.UpdateAttachment(attachmentDto, id);
            if (updatedAttachment == null)
                return NotFound();

            return Ok(updatedAttachment);
        }

        [HttpPut("recovery/{id}")]
        public async Task<IActionResult> RecoverAttachment(int id)
        {
            var recoveredAttachment = await _attachmentService.RecoveryAttachmentAsync(id);
            if (recoveredAttachment == null)
                return NotFound();

            return Ok(recoveredAttachment);
        }

     
    }
}
