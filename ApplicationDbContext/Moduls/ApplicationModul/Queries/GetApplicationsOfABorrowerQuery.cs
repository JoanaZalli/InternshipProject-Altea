using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.BorrowerModul.Query;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.ApplicationModul.Queries
{
    public sealed class GetApplicationsOfABorrowerQuery : IRequest<IEnumerable<ApplicationDTO>>
    {
        public int BorrowerId { get; set; }
        public string CultureId { get; set; }
    }

    public class GetApplicationsOfABorrowerQueryHandler : IRequestHandler<GetApplicationsOfABorrowerQuery, IEnumerable<ApplicationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationRepository _applicationRepository;
        private readonly IBorrowerRepository _borrowerRepository;

        public GetApplicationsOfABorrowerQueryHandler(IMapper mapper, IApplicationRepository applicationRepository, IBorrowerRepository borrowerRepository)
        {
            _mapper = mapper;
            _applicationRepository = applicationRepository;
            _borrowerRepository = borrowerRepository;
        }
        public async Task<IEnumerable<ApplicationDTO>> Handle(GetApplicationsOfABorrowerQuery request, CancellationToken cancellationToken)
        {
            var borrower =await _borrowerRepository.GetBorrowerByIdAsync(request.BorrowerId);
            if (borrower == null)
            {
                throw new NotFoundException(request.CultureId);
            }

            var applications =await _applicationRepository.GetApplicationsOfABorrowerById(request.BorrowerId);
            var applocationForDisplay = _mapper.Map<IEnumerable<ApplicationDTO>>(applications);

            return applocationForDisplay;
                
        }

    }

}
