using AutoMapper;
using CMDataManager.DTOs;
using CMDataManager.Models;

namespace CMDataManager.Profiles
{
    public class ProjectsProfile : Profile
    {
        public ProjectsProfile()
        {
            CreateMap<Project, ProjectReadDTO>();
            CreateMap<ProjectCreateDTO, Project>();
            CreateMap<ProjectUpdateDTO, Project>();
            CreateMap<Project, ProjectUpdateDTO>();
        }
    }
}
