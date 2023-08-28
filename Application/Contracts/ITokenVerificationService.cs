using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface ITokenVerificationService
    {
        Task<bool> VerifyTokenAsync(string token, DateTime tokenCreationTime);
    }
}
