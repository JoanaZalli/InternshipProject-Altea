using Application.Moduls.ApplicationModul.Commands;
using Application.Moduls.BorrowerModul.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {


        private readonly IMediator _mediator;
        public ApplicationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateBorrower([FromBody] CreateApplicationCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            command.CultureId = cultureId;
            var result = await _mediator.Send(command);
            return Ok(result);

        }
    }
}
