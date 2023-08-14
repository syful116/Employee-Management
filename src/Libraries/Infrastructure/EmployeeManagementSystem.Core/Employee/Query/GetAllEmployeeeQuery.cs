using AutoMapper;
using EmployeeManagementSystem.Repositories.Interface;
using EmployeeManagementSystem.Services.Model;
using MediatR;

namespace EmployeeManagementSystem.Core.Employee.Query
{
    namespace EmployeeManagementSystem.Core.Employee.Query
    {
        public record GetAllEmployeeQuery() :
        IRequest<IEnumerable<VmEmployee>>;
        public class GetAllProductQueryHandler :
        IRequestHandler<GetAllEmployeeQuery,
        IEnumerable<VmEmployee>>
        {
            private readonly IEmployeeRepository _EmployeeRepository;

            public GetAllProductQueryHandler(IEmployeeRepository
            EmployeeRepository, IMapper mapper)
            {
                _EmployeeRepository = EmployeeRepository;
            }
            public async Task<IEnumerable<VmEmployee>>
            Handle(GetAllEmployeeQuery request, CancellationToken
            cancellationToken)
            {
                var result = await _EmployeeRepository.GetList();
                return result;
            }
        }
    }
}
