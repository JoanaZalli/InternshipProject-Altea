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
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(ApplicationDbContext context) : base(context) {}
        public Permission Create(Permission permission)
        {
             _context.Set<Permission>().Add(permission);
            return permission;
        }
        public async Task UpdateAsync(Permission permission)
        {
            _context.Set<Permission>().Update(permission);
        }

        public async Task DeleteAsync(int permissionId)
        {
            var permission = await GetByIdAsync(permissionId);
            if (permission != null)
                _context.Set<Permission>().Remove(permission);
        }
        public async Task<Permission> GetByIdAsync(int permissionId)
        {
            return await _context.Set<Permission>().FindAsync(permissionId);
        }
        public async Task<IEnumerable<Permission>> GetAllAsync()
        {
            return await _context.Set<Permission>().ToListAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
