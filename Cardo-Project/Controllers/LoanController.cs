using Application.Moduls.LoanModul.Command;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("check-eligibility")]
        public async Task<IActionResult> CheckEligibility([FromBody] CreateLoanCommand request)
        {

            var command = new CreateLoanCommand
            {
                ApplicationId = request.ApplicationId
            };

            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
