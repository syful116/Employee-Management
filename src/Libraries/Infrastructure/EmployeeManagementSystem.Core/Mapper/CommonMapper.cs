using AutoMapper;
using EmployeeManagementSystem.Services.Model;

namespace EmployeeManagementSystem.Core.Mapper;

public class CommonMapper : Profile
{
    public CommonMapper()

    {
         CreateMap< VmEmployee, Model.Employee>().ReverseMap();

    }

}

