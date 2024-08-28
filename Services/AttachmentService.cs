using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskManagementSystem.Data;
using TaskManagementSystem.Data.Models;
using TaskManagementSystem.DTO;

namespace TaskManagementSystem.Services
{
	public class AttachmentService
	{
        private readonly HttpClient _httpClient;
        private ProjectContext _AttachmentContext;
        private readonly IMapper _imapper;

        public AttachmentService(HttpClient httpClient , ProjectContext projectContext, IMapper mapper)
		{
                _httpClient = httpClient;
            _AttachmentContext = projectContext;
            _imapper = mapper;

            

        }
      
        public async Task<List<AttachmentDTO>> GetAllAttachment()
        {
            try
            {
                var attachments = await _AttachmentContext.Attachments.Where(e => e.IsDeleted == false).ToListAsync();
                List<AttachmentDTO> attachmentDto = _imapper.Map<List<AttachmentDTO>>(attachments);
                return attachmentDto;
            }
            catch (Exception ex)
            {
                // Handle the exception or log it as needed
                return new List<AttachmentDTO>();
            }
        }

        public async Task<AttachmentDTO> GetAttachmentById(int id)
        {
            try
            {
                var attachment = await _AttachmentContext.Attachments.Where(e => e.IsDeleted==false && e.Id==id).FirstOrDefaultAsync();
                
                var attachmentDto = _imapper.Map<AttachmentDTO>(attachment);
                    
                return attachmentDto;
                


            }
            catch (Exception ex)
            {
                return new AttachmentDTO();
            }
        }
    public async Task<Attachment> CreateAttachmentAsync(AttachmentDTO Attachment)
    {
        if (Attachment == null)
        {
            throw new ArgumentNullException(nameof(Attachment));
        }
        Attachment AttachmentEntity = _imapper.Map<Attachment>(Attachment);

        _AttachmentContext.Attachments.Add(AttachmentEntity);

        await _AttachmentContext.SaveChangesAsync();
        return AttachmentEntity;



    }
        public async Task<Attachment> DeleteAttachmentAsync(int id)
        {
            var Attachment = await _AttachmentContext.Attachments.FindAsync(id);
            if (Attachment == null)
            {
                throw new ArgumentNullException(nameof(Attachment));
            }
            Attachment.IsDeleted = true;



            //_AttachmentContext.Attachments.Remove(Attachment);

            await _AttachmentContext.SaveChangesAsync();

            return Attachment;
        }
        public async Task<Attachment> UpdateAttachment(AttachmentDTO updateAttachment, int id)
        {
            if (updateAttachment == null)
            {
                throw new ArgumentNullException(nameof(updateAttachment));
            }
            var update = await _AttachmentContext.Attachments.FindAsync(id);

            update.Name=updateAttachment.Name;
            update.Path=updateAttachment.Path;
            update.Size=updateAttachment.Size;
            update.PhysicalPath=updateAttachment.PhysicalPath;
            update.Type=updateAttachment.Type;

           


            _AttachmentContext.SaveChangesAsync();



            return update;
        }
        public async Task<Attachment> RecoveryAttachmentAsync(int id)
        {
            var Attachment = await _AttachmentContext.Attachments.FindAsync(id);
            if (Attachment == null)
            {
                throw new ArgumentNullException(nameof(Attachment));
            }
            Attachment.IsDeleted = false;

            await _AttachmentContext.SaveChangesAsync();

            return Attachment;
        }
    }



}
