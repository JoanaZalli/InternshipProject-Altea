using Application.Contracts.Repositories;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.RolePermissionModul
{
    public sealed record AssignPermissionToRoleCommand : IRequest<bool>
    {
        public string RoleId { get; set; }
        public int PermissionId { get; set; }
        public string Culture { get; set; }
    }
    public class AssignPermissionToRoleCommandHandler : IRequestHandler<AssignPermissionToRoleCommand, bool>
    {
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public AssignPermissionToRoleCommandHandler(IRolePermissionRepository rolePermissionRepository)
        {
            _rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<bool> Handle(AssignPermissionToRoleCommand request, CancellationToken cancellationToken)
        {
            var roleId = request.RoleId;
            var permissionId = request.PermissionId;

            var existingMapping = await _rolePermissionRepository.GetRolePermissionMapping(roleId, permissionId);
            if (existingMapping != null)
            {
                throw new PermissionToRoleAssignedException(request.Culture);
            }

            var rolePermission = new RolePermission
            {
                RoleId = roleId,
                PermissionId = permissionId
            };

            _rolePermissionRepository.Create(rolePermission);
            await _rolePermissionRepository.SaveChangesAsync();

            return true;
        }
    }

}
