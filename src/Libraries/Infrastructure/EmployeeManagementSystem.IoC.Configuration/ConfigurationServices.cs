using EmployeeManagementSystem.Core;
using EmployeeManagementSystem.Core.Mapper;
using EmployeeManagementSystem.Infrastructure;
using EmployeeManagementSystem.Repositories.Base;
using EmployeeManagementSystem.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementSystem.IoC.Configuration

{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddExtention(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmployeeManagementSystemDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DbConnection")
              
               
               ));

            services.AddAutoMapper(typeof(CommonMapper).Assembly);

            services.AddTransient< IEmployeeRepository, EmployeeRepository>();
          
            services.AddMediatR(options => options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));

            return services;
        }
    }
}