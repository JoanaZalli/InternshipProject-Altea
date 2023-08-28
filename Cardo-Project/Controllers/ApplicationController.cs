using Application.Moduls.ApplicationModul.Commands;
using Application.Moduls.ApplicationModul.Queries;
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
       [Authorize(Roles ="Borrower")]
        [HttpPost]
        public async Task<IActionResult> CreateBorrower([FromBody] CreateApplicationCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            command.CultureId = cultureId;
            var result = await _mediator.Send(command);
            return Ok(result);

        }

      [Authorize(Roles = "Loan Officer")]
        [HttpPut("loanOfficer")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductOfaApplicationCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            command.CultureId = cultureId;
            var result = await _mediator.Send(command);
            return Ok(result);
        }
      [Authorize(Roles = "Loan Officer")]
        [HttpGet("loanOfficer/{borrowerId}")]
        public async Task<IActionResult> GetBorrowersApplications(int borrowerId, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            var query = new GetApplicationsOfABorrowerQuery
            {
                BorrowerId = borrowerId,
                CultureId = cultureId
            };
           
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
