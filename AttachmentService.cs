using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem.Services
{
	public class AttachmentService
	{
        private readonly HttpClient _httpClient;
        private ProjectContext _projectContext;

        public AttachmentService(HttpClient httpClient , ProjectContext projectContext)
		{
                _httpClient = httpClient;
            _projectContext = projectContext;
        }
            public async Task<List<Attachment>> GetAllAttachment()
            {
            try
            {

                return await _projectContext.Attachments.ToListAsync();
            }
            catch(Exception ex)
            {
                return new List<Attachment>();
            }
            }
        }
	
}
