using Application.Contracts.Repositories;
using Application.Exceptions;
using Application.Moduls.RoleModul.Command;
using Application.Validations;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Moduls.PermissionModul.Command
{
    public sealed record CreatePermissionCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultureId { get; set; }
    }

    public class CreatePermissionCommandHandler : IRequestHandler<CreatePermissionCommand, bool>
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IStringLocalizer<CreatePermissionCommand> _validationLocalizationService;

        public CreatePermissionCommandHandler(IPermissionRepository permissionRepository, IStringLocalizer<CreatePermissionCommand> validationLocalizationService)
        {
            _permissionRepository = permissionRepository;
            _validationLocalizationService = validationLocalizationService;
        }

        public async Task<bool> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = new Permission
            {
                Name = request.Name,
                Description = request.Description
            };
            var validator = new CreatePermissionValidation(_validationLocalizationService, request.CultureId);
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => _validationLocalizationService[error.ErrorMessage, request.CultureId]).ToList();
                throw new FluentValidationException(errorMessages);
            }

            

            var result =  _permissionRepository.Create(permission);
            await _permissionRepository.SaveChangesAsync();

            return true;
        }
    }
}
