using EmployeeManagementSystem.Repositories.Interface;
using EmployeeManagementSystem.Services.Model;
using MediatR;

namespace EmployeeManagementSystem.Core.Employee.Command;

public record DeleteEmployee(int Id) : IRequest<VmEmployee>;
public class DeleteProductHandler : IRequestHandler<DeleteEmployee, VmEmployee>
{
    private readonly IEmployeeRepository _employeeRepository;
    public DeleteProductHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public Task<VmEmployee> Handle(DeleteEmployee request, CancellationToken cancellationToken)
    {
       return _employeeRepository.Delete(request.Id);
    }
}