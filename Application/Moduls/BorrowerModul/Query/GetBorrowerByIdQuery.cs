using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Query;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.BorrowerModul.Query
{
    public sealed record GetBorrowerByIdQuery : IRequest<BorrowerDTO>
    {
        public int BorrowerId { get; set; }
        public string Culture { get; set; }
    }

    public sealed class GetBorrowerByIdQueryHandler : IRequestHandler<GetBorrowerByIdQuery,BorrowerDTO>
    {
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        public GetBorrowerByIdQueryHandler(IBorrowerRepository borrowerRepository, IMapper mapper)
        {
            _borrowerRepository=borrowerRepository;
            _mapper=mapper;
        }
        public async Task<BorrowerDTO> Handle(GetBorrowerByIdQuery request, CancellationToken cancellationToken)
        {
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(request.BorrowerId);
            if(borrower == null)
            {
                throw new BorrowerNotFoundException(request.Culture);
            }
            var borrowerDto=_mapper.Map<BorrowerDTO>(borrower);
            return borrowerDto;
        }
    }
}
