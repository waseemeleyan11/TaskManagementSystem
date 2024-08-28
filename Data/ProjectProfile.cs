﻿using AutoMapper;
using TaskManagementSystem.Data.Models;
using TaskManagementSystem.DTO;
using TaskManagementSystem.ViewModel;

namespace TaskManagementSystem.Data
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<Project, ProjectDTOWithOutUserid>().ReverseMap();
            CreateMap<Project, ProjectDTOGet>().ReverseMap();
            CreateMap<Attachment, AttachmentDTO>().ReverseMap();
            CreateMap<Attachment, AttachmentDTO>().ReverseMap();




        }
    }
}
