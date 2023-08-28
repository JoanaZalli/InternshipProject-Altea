using Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.RoleModul.Command
{
    public class DeleteRoleCommand : IRequest<bool>
    {
        public string RoleId { get; set; }
        public string CultureId { get; set; }
    }
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, bool>
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public DeleteRoleCommandHandler(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<bool> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _roleManager.FindByIdAsync(request.RoleId);

            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
                return true;
            }

            throw new RoleWasNotFoundException(request.CultureId);
        }
    }
}