using Application;
using Application.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TokenVerificationService : ITokenVerificationService
    {
        public async Task<bool> VerifyTokenAsync(string token, DateTime tokenCreationTime)
        {
            return !TokenGenerator.IsTokenExpired(tokenCreationTime);
        }
    }
}
