using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
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
            public async Task<List<Attachment>> GetAllPostsAsync()
            {
                var response = await _httpClient.GetAsync("posts");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<List<Attachment>>(responseBody, options);
            }
	}
}
