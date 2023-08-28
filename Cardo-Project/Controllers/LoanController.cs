using Application.Moduls.LoanModul.Command;
using Application.Moduls.LoanModul.Query;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Loan Officer")]
        [HttpPost("loanOfficer/validateLoan")]
        public async Task<IActionResult> CreateLoan([FromBody] CreateLoanCommand request, [FromHeader(Name = "Accept-Language")] string cultureId)
        {

            var command = new CreateLoanCommand
            {
                CultureId = cultureId,
                ApplicationId = request.ApplicationId
            };

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [Authorize(Roles = "Loan Officer")]
        [HttpPut("loanOfficer/updateLoanStatus/{loanId}/{cultureId}")]
        public async Task<IActionResult> UpdateLoanStatus(int loanId, string cultureId, [FromBody] int loanStatusId)
        {
            var command = new EditLoanStatusCommand
            {
                CultureId = cultureId,
                LoanId = loanId,
                LoanStatusId = loanStatusId
            };

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [Authorize(Roles = "Loan Officer")]
        [HttpGet("loanOfficer/getLoansByBorrower/{borrowerId}")]
        public async Task<IActionResult> GetLoansByBorrower(int borrowerId, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            var query = new GetLoansOfABorrowerQuery { BorrowerId = borrowerId, CultureId=cultureId };
            var loans = await _mediator.Send(query);

            return Ok(loans);
        }

        [Authorize(Roles = "Loan Officer")]
        [HttpGet("loanOfficer/getLoanDetails/{loanId}")]
        public async Task<IActionResult> GetLoanDetails(int loanId, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            var query = new GetDetailsOfALoanQuery { LoanId = loanId, CultureId = cultureId };
            var loans = await _mediator.Send(query);

            return Ok(loans);
        }
    }
}