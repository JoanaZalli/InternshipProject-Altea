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
    public sealed record CreateRoleCommand : IRequest<bool>
    {
        public string RoleName { get; set; }
        public string CultureId { get; set; }


    }
    public sealed class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, bool>
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateRoleCommandHandler(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<bool> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleExists = await _roleManager.RoleExistsAsync(request.RoleName);
            if (roleExists)
            {
                throw new RoleExistsException(request.CultureId);
            }
            var role = new IdentityRole { Name = request.RoleName };
            var result = await _roleManager.CreateAsync(role);

            return true;
        }
    }

}
