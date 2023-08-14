using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Infrastructure;

public class EmployeeManagementSystemDbContext :DbContext
{

    public EmployeeManagementSystemDbContext(DbContextOptions<EmployeeManagementSystemDbContext> options) : base(options) 
    { 

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeManagementSystemDbContext).Assembly);
    }
}
