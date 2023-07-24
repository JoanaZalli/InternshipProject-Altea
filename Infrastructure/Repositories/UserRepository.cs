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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trcakChanges)=>await GetAll(trcakChanges).ToListAsync();

        public async Task<bool> FindByEmailAsync(string email)
        {
            var user = await _context.Set<User>()
                .FirstOrDefaultAsync(u => u.Email == email);

            return user != null;
        }
        public async Task<bool> FindByUsernameAsync(string username)
        {
            var user = await _context.Set<User>()
                .FirstOrDefaultAsync(u => u.UserName == username);

            return user != null;
        }
    }
}

