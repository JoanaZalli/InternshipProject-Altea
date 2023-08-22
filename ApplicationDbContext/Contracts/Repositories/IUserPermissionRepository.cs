using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IUserPermissionRepository: IRepositoryBase<UserPermission>
    {
        Task<UserPermission> GetUserPermissionMapping(string userId, int permissionId);

    }
}
