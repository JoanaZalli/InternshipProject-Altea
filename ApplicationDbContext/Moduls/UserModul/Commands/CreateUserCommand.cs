using Application.Contracts;
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
            var userValidation = new UserValidations();
            var validationResult = await userValidation.ValidateAsync(userForRegistration);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new UserRegisterFluentValidationException(errorMessages);
            }

            await _authenticationService.CreateUser(userForRegistration);
            var user = _mapper.Map<UserRegistrationDTO>(userForRegistration);
            return user;
        }
    }


}
