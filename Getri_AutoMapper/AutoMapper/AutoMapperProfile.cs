using AutoMapper;
using Getri_AutoMapper.DTO;
using Getri_AutoMapper.Models;

namespace Getri_AutoMapper.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDTO, Employee>()
                .ForMember(d => d.EmpName, opt => opt.MapFrom(s => s.EmpNameDTO));
        }
    }
}
