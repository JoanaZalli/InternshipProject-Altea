using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IPermissionRepository
    {
        Permission Create(Permission permission);
        Task UpdateAsync(Permission permission);
        Task DeleteAsync(int permissionId);
        Task<IEnumerable<Permission>> GetAllAsync();
        Task<Permission> GetByIdAsync(int permissionId);
        Task SaveChangesAsync();

    }
}
