using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Filtring
{
    public static class UserFiltring
    {
        public static IEnumerable<UserDto> ApplyFilter(IEnumerable<UserDto> users, string? filterValue)
        {
            if (!string.IsNullOrEmpty(filterValue))
            {
                users = users.Where(u =>
                    u.FirstName.Contains(filterValue, StringComparison.OrdinalIgnoreCase) ||
                    u.LastName.Contains(filterValue, StringComparison.OrdinalIgnoreCase) ||
                    u.UserName.Contains(filterValue, StringComparison.OrdinalIgnoreCase) ||
                    u.Email.Contains(filterValue, StringComparison.OrdinalIgnoreCase)
                );
            }

            return users;
        }
    }
}