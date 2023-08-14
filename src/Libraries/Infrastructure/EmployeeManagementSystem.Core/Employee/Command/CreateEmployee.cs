using AutoMapper;
using EmployeeManagementSystem.Repositories.Base;
using EmployeeManagementSystem.Repositories.Interface;
using EmployeeManagementSystem.Services.Model;
using MediatR;

namespace EmployeeManagementSystem.Core.Employee.Command;

public record  CreateEmployee(VmEmployee vmEmployee):IRequest <VmEmployee>;

public class CreateEmployeeHandaler : IRequestHandler<CreateEmployee, VmEmployee>

{
    private readonly IEmployeeRepository _EmployeeRepository;
    private readonly IMapper _mapper;
    public CreateEmployeeHandaler(IEmployeeRepository EmployeeRepository, IMapper mapper)
    {
        _EmployeeRepository = EmployeeRepository;
        _mapper = mapper;
    }
    public async Task<VmEmployee> Handle(CreateEmployee request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Employee>(request.vmEmployee);
        return await _EmployeeRepository.Add(data);
    }
}