using Application.Contracts.Repositories;
using Application.DTOS;
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
        public async Task<IEnumerable<Borrower>> GetBorrowersByUserIdAsync(string userId)
        {
            
            var borrowers = await _context.Borrowers.Include(b => b.CompanyType).Where(b => b.UserId == userId) .Select(b => new Borrower
               {
                   Id = b.Id,
                   CompanyName = b.CompanyName,
                   CompanyType = b.CompanyType, 
                   VatNumber = b.VatNumber,
                   FiscalCode = b.FiscalCode,
                   DateCreated = b.DateCreated,
                   DateUpdated = b.DateUpdated,
                }).ToListAsync();

            return borrowers;
        }

        public async Task<Borrower> GetBorrowerByIdAsync(int id)
        {
            var borrower = await _context.Borrowers.FirstOrDefaultAsync(b => b.Id == id);
            return borrower;
        }
    }
}
