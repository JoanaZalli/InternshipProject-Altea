using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Services.Contracts;
using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

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
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {

            //try
            //{
                var user = await _mediator.Send(command);
                return StatusCode(201);
            //}
            //catch (UserCreationBadRequest ex)
            //{
            //    var errorResponse = new
            //    {
            //        Message = "User creation faild!",
            //        Errors = ex.ErrorMessages
            //    };
            //    return BadRequest(errorResponse);

            //}
        }
    }
}
