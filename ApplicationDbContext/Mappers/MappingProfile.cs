using Application.DTOS;
using Application.Moduls.ApplicationModul.Commands;
using Application.Moduls.BorrowerModul.Command;
using Application.Moduls.PermissionModul.Command;
using Application.Moduls.RoleModul.Command;
using Application.Moduls.UserModul.Commands;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
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
            CreateMap<ForgotPasswordDto, ForgotPasswordCommand>().ReverseMap();
            CreateMap<BorrowerDTO,Borrower>().ReverseMap();
            CreateMap<BorrowerDTO, CreateBorrowerCommand>().ReverseMap();
            CreateMap<Borrower, CreateBorrowerCommand>().ReverseMap();
            CreateMap<Permission, CreatePermissionCommand>().ReverseMap();
            CreateMap<IdentityRole,CreateRoleCommand>().ReverseMap();
            CreateMap<CreateApplicationCommand, Applicationn>().ReverseMap();
            CreateMap<ApplicationDTO,Applicationn>().ReverseMap();

        }
    }
}