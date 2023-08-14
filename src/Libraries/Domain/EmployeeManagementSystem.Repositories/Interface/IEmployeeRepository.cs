using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Services.Model;
using EmployeeManagementSystem.Shared.CommonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repositories.Interface
{
    public interface IEmployeeRepository:IRepository<Employee,VmEmployee,int>
    {
    }
}
