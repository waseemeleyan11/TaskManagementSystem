using AutoMapper;
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

        }
    }
}
