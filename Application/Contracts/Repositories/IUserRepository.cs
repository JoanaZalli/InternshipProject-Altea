﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IUserRepository
    {
       Task <IEnumerable<User>> GetAllUsersAsync();

        Task<User> FindByEmailAsync(string email);
        Task<User> FindByUsernameAsync(string email);

        Task<User> FindByTokenAsync(string token);
        Task SaveChangesAsync();

    }
}
