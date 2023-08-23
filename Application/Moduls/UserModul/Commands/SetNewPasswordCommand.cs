using Application.Contracts;
using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Application.Moduls.UserModul.Commands
{
    public class SetNewPasswordCommand : IRequest<string>
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }    
        public string ConfirmPassword { get; set; }
        public string CultureId { get; set; }


    }

    public class SetNewPasswordCommandHandler : IRequestHandler<SetNewPasswordCommand, string>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;


        public SetNewPasswordCommandHandler(IAuthenticationService authenticationService, IUserRepository userRepository, UserManager<User> userManager)

        {
            _authenticationService = authenticationService;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<string> Handle(SetNewPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }
            DateTime time = user.PasswordRecoveyTokenCreationTime;
            bool isTokenExpired = TokenGenerator.IsTokenExpired(time, 15);
            if (isTokenExpired)
            {
                throw new TokenExpiredException(request.CultureId);
            }
            if (request.NewPassword != request.ConfirmPassword)
            {
                throw new PasswordsDoNotMatchException(request.CultureId);
            }

            var result = await _userManager.ResetPasswordAsync(user, user.PasswordRecoveyToken, request.NewPassword);
            if (result.Succeeded)
            {
                user.PasswordRecoveyToken = null;
                user.TokenCreationTime = default(DateTime);
                await _userManager.UpdateAsync(user);
                return "Password was changed!";
            }
            return "Bad request";
        }
    }
}
