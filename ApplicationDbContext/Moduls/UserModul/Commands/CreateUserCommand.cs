using Application.Contracts;
using Application.Contracts.Repositories;
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
        public string Token { get; set; } = "";
        public DateTime TokenCreationTime { get; set; }
    }

    public sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserRegistrationDTO>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateUserCommand> _validationLocalizationService;
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public CreateUserCommandHandler(IAuthenticationService authenticationService, IMapper mapper,
            IStringLocalizer<CreateUserCommand> validationLocalizationServic, IUserRepository userRepository,
            IEmailService emailService)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationServic;
            _userRepository = userRepository;
            _emailService = emailService;

        }
        public async Task<UserRegistrationDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var token = TokenGenerator.GenerateToken();
            request.Token = token;
            request.TokenCreationTime = DateTime.Now;
            var userForRegistration = _mapper.Map<UserRegistrationDTO>(request);
            var userValidation = new CreateUserValidations(_validationLocalizationService,request.CultureId,_userRepository);
            var validationResult = await userValidation.ValidateAsync(request);
            var emailInUse = await _userRepository.FindByEmailAsync(request.Email);
            var usernameInUse = await _userRepository.FindByUsernameAsync(request.UserName);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new UserRegisterFluentValidationException(errorMessages);
            }
            if(emailInUse!=null)
            {
                
                throw new EmailInUseException(string.Format( request.Email),request.CultureId);

            }
            if(usernameInUse!=null)
            {
                throw new UserNameInUseException(string.Format(request.UserName),request.CultureId);
            }



            string emailBody = $"Dear {userForRegistration.FirstName},<br><br>"
                  + "Welcome to our website! Please click the link below to activate your account:<br><br>"
                  + $"<a href=\"https://localhost:7198/api/user/activate?token={userForRegistration.Token}\">Activate Account</a><br><br>"
                  + "Thank you!<br>";
            await _emailService.SendEmailAsync(userForRegistration.Email, "Account Activation", emailBody);


            await _authenticationService.CreateUser(userForRegistration);
            var user = _mapper.Map<UserRegistrationDTO>(userForRegistration);

           
            return user;
        }
    }


}
