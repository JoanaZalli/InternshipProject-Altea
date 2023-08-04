using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Sorting;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.BorrowerModul.Query
{
    public class GetAllBorrowersOfAUserQuery : IRequest<IEnumerable<BorrowerDTO>>
    {
        public string UserId { get; set; }
        public string Culture { get; set; }
        public string? SortBy { get; set; } 
        public bool? SortAscending { get; set; }


    }
    public class GetAllBorrowersOfAUserQueryHandler : IRequestHandler<GetAllBorrowersOfAUserQuery, IEnumerable<BorrowerDTO>>
    {
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly BaseSorter<Borrower> _borrowerSorter;



        public GetAllBorrowersOfAUserQueryHandler(IBorrowerRepository borrowerRepository, IMapper mapper, UserManager<User> userManager, 
            BaseSorter<Borrower> borrowerSorter)
        {
            _borrowerRepository = borrowerRepository;
            _mapper = mapper;
            _userManager = userManager;
            _borrowerSorter = borrowerSorter;
        }

        public async Task<IEnumerable<BorrowerDTO>> Handle(GetAllBorrowersOfAUserQuery request, CancellationToken cancellationToken)
        {
            var user= _userManager.FindByIdAsync(request.UserId);
            if(await user ==null) 
                throw new UserNotFoundException(request.Culture);
            
            var borrowers= await _borrowerRepository.GetBorrowersByUserIdAsync(request.UserId);
           
            if (!string.IsNullOrEmpty(request.SortBy) && request.SortAscending.HasValue)
            {
                borrowers = _borrowerSorter.Sort(borrowers, request.SortBy, request.SortAscending.Value);
            }

            var borrowerDto = _mapper.Map<IEnumerable<BorrowerDTO>>(borrowers);
            return borrowerDto;
        }
             
    }
}
