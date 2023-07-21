using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Services.Contracts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<CreateUserCommand> _localizer;

        public UserController( IMediator mediator, IStringLocalizer<CreateUserCommand> localizer)
        {
            _mediator = mediator;
            _localizer = localizer;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            var newCommand = new CreateUserCommand
            {
                CultureId = cultureId,
                FirstName = command.FirstName,
                LastName = command.LastName,
                UserName = command.UserName,
                Password = command.Password,
                Email = command.Email,
                PrefixId = command.PrefixId,
                PhoneNumber = command.PhoneNumber
            };
            var user = await _mediator.Send(newCommand);
            return Ok(user);
        }

    }
}