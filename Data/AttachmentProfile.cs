using AutoMapper;
using TaskManagementSystem.Data.Models;
using TaskManagementSystem.DTO;
namespace TaskManagementSystem.Data
{
    public class AttachmentProfile : Profile
    {
        public AttachmentProfile()
        {
            CreateMap<Attachment, AttachmentDTO>().ReverseMap();
            CreateMap<Attachment, AttachmentDTO>().ReverseMap();


        }
    }
}