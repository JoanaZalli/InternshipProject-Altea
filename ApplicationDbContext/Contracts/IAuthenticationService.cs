using Application.DTOS;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> CreateUser(UserRegistrationDTO userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuthentication, string CultureId);
        Task<AuthenticationTokenDTO> CreateToken(bool Exp);
        Task<IdentityResult> UpdateUserPassword(string userId, string newPassword, string cultureId);



    }
}
