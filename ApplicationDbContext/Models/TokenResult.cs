using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class TokenResult
    {
        public string Token { get; }
        public DateTime ExpirationTime { get; }
        public TokenResult(string token, DateTime expirationTime)
        {
            Token = token;
            ExpirationTime = expirationTime;
        }
    }
}
