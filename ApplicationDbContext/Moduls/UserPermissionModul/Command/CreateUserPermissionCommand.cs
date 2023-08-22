using Application.Contracts.Repositories;
using Application.Exceptions;
using Application.Moduls.RolePermissionModul;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.UserPermissionModul.Command
{
    public sealed record CreateUserPermissionCommand : IRequest<bool>
    {
        public string UserId { get; set; }
        public int PermissionId { get; set; }
        public string Culture { get; set; }
    }
    public class CreateUserPermissionCommandHandler : IRequestHandler<CreateUserPermissionCommand, bool>
    {
        private readonly IUserPermissionRepository _userPermissionRepository;

        public CreateUserPermissionCommandHandler(IUserPermissionRepository userPermissionRepository)
        {
            _userPermissionRepository = userPermissionRepository;
        }

        public async Task<bool> Handle(CreateUserPermissionCommand request, CancellationToken cancellationToken)
        {
            var userId = request.UserId;
            var permissionId = request.PermissionId;

          //  var existingMapping = await _userPermissionRepository.GetUserPermissionMapping(userId, permissionId);
         

            var userPermission = new UserPermission
            {
                UserId = userId,
                PermissionId = permissionId
            };

            _userPermissionRepository.Create(userPermission);
            await _userPermissionRepository.SaveChangesAsync();

            return true;
        }
    }


}
