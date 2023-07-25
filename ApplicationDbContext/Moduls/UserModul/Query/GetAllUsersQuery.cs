using Application.Contracts.Repositories;
using Application.DTOS;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Moduls.UserModul.Query
{
    public sealed record GetAllUsersQuery(bool TrackChanges) : IRequest<IEnumerable<UserRegistrationDTO>>
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? UserName { get; init; }
        public string? Password { get; init; }
        public string? Email { get; init; }

        [JsonPropertyName("Prefix")]
        public int PrefixId { get; init; } // Added PrefixId property
        public string? PhoneNumber { get; init; }
        public string CultureId { get; init; }
        public string Token { get; set; }
        public DateTime TokenCreationTime { get; set; }
    }

    internal sealed class GetUsersHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserRegistrationDTO>>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public GetUsersHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserRegistrationDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
           var users= await _repositoryManager.User.GetAllUsersAsync(request.TrackChanges);
            var userDto=_mapper.Map<IEnumerable<UserRegistrationDTO>>(users);
            return userDto;
        }
    }
}
