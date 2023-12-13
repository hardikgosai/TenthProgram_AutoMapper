using AutoMapper;
using Getri_AutoMapper.DTO;
using Getri_AutoMapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper mapper;

        public EmployeeController(IMapper _mapper)
        {
            mapper = _mapper;
        }

        [HttpGet("FetchEmployee")]
        public Employee GetEmployee()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO()
            {
                EmpId = 101,
                EmpNameDTO = "John",
                EmpAge = 30,
                EmpCity = "New York",
                EmpGender = "Male"
            };

            return mapper.Map<Employee>(employeeDTO);
        }

    }
}
