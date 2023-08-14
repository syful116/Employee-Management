using EmployeeManagementSystem.Core.Employee.Command;
using EmployeeManagementSystem.Core.Employee.Query;
using EmployeeManagementSystem.Core.Employee.Query.EmployeeManagementSystem.Core.Employee.Query;
using EmployeeManagementSystem.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Bakend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IMediator _mediator;
        public EmployeeController(IMediator mediator) { _mediator = mediator; }
        [HttpGet]
        public async Task<ActionResult<VmEmployee>> Get()
        {
            var data = await _mediator.Send(new GetAllEmployeeQuery());
            return Ok(data);
        }
        [HttpGet("id")]
        public async Task <ActionResult<VmEmployee>>Get(int id)
        {
            var data = await _mediator.Send(new GetEmployeebyId(id));
            return Ok(data);    
        }
        [HttpPost]
        public async Task<ActionResult<VmEmployee>> PostAsync([FromBody]VmEmployee vmEmployee)

        {
            var data = await _mediator.Send(new CreateEmployee(vmEmployee));
            return Ok(data);    
        }

        [HttpPut ("id")]

        public async Task<ActionResult<VmEmployee>> PuttAsync(int id,[FromBody] VmEmployee vmEmployee)
        {
            var data = await _mediator.Send(new UpdateEmployee(id ,vmEmployee));
            return Ok(data);
        }
        [HttpDelete("id")]
        public async Task<ActionResult<VmEmployee>> DeleteAsync(int id)
        {
            var data = await _mediator.Send(new DeleteEmployee(id));
            return Ok(data);
        }
    }
}
