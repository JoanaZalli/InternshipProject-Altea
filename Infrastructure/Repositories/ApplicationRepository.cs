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
    public class ApplicationRepository :RepositoryBase<Applicationn>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context) { }
        public Applicationn CreateApplication(Applicationn application)
        {
           application.DateCreated = DateTime.Now;
            application.DateUpdated = DateTime.Now;
            application.IsApproved = false;
            application.ApplicationName = (application.DateCreated).ToString() + (application.RequestedAmount).ToString();
            application.ApplicationStatusId = 1;
            _context.Add(application);
            _context.SaveChanges();
            return application;
        }

        public async Task<Applicationn> GetApplicationByIdAsync(int id)
        {
            var application =  await _context.Applications.FirstOrDefaultAsync(x => x.Id == id);
            return application;
        }

        public async Task<bool> ChangeProductAsync(Applicationn applicationn, int productId)
        {
            try
            {
                applicationn.ProductId = productId;
              await  _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<IEnumerable<Applicationn>> GetApplicationsOfABorrowerById(int borrowerId)
        {
           var applications= await _context.Applications.Include(a=>a.Product).Include(a=>a.ApplicationStatus).Where(a=>a.BorrowerId==borrowerId).Select(a=>new Applicationn
           {
               ApplicationName= a.ApplicationName,
               RequestedAmount= a.RequestedAmount,
               RequestedTenor= a.RequestedTenor,
               Product= a.Product,
               IsApproved= a.IsApproved,
               ApplicationStatus= a.ApplicationStatus,
               FinancingPurposeDescription= a.FinancingPurposeDescription,
               DateCreated= a.DateCreated,
               DateUpdated= a.DateUpdated
           }).ToListAsync();
            return applications;
        }

        public async Task<bool> UpdateApplicationStatus(int loanStatusId , int applicationId)
        {
            var application = await GetApplicationByIdAsync(applicationId);
            var newApplicationStatusId = GetNewApplicationStatusId(loanStatusId);

            if (application.ApplicationStatusId != newApplicationStatusId)
            {
                application.ApplicationStatusId = newApplicationStatusId;
                _context.Update(application);
                await _context.SaveChangesAsync();
            }

            return true;
        }

        private int GetNewApplicationStatusId(int loanStatusId)
        {
            switch (loanStatusId)
            {
                case 1: return 2;  // Loan Issued
                case 10: return 3; // Loan Canceled
                case 7: return 4;  // Loan Defaulted
                case 4: return 5;  // Loan Disbursed
                case 9: return 6;  // Loan Guaranteed
                case 3: return 7;  // Loan Rejected
                case 8: return 8;  // Loan Repaid
                default: return 1; // In Charge
            }
        }

    }
}
