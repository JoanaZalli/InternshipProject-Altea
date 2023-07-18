using Application.DTOS;
using Application.Moduls.UserModul.Commands;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<UserRegistrationDTO, User>().ReverseMap();

            CreateMap<UserRegistrationDTO, CreateUserCommand>().ReverseMap();
        }
    }
}