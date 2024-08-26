    using global::TaskManagementSystem.Data.Models;
    using global::TaskManagementSystem;
    using Microsoft.AspNetCore.Mvc;
 using TaskManagementSystem.Services;
using TaskManagementSystem.Data;

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

        

    }

}
