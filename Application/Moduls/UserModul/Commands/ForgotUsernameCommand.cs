using Application.Contracts;
using Application.Contracts.Repositories;
using Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.UserModul.Commands
{
    public sealed record ForgotUsernameCommand : IRequest<string>
    {
        public string Email { get; set; }
        public string CultureId { get; set; }
    }
    internal sealed class ForgotUsernameHandler : IRequestHandler<ForgotUsernameCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;


        public ForgotUsernameHandler(IUserRepository userRepository, IEmailService emailService)
        {
            _userRepository = userRepository;
            _emailService = emailService;

        }

        public async Task<string> Handle(ForgotUsernameCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }

            string emailBody = $"Dear {user.FirstName}<br><br>"
                + $"Your username is:<strong>{user.UserName}</strong><br><br>"
                + "Thank you!<br>";

            await _emailService.SendEmailAsync(user.Email, "Forgot Username Request", emailBody);

            return "Username has been sent in your email adress!";
        }
    }



}
