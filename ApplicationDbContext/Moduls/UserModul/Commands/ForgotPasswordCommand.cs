using Application.Contracts;
using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Application.Moduls.UserModul.Commands
{
    public class ForgotPasswordCommand : IRequest<string>
    {
        public string Email { get; init; }
        public string CultureId { get; init; }
    }

    public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;
        private readonly UserManager<User> _userManager;


        public ForgotPasswordCommandHandler(IUserRepository userRepository, IEmailService emailService, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _emailService = emailService;
            _userManager = userManager;
        }

        public async Task<string> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }

            user.PasswordRecoveyToken = await _userManager.GeneratePasswordResetTokenAsync(user);
          //  user.PasswordRecoveyToken= HttpUtility.UrlDecode(user.PasswordRecoveyToken);
            user.PasswordRecoveyTokenCreationTime = DateTime.Now;

            await _userRepository.SaveChangesAsync();

            string emailBody = $@"
                <html>
                <body>
                    <p>Dear {user.FirstName},</p>
                    <p>You have requested a password recovery. Please click the link below to reset your password:</p>
                    <p><a href='https://www.yourapp.com/reset-password?token={user.PasswordRecoveyTokenCreationTime}'>Reset Password</a></p>
                    <p>If you didn't request this recovery, please ignore this email.</p>
                    <p>Thank you!</p>
                </body>
                </html>";

            await _emailService.SendEmailAsync(user.Email, "Password Recovery", emailBody);
            return user.PasswordRecoveyToken;
        }
    }
}
