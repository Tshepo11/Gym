using AutoMapper;
using GymMan.Entity;
using GymMan.DTO;

namespace GymMan.Mapping
{
    public class EmployeeApplicationAutoMapperProfile : Profile
    {
        //Mapping the Employee entity to the EmployeeDto
        public EmployeeApplicationAutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateUpdateEmployeeDto, Employee>();
        }
    }
}
