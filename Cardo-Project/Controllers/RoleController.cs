using Application.Moduls.RoleModul.Command;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleCommand command)
        {
            var result = await _mediator.Send(command);

                return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleCommand command)
        {
            
            var result = await _mediator.Send(command);

            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteRole([FromBody] DeleteRoleCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
