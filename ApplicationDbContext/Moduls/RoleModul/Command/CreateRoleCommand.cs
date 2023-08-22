using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Validations;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Moduls.RoleModul.Command
{
    public sealed record CreateRoleCommand : IRequest<bool>
    {
        public string RoleName { get; set; }
        public string CultureId { get; set; }


    }
    public sealed class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, bool>
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IStringLocalizer<CreateRoleCommand> _validationLocalizationService;


        public CreateRoleCommandHandler(RoleManager<IdentityRole> roleManager, IStringLocalizer<CreateRoleCommand> validationLocalizationService)
        {
            _roleManager = roleManager;
            _validationLocalizationService = validationLocalizationService;

        }
        public async Task<bool> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleExists = await _roleManager.RoleExistsAsync(request.RoleName);
            if (roleExists)
            {
                throw new RoleExistsException(request.CultureId);
            }

            var   role= new IdentityRole { Name = request.RoleName };
            var roleValidation= new CreateRoleValidation(_validationLocalizationService, request.CultureId);
            var validationResult = await roleValidation.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new FluentValidationException(errorMessages);
            }
            var result = await _roleManager.CreateAsync(role);
            return true;
        }
    }

}
