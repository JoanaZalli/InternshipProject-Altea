using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.BorrowerModul.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.LoanModul.Command
{
    public class EditLoanStatusCommand : IRequest<bool>
    {
        public string CultureId { get; set; }
        public int LoanId { get; set; }
        public int LoanStatusId { get; set; }
    }

    public sealed class EditLoanStatusCommandHandler : IRequestHandler<EditLoanStatusCommand, bool>
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IApplicationRepository _applicationRepository;
        public EditLoanStatusCommandHandler(ILoanRepository loanRepository,IApplicationRepository applicationRepository)
        {
            _loanRepository = loanRepository;
            _applicationRepository = applicationRepository;
        }

        public async Task<bool> Handle(EditLoanStatusCommand request, CancellationToken cancellationToken)
        {
            var loan= await _loanRepository.GetLoanByIdAsync(request.LoanId);
            if (loan == null)
            {
                throw new LoanNotFoundException(request.CultureId);
            }
            var result = await _loanRepository.UpdateLoanStatus(request.LoanId, request.LoanStatusId);
             
            if (result==true)
            {
                var application =await _applicationRepository.GetApplicationByIdAsync(loan.ApplicationId);
                await _applicationRepository.UpdateApplicationStatus(loan.LoanStatusId, application.Id);
            }
            return result;
        }

    }

}
