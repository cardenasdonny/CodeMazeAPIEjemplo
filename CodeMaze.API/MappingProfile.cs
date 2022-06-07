using AutoMapper;
using CodeMaze.Entities.DataTransferObjects;
using CodeMaze.Entities.Models;

namespace CodeMaze.API
{
    public class MappingProfile : Profile 
    { 
        public MappingProfile() {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress, 
                    opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>();

            CreateMap<CompanyForCreationDto, Company>();
            CreateMap<EmployeeForCreationDto, Employee>();
        }
        
    }
}
