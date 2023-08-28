using Application.Moduls.PermissionModul.Command;
using Application.Moduls.RolePermissionModul;
using Application.Moduls.UserPermissionModul.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        [HttpPost("admin/create")]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Create([FromBody] CreatePermissionCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            command.CultureId = cultureId;
            var result = await _mediatR.Send(command);
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("admin/assignPermissionToRole")]
        public async Task<IActionResult> AssignPermissionToRole([FromBody] AssignPermissionToRoleCommand command)
        {
          
                var result = await _mediatR.Send(command);
                return Ok(result);
            
        }

       [Authorize(Roles = "Admin")]
        [HttpPost("admin/assignPermissionToUser")]
        public async Task<IActionResult> AssignPermissionToUser([FromBody] CreateUserPermissionCommand command)
        {

            var result = await _mediatR.Send(command);
            return Ok(result);

        }

    }
}
