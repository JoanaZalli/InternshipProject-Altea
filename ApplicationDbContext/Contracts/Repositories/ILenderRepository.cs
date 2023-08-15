using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface ILenderRepository
    {
        Task<IEnumerable<Lender>> GetLenderAsync();

        Task<Lender> GetLenderByNameAsync(string lenderName);
        Task<Lender> GetLenderByIdAsync(int lenderId);

    }
}
