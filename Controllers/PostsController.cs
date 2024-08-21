    using global::TaskManagementSystem.Data.Models;
    using global::TaskManagementSystem;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Hosting;
    using System.Collections.Generic;
    using System.Net.NetworkInformation;
    using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    
         
        [Route("api/[controller]")]
        [ApiController]
        public class PostsController : ControllerBase
        {
            private readonly AttachmentService _postService;

            public PostsController(AttachmentService postService)
            {
                _postService = postService;
            }

            [HttpGet]
            public async Task<IActionResult> GetAllPosts()
            {
                var posts = await _postService.GetAllPostsAsync();
                return Ok(posts);
            }

          
    }

}
