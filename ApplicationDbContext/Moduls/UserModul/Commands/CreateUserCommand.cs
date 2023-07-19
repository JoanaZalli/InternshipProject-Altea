using Application.Contracts;
using Application.Contracts.ValidationLocalization;
using Application.DTOS;
using Application.Exceptions;
using Application.Validations;
using AutoMapper;
using MediatR;
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
        private readonly IUserValidationLocalizationService _validationLocalizationService;

        public CreateUserCommandHandler(IAuthenticationService authenticationService, IMapper mapper, IUserValidationLocalizationService validationLocalizationServic)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationServic;
        }
        public async Task<UserRegistrationDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userForRegistration = _mapper.Map<UserRegistrationDTO>(request);
            var userValidation = new UserValidations(_validationLocalizationService, request.CultureId);
            var validationResult = await userValidation.ValidateAsync(userForRegistration);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService.GetValidationMessage(error.ErrorMessage)).ToList();
                throw new UserRegisterFluentValidationException(errorMessages);
            }

            await _authenticationService.CreateUser(userForRegistration);
            var user = _mapper.Map<UserRegistrationDTO>(userForRegistration);
            return user;
        }
    }


}
