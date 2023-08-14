using EmployeeManagementSystem.Repositories.Interface;
using EmployeeManagementSystem.Services.Model;
using MediatR;

namespace EmployeeManagementSystem.Core.Employee.Query
{
    public record GetEmployeebyId(int Id) : IRequest<VmEmployee>;

    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeebyId, VmEmployee>

    {

        private readonly IEmployeeRepository _EmployeeRepository;

        public GetEmployeeByIdHandler(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }
        public async Task<VmEmployee> Handle(GetEmployeebyId request,
        CancellationToken cancellationToken)
        {
            return await _EmployeeRepository.GetById(request.Id);
        }
    }
}

