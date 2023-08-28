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
     public class LenderRepository : RepositoryBase<Lender>, ILenderRepository
    {
        public LenderRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Lender>> GetLenderAsync()
        {
            var lenders = await _context.Lenders.ToListAsync();
            return lenders;
        }

       public async Task<Lender> GetLenderByNameAsync(string lenderName)
        {
            var lender= await _context.Lenders.FirstOrDefaultAsync(l=>l.Name==lenderName);
            return lender;
        }
        public async Task<Lender> GetLenderByIdAsync(int lenderId)
        {
            var lender = await _context.Lenders.FirstOrDefaultAsync(l => l.Id == lenderId);
            return lender;
        }
    }
}
