using Application.DTOS;
using Application.Moduls.BorrowerModul.Command;
using Application.Moduls.BorrowerModul.Query;
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
        [Authorize(Roles = "Loan Officer")]
        [HttpGet("borrower/{borrowerId}")]
        public async Task<IActionResult> GetBorrowerById(int borrowerId, [FromHeader(Name = "Accept-Language")] string culture)
        {
            var query = new GetBorrowerByIdQuery { BorrowerId = borrowerId };
            query.Culture = culture;
            var result = await _mediator.Send(query);
            return Ok(result);

        }
       // [Authorize(Roles = "Loan Officer")]
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<BorrowerDTO>>> GetBorrowersByUserId(string userId, string? sortBy = null, bool? sortAscending = null, string? filter = null)
        {
            var query = new GetAllBorrowersOfAUserQuery
            {
                UserId = userId,
                SortBy = sortBy,
                SortAscending = sortAscending,
                Filter = filter
            };

            var borrowers = await _mediator.Send(query);
            return Ok(borrowers);
        }

    }
}
