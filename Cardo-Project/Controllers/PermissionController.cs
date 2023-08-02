using Application.Moduls.PermissionModul.Command;
using Application.Moduls.RolePermissionModul;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public PermissionController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreatePermissionCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            command.CultureId = cultureId;
            var result = _mediatR.Send(command);
            return Ok(result);
        }
        [HttpPost("assignPermissionToRole")]
        public async Task<IActionResult> AssignPermissionToRole([FromBody] AssignPermissionToRoleCommand command)
        {
          
                var result = await _mediatR.Send(command);
                return Ok(result);
            
        }
    }
}
