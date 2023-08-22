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
    public class UpdateRoleCommand : IRequest<bool>
    {
        public string RoleId { get; set; }
        public string NewRoleName { get; set; }
        public string CultureId { get; set; }

    }
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, bool>
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public UpdateRoleCommandHandler(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<bool> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _roleManager.FindByIdAsync(request.RoleId);

            if (role != null)
            {
                role.Name = request.NewRoleName;
                var result = await _roleManager.UpdateAsync(role);

                return result.Succeeded;
            }

            throw new RoleWasNotFoundException(request.CultureId);

        }
    }
}