using Application.Contracts.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyProfileRepository : ICompanyProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CompanyProfile> GetByTickerAsync(string ticker)
        {
            return await _context.CompanyProfiles.FirstOrDefaultAsync(cp => cp.ticker == ticker);
        }

        public async Task AddAsync(CompanyProfile companyProfile)
        {
            _context.CompanyProfiles.Add(companyProfile);
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

