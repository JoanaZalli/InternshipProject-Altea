using Application.Contracts;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Moduls.UserModul.Query;
using AutoMapper;
using Domain.Entities;
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
        [Authorize(Roles = "Loan Officer")]
        public async Task<ActionResult<IEnumerable<UserRegistrationDTO>>>GetUsers(string? sortBy = null, bool? sortAscending = null, string? filter=null)
        {
            var query = new GetAllUsersQuery
            {
                SortBy = sortBy,
                SortAscending = sortAscending,
                Filter = filter
            };
            var users=await _mediator.Send(query);
            return Ok(users);
        }

        [HttpGet("activate")]
        public async Task<IActionResult> ActivateAccount([FromQuery] string token, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            await _mediator.Send(new GetUserByTokenQuery { Token = token, CultureId=cultureId });
              
            
            return Ok(new { Message = "Account activated successfully." });
        }
        [HttpPost("requestNewToken")]
        public async Task<IActionResult> RequestNewToken([FromBody] RequestNewTokenCommand request, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            request.CultureId=cultureId;
            var result = await _mediator.Send(request);

            return Ok(new { Message = result });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user, user.CultureId))
                return Unauthorized();
            var tokenDto = await _service.AuthenticationService.CreateToken(Exp:true);
            return Ok(tokenDto);
        }

        [HttpPost("forgotUsername")]
        public async Task<IActionResult> ForgotUsername([FromBody] ForgotUsernameCommand request, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            request.CultureId=cultureId;
            var result = await _mediator.Send(request);

            return Ok(new { Message = result });
        }
       
        
        [HttpPost("forgotPassword")]
        public async Task<IActionResult> PasswordRecovery([FromBody] ForgotPasswordCommand request, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            request.CultureId= cultureId;
            var token = await _mediator.Send(request);

            return Ok(new { Message = "Password recovery initiated. Check your email for the recovery link and token.", PasswordRecoveyToken = token });
        }
        [HttpPut("setNewPassword")]
        public async Task<IActionResult> SetNewPasswordWithToken([FromBody] SetNewPasswordCommand request, [FromHeader(Name = "Accept-Language")] string cultureId)
        {
            request.CultureId= cultureId;
            var result = await _mediator.Send(request);

            return Ok(new { Message = result });
        }
    }
}