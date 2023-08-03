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
    public class BorrowerRepository : RepositoryBase<Borrower>, IBorrowerRepository
    {
        public BorrowerRepository(ApplicationDbContext context) : base(context) { }

        public Borrower CreateBorrower(Borrower borrower)
        {
            borrower.DateCreated = DateTime.Now;
            borrower.DateUpdated = DateTime.Now;
            _context.Add(borrower);
            _context.SaveChanges();
            return borrower;
        }
        public async Task<List<Borrower>> GetBorrowersByUserIdAsync(string userId)
        {
            var borrwers = await _context.Borrowers.Where(b => b.UserId == userId).ToListAsync();
            return borrwers;
        }
    }
}
