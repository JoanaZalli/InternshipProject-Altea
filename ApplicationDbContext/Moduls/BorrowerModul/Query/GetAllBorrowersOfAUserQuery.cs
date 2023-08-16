using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Filtring;
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
        public string? Filter { get; set; }


    }
    public class GetAllBorrowersOfAUserQueryHandler : IRequestHandler<GetAllBorrowersOfAUserQuery, IEnumerable<BorrowerDTO>>
    {
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly BaseSorter<BorrowerDTO> _borrowerSorter;



        public GetAllBorrowersOfAUserQueryHandler(IBorrowerRepository borrowerRepository, IMapper mapper, UserManager<User> userManager, 
            BaseSorter<BorrowerDTO> borrowerSorter)
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
            var borrowerDto = _mapper.Map<IEnumerable<BorrowerDTO>>(borrowers);
            if (request.Filter != null)
            {
                borrowerDto = BorrowerFiltring.ApplyFilter(borrowerDto, request.Filter);
            }
            if (!string.IsNullOrEmpty(request.SortBy) && request.SortAscending.HasValue)
            {
                borrowerDto = _borrowerSorter.Sort(borrowerDto, request.SortBy, request.SortAscending.Value);
            }

            return borrowerDto;
        }
             
    }
}
