using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Moduls.UserModul.Query
{
    public sealed record GetUserByTokenQuery : IRequest<UserRegistrationDTO>
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? UserName { get; init; }
        public string? Password { get; init; }
        public string? Email { get; init; }

        [JsonPropertyName("Prefix")]
        public int PrefixId { get; init; } 
        public string? PhoneNumber { get; init; }
        public string CultureId { get; init; }
        public string Token { get; set; }
        public DateTime TokenCreationTime { get; set; }
        public bool EmailConfirmed { get; init; }


    }

    internal sealed class GetUserByTokenHandler : IRequestHandler<GetUserByTokenQuery, UserRegistrationDTO>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        

        public GetUserByTokenHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserRegistrationDTO> Handle(GetUserByTokenQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindByTokenAsync(request.Token);
            if (user == null)
            {
                throw new UserNotFoundException(request.CultureId);
            }
            if (TokenGenerator.IsTokenExpired(user.TokenCreationTime))
            {
                throw new TokenExpiredException(request.CultureId);
            }
            if(user.EmailConfirmed) { 
            throw new  EmailAlreadyConfirmedExcepion(request.CultureId);
                    }
            user.EmailConfirmed = true;
            await _userRepository.SaveChangesAsync();

            var userDto=_mapper.Map<UserRegistrationDTO>(user);

            return userDto;
        }
    }

}
