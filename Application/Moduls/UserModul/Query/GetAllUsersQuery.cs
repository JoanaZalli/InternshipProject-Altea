using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Filtring;
using Application.Sorting;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Moduls.UserModul.Query
{
    public sealed record GetAllUsersQuery() : IRequest<IEnumerable<UserDto>>
    {
        
        public string CultureId { get; init; }
        public string? SortBy { get; set; }
        public bool? SortAscending { get; set; }
        public string? Filter { get; set; }

    }

    public sealed class GetUsersHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly BaseSorter<UserDto> _userSorter;

        public GetUsersHandler(IRepositoryManager repositoryManager, IMapper mapper, BaseSorter<UserDto> userSorter)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userSorter = userSorter;
        }

        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
           var users= await _repositoryManager.User.GetAllUsersAsync();
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            
            if (request.Filter != null)
            {
                userDto = UserFiltring.ApplyFilter(userDto, request.Filter);
            }
            if (!string.IsNullOrEmpty(request.SortBy) && request.SortAscending.HasValue)
            {
                userDto = _userSorter.Sort(userDto, request.SortBy, request.SortAscending.Value);
            }
           
            return userDto;
        }
    }
}
