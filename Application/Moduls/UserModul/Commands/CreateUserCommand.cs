﻿using Application.Contracts;
using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Validations;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System.Net.Sockets;
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
        public int PrefixId { get; init; } 
        public string? PhoneNumber { get; init; }
        public string CultureId { get; set; }
        public string Token { get; set; } = "";
    }

    public sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserRegistrationDTO>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateUserCommand> _validationLocalizationService;
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;
        private readonly UserManager<User> _userManager;

        public CreateUserCommandHandler(IAuthenticationService authenticationService, IMapper mapper,
            IStringLocalizer<CreateUserCommand> validationLocalizationServic, IUserRepository userRepository,
            IEmailService emailService, UserManager<User> userManager)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _validationLocalizationService = validationLocalizationServic;
            _userRepository = userRepository;
            _emailService = emailService;
            _userManager = userManager;

        }
        public async Task<UserRegistrationDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var userForRegistration = _mapper.Map<UserRegistrationDTO>(request);
            var userValidation = new CreateUserValidations(_validationLocalizationService,request.CultureId);
            var validationResult = await userValidation.ValidateAsync(request);
            var emailInUse = await _userRepository.FindByEmailAsync(request.Email);
            var usernameInUse = await _userRepository.FindByUsernameAsync(request.UserName);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new FluentValidationException(errorMessages);
            }
            if(emailInUse!=null)
            {
                
                throw new EmailInUseException(string.Format(request.Email),request.CultureId);

            }
            if(usernameInUse!=null)
            {
                throw new UserNameInUseException(string.Format(request.UserName),request.CultureId);
            }

            var userT = _mapper.Map<User>(userForRegistration);
            userForRegistration.Token=await _userManager.GenerateEmailConfirmationTokenAsync(userT);
            userForRegistration.TokenCreationTime=DateTime.Now;


            await _authenticationService.CreateUser(userForRegistration);
            

            string emailBody = $"Dear {userForRegistration.FirstName},<br><br>"
                  + "Welcome to our website! Please click the link below to activate your account:<br><br>"
                  + $"<a href=\"https://localhost:7198/api/user/activate?token={userForRegistration.Token}\">Activate Account</a><br><br>"
                  + "Thank you!<br>";
            await _emailService.SendEmailAsync(userForRegistration.Email, "Account Activation", emailBody);
                        var user = _mapper.Map<UserRegistrationDTO>(userForRegistration);

        
            return user;
        }
    }


}
