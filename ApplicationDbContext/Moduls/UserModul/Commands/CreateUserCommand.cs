using Application.Contracts;
using Application.DTOS;
using Application.Exceptions;
using Application.Validations;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Text.Json.Serialization;

namespace Application.Moduls.UserModul.Commands
{
    public sealed record CreateUserCommand : IRequest<UserRegistrationDTO>
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? UserName { get; init; }
        public string? Password { get; init; }
        public string? Email { get; init; }

        [JsonPropertyName("Prefix")]
        public int PrefixId { get; init; } // Added PrefixId property
        public string? PhoneNumber { get; init; }
        public string CultureId { get; init; } 
    }

    public sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserRegistrationDTO>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateUserCommand> _validationLocalizationService;


        public CreateUserCommandHandler(IAuthenticationService authenticationService, IMapper mapper, IStringLocalizer<CreateUserCommand> validationLocalizationServic )
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationServic;

        }
        public async Task<UserRegistrationDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userForRegistration = _mapper.Map<UserRegistrationDTO>(request);
            var userValidation = new CreateUserValidations(_validationLocalizationService,request.CultureId);
            var validationResult = await userValidation.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new UserRegisterFluentValidationException(errorMessages);
            }

            await _authenticationService.CreateUser(userForRegistration);
            var user = _mapper.Map<UserRegistrationDTO>(userForRegistration);
            return user;
        }
    }


}
