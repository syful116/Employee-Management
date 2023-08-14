using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Shared.Enum;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Infrastructure.Persistence.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public object? Id { get; private set; }

    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee");
        builder.HasKey(x => x.Id);
        //builder.HasData(new
        //{
        //    Id = 1,
        //    EmployeeName = "Rahim",
        //    EmployeeDepartment = "IT",
        //    Email = "rok@kotmail.com",
        //    Salary = 232323.00,
        //    CreatedBy = "1",
        //    Created = DateTimeOffset.Now,
        //    Status = EntityStatus.Created
        //});
    }


}




 
       



    