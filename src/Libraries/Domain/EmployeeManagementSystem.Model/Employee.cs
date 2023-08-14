using EmployeeManagementSystem.Shared.Common;

namespace EmployeeManagementSystem.Model;

public class Employee : BaseEntity, IEntity
{
    public string EmployeeName { get; set; }   = string.Empty;

    public string EmployeeDepartment { get; set; } = string.Empty;

    public  string Email { get; set; }  =string.Empty;
    public double Salary { get; set; }  
    public int Id { get; set; } 

}

