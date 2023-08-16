using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class LoanRepository : RepositoryBase<Loan>, ILoanRepository
    {
        public LoanRepository(ApplicationDbContext context) : base(context) { }
        public Loan CreateLoan(Loan loan)
        {
            loan.LoanStatusId = 1;
            loan.DateCreated = DateTime.Now;
            loan.DateUpdated = DateTime.Now;
            _context.Add(loan);
            _context.SaveChanges();
            return loan;
        }
        public async Task<Loan> GetLoanByIdAsync(int loanId)
        {
            var loan= await _context.Loans.FirstOrDefaultAsync(l=>l.Id==loanId);
            return loan;
        }
        public async Task<bool> UpdateLoanStatus(int loanId, int loanStatusId)
        {
            var loan = await GetLoanByIdAsync(loanId);
            loan.LoanStatusId = loanStatusId;
            loan.DateUpdated = DateTime.Now;
            _context.Update(loan);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<LoanDTO>> GetLoansByBorrowerIdAsync(int borrowerId)
        {
            var loans = await _context.Loans
                .Include(l => l.Product)
                .Include(l => l.Lender)
                .Include(l => l.Application)
                .Include(l => l.LoanStatus)
                .Where(loan => loan.Application.BorrowerId == borrowerId)
                .ToListAsync();

            var Loans = loans.Select(loan => new LoanDTO
            {
                Id = loan.Id,
                RequestedAmount = loan.RequestedAmount,
                InterestRate = loan.InterestRate,
                Tenor = loan.Tenor,
                ProductName = loan.Product.Name,
                LenderName = loan.Lender.Name,
                ApplicationStatusName = loan.Application.ApplicationName,
                LoanStatusName = loan.LoanStatus.Name,
                DateCreated = loan.DateCreated,
                DateUpdated = loan.DateUpdated
            });

            return Loans;
        }
        public async Task<LoanDTO> GetLoanDeatilsByIdAsync(int loanId)
        {
            var loan = await _context.Loans
               .Include(l => l.Product)
               .Include(l => l.Lender)
               .Include(l => l.Application)
               .Include(l => l.LoanStatus).
               FirstOrDefaultAsync(l => l.Id == loanId);
            if (loan == null)
            {
                return null;

            }
            var Loan =  new LoanDTO
            {
                Id = loan.Id,
                RequestedAmount = loan.RequestedAmount,
                InterestRate = loan.InterestRate,
                Tenor = loan.Tenor,
                ProductName = loan.Product.Name,
                LenderName = loan.Lender.Name,
                ApplicationStatusName = loan.Application.ApplicationName,
                LoanStatusName = loan.LoanStatus.Name,
                DateCreated = loan.DateCreated,
                DateUpdated = loan.DateUpdated
            };

            return Loan;
        }
    }

    
}
