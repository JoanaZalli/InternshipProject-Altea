using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class UserDTO
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        [Required(ErrorMessage = "Username is required")]
        [Display(Name ="Email")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
       [StringLength(14),MinLength(8)]
        public string? Password { get; init; }
        [EmailAddress]
        public string? Email { get; init; }
        [MinLength(8)]
        public string? PhoneNumber { get; init; }
        public ICollection<string>? Roles { get; init; }

    }
}
