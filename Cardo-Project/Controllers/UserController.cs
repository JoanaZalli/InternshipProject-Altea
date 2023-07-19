using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Services.Contracts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cardo_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly IMediator _mediator;

        public UserController(IServiceManager serviceManager, IMediator mediator)
        {
            _serviceManager = serviceManager;
            _mediator = mediator;
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