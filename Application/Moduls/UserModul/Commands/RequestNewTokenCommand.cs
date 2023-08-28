﻿using Application.Contracts.Repositories;
using Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Application.Moduls.UserModul.Commands
{
    public sealed record RequestNewTokenCommand : IRequest<string>
    {
        public string Email { get; set; }
        public string CultureId { get; set; }
    }

    internal sealed class RequestNewTokenCommandHandler : IRequestHandler<RequestNewTokenCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;
        private readonly UserManager<User> _userManager;


        public RequestNewTokenCommandHandler(IUserRepository userRepository, IEmailService emailService, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _emailService = emailService;
            _userManager = userManager;
        }

        public async Task<string> Handle(RequestNewTokenCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }

            var newToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            user.Token = newToken;
            user.TokenCreationTime = DateTime.Now;

            await _userRepository.SaveChangesAsync();

            string emailBody = $"Dear {user.FirstName},<br><br>"
                + "Your previous token has expired. Please click the link below to activate your account with the new token:<br><br>"
                + $"<a href=\"https://localhost:7198/api/user/activate?token={user.Token}\">Activate Account</a><br><br>"
                + "Thank you!<br>";

            await _emailService.SendEmailAsync(user.Email, "New Token Request", emailBody);

            return "New token has been sent to your email.";
        }
    }
}
