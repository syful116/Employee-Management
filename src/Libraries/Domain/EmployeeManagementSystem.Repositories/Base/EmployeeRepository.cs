
using AutoMapper;
using EmployeeManagementSystem.Infrastructure;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repositories.Interface;
using EmployeeManagementSystem.Services.Model;
using EmployeeManagementSystem.Shared.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Repositories.Base
{
    public class EmployeeRepository : RepositoryBase<Employee, VmEmployee, int>, IEmployeeRepository
    {
        public EmployeeRepository(IMapper mapper, EmployeeManagementSystemDbContext dbContext) : base(mapper, dbContext)
        {
        }
    }
}

      

 

