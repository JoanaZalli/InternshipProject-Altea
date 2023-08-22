using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface ILoanRepository
    {
        Loan CreateLoan(Loan loan);
        Task<Loan> GetLoanByIdAsync(int loanId);
        Task<bool> UpdateLoanStatus(int loanId, int loanStatusId);
        Task<IEnumerable<LoanDTO>> GetLoansByBorrowerIdAsync(int borrowerId);
        Task<LoanDTO> GetLoanDeatilsByIdAsync(int loanId);


    }
}
