using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Moduls.UserModul.Query;
using Application.Services.Contracts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IServiceManager _service;



        public UserController( IMediator mediator, IStringLocalizer<CreateUserCommand> localizer, IServiceManager service)
        {
            _mediator = mediator;
            _localizer = localizer;
            _service = service;
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
            return Ok(new { Message = "User registered successfully. Verification email sent." });
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _mediator.Send(new GetAllUsersQuery(TrackChanges:false));
            return Ok(users);
        }

        [HttpGet("activate")]
        public async Task<IActionResult> ActivateAccount([FromQuery] string token )
        {
            await _mediator.Send(new GetUserByTokenQuery { Token = token });
              
            
            return Ok(new { Message = "Account activated successfully." });
        }
        [HttpPost("requestNewToken")]
        public async Task<IActionResult> RequestNewToken([FromBody] RequestNewTokenCommand request)
        {

            var result = await _mediator.Send(request);

            return Ok(new { Message = result });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user, user.CultureId))
                return Unauthorized();
            var tokenDto = await _service.AuthenticationService.CreateToken();
            return Ok(tokenDto);
        }

    }
}