using EmployeeManagementSystem.Shared.Common;

namespace EmployeeManagementSystem.Services.Model
{
    public class VmEmployee:IVm
    {
        public int Id { get; set; } 

        public string EmployeeName { get; set; } = string.Empty;
     
        public string EmployeeDepartment { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public double Salary { get; set; }

       



    }
}
