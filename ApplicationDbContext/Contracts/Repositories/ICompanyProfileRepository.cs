using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface ICompanyProfileRepository
    {
        Task<CompanyProfile> GetByTickerAsync(string ticker);
        Task AddAsync(CompanyProfile companyProfile);
        Task SaveChangesAsync();
    }
}
