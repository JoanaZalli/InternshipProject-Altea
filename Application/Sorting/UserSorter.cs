using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sorting
{
    public class UserSorter : BaseSorter<UserDto>
    {
        public override IEnumerable<UserDto> Sort(IEnumerable<UserDto> users, string? sortBy, bool? sortAscending)
        {
            if (!string.IsNullOrEmpty(sortBy) && sortAscending.HasValue)
            {
                switch (sortBy.ToLower())
                {
                    case "firstname":
                        return sortAscending.Value
                            ? users.OrderBy(u => u.FirstName)
                            : users.OrderByDescending(u => u.FirstName);
                    case "lastname":
                        return sortAscending.Value
                            ? users.OrderBy(u => u.LastName)
                            : users.OrderByDescending(u => u.LastName);
                    case "email":
                        return sortAscending.Value
                            ? users.OrderBy(u => u.Email)
                            : users.OrderByDescending(u => u.Email);
                    case "username":
                        return sortAscending.Value
                            ? users.OrderBy(u => u.UserName)
                            : users.OrderByDescending(u => u.UserName);
                    default:
                        return users;
                }
            }
            return users;
        } 
    }
}
