using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
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

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users=_context.Users.ToList();
            return users;
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            var user = await _context.Set<User>()
                .FirstOrDefaultAsync(u => u.Email == email);

            return user ;
        }
        public async Task<User> FindByUsernameAsync(string username)
        {
            var user = await _context.Set<User>()
                .FirstOrDefaultAsync(u => u.UserName == username);

            return user;
        }

        public async Task<User> FindByTokenAsync(string token)
        {
            var user=await _context.Set<User>().FirstOrDefaultAsync(u => u.Token == token);
            return user;
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

