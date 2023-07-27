using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class TokenGenerator
    {
        private const int TokenLength = 64;
        private const int TokenExpirationMinutes = 30;

        public static string GenerateToken()
        {
            var randomNumber = new byte[TokenLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        public static bool IsTokenExpired(DateTime tokenCreationTime, int tokenExpirationMinutes = TokenExpirationMinutes)
        {
            return DateTime.UtcNow > tokenCreationTime.AddMinutes(TokenExpirationMinutes);
        }
       
    }
}
