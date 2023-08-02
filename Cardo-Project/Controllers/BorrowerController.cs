using Application.Moduls.BorrowerModul.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BorrowerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateBorrower([FromBody] CreateBorrowerCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            command.CultureId = cultureId;
            var result = await _mediator.Send(command);
                return Ok("Borrower Created!");
            
        }
    }
}
