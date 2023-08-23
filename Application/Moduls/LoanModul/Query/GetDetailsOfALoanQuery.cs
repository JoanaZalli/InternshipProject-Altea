using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.LoanModul.Query
{
    public class GetDetailsOfALoanQuery : IRequest<LoanDTO>
    {
        public int LoanId { get; set; }
        public string CultureId { get; set; }
    }
    public class GetDetailsOfALoanQueryHandler : IRequestHandler<GetDetailsOfALoanQuery, LoanDTO>
    {
        private readonly ILoanRepository _loanRepository;
        public GetDetailsOfALoanQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public async Task<LoanDTO> Handle(GetDetailsOfALoanQuery request, CancellationToken cancellationToken)
        {
           var loan=await _loanRepository.GetLoanDeatilsByIdAsync(request.LoanId);
            if (loan == null)
            {
                throw new LoanNotFoundException(request.CultureId);
            }

            return loan;
        }
    }
}