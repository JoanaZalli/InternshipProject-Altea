using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IUserRepository
    {
       Task <IEnumerable<User>> GetAllUsersAsync(bool trackChanges);

        Task<bool> FindByEmailAsync(string email);
        Task<bool> FindByUsernameAsync(string email);

        Task<User> FindByTokenAsync(string token);
        Task SaveChangesAsync();

    }
}
