using Application.Contracts.Repositories;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.LoanModul.Command
{
    public class CreateLoanCommand : IRequest<bool>
    {
        public int ApplicationId { get; set; }
        public string CultureId { get; set; }
    }
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, bool>
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IConditionsRepository _conditionsRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IProductRepository _productRepository;
        public readonly IMatrixCombinationRepository _matrixCombinationRepository;
        public CreateLoanCommandHandler(IApplicationRepository applicationRepository, ILenderRepository lenderRepository,
            IConditionsRepository conditionsRepository, IBorrowerRepository borrowerRepository, IProductRepository productRepository
            , IMatrixCombinationRepository matrixCombinationRepository)
        {
            _applicationRepository = applicationRepository;
            _lenderRepository = lenderRepository;
            _conditionsRepository = conditionsRepository;
            _borrowerRepository = borrowerRepository;
            _productRepository = productRepository;
            _matrixCombinationRepository = matrixCombinationRepository;
        }
        public async Task<bool> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var application = await _applicationRepository.GetApplicationByIdAsync(request.ApplicationId);
            if (application == null)
            {
                throw new ApplicationNotFoundException(request.CultureId);
            }
            var borrower= await _borrowerRepository.GetBorrowerByIdAsync(application.BorrowerId);
            //  checks if there is an eligible lender 
            var conditions = await _conditionsRepository.GetAllConditionsAsync();
            var eligibleLenders = new List<int>();
            foreach(var condition in conditions)
            {
                var lender =await _lenderRepository.GetLenderByIdAsync(condition.LenderId);
                if (borrower.CompanyTypeId == condition.CompanyTypeId && application.RequestedAmount > condition.MinRequestedAmount && application.RequestedTenor > condition.TenorMin)
                {
                    if (condition.TenorMax != null)
                    {
                        if (application.RequestedTenor > condition.TenorMin)
                        {
                            eligibleLenders.Add(lender.Id);
                        }
                       ;
                    }
                    eligibleLenders.Add(lender.Id);
                }             

            }
           if(eligibleLenders.Count == 0)
            {
                throw new NoEligibleLenderException(request.CultureId);
            }
           int lenderId=eligibleLenders.First();
           var loanTenor=application.RequestedTenor;
            var product = await _productRepository.GetProductAsync(application.ProductId);
            var referenceRate = product.Refernce_rate;
            var spread =await _matrixCombinationRepository.GetSpreadAsync(lenderId,application.ProductId,application.RequestedTenor);

            var interestRate = spread + referenceRate;

            // Create the loan entity and persist it
            // ...

            // Update application status
            // ...

            // Optionally, generate loan agreement and notify borrower
            // ...

            return true;
        }
    }
}
