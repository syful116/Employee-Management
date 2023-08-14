using AutoMapper;
using EmployeeManagementSystem.Repositories.Interface;
using EmployeeManagementSystem.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Core.Employee.Command
{
    public record  UpdateEmployee(int id,VmEmployee VmEmployee):IRequest<VmEmployee>;
    public class UpdateEmployeeHandaler: IRequestHandler<UpdateEmployee, VmEmployee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public UpdateEmployeeHandaler(IEmployeeRepository employeeRepository,IMapper mapper)
        { 
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<VmEmployee> Handle(UpdateEmployee request, CancellationToken cancellationToken)
        {
           var data =_mapper.Map<Model.Employee>(request.VmEmployee);
            return await _employeeRepository.Update(request.id,data);
        }
    }   
    }
