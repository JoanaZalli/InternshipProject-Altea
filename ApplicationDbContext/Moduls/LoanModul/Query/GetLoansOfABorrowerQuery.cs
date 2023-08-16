using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.LoanModul.Query
{
    public class GetLoansOfABorrowerQuery : IRequest<IEnumerable<LoanDTO>>
    {
        public int BorrowerId { get; set; }
        public string CultureId { get; set; }
    }
    public class GetLoansOfABorrowerQueryHandler : IRequestHandler<GetLoansOfABorrowerQuery, IEnumerable<LoanDTO>>
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBorrowerRepository _borrowerRepository;

        public GetLoansOfABorrowerQueryHandler(ILoanRepository loanRepository, IBorrowerRepository borrowerRepository)
        {
            _loanRepository = loanRepository;
            _borrowerRepository = borrowerRepository;
        }

        public async Task<IEnumerable<LoanDTO>> Handle(GetLoansOfABorrowerQuery request, CancellationToken cancellationToken)
        {
            var borrower=await _borrowerRepository.GetBorrowerByIdAsync(request.BorrowerId);
            if(borrower == null)
            {
                throw new BorrowerNotFoundException(request.CultureId);
            }
            var loans = await _loanRepository.GetLoansByBorrowerIdAsync(request.BorrowerId);

            return loans;
        }
    }
}
