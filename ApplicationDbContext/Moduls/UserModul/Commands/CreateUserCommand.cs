using Application.Contracts;
using Application.DTOS;
using Application.Exceptions;
using Application.Validations;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Moduls.UserModul.Commands
{
    public sealed record  CreateUserCommand : IRequest<UserRegistrationDTO>
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? UserName { get; init; }
        public string? Password { get; init; }
        public string? Email { get; init; }

        [JsonPropertyName("Prefix")]
        public int PrefixId { get; init; } // Added PrefixId property
        public string? PhoneNumber { get; init; }
    }

    public sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserRegistrationDTO>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IAuthenticationService authenticationService, IMapper mapper)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
        }
        public async Task<UserRegistrationDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var userForRegistration = _mapper.Map<UserRegistrationDTO>(request);

            var validator = new UserValidations();
            var validationResult = validator.Validate(userForRegistration);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
              throw new UserCreationBadRequest(errorMessages) ;
            }

          
            return userForRegistration;
        }
    }



}
