using Application.Contracts.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserPermissionRepository : RepositoryBase<UserPermission>, IUserPermissionRepository
    {
        public UserPermissionRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<UserPermission> GetUserPermissionMapping(string userId, int permissionId)
        {
            return await _context.UserPermissions
                .FirstOrDefaultAsync(up => up.UserId == userId && up.PermissionId == permissionId);
        }
    }
}
