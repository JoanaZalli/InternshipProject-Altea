using Application.Moduls.PermissionModul.Command;
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
        public async Task<IActionResult> Create([FromBody] CreatePermissionCommand command)
        {
            var result = _mediatR.Send(command);
            return Ok();
        }
    }
}
