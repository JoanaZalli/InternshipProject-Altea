using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PrefixId { get; set; }
        public virtual Prefix Prefix { get; set; }     
        public string Token { get; set; }
        public DateTime TokenCreationTime { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? AccesToken { get;set; }
        public DateTime? AccesTokenExpiryTime { get; set;}
        public string? PasswordRecoveyToken { get; set; }
        public DateTime? PasswordRecoveyTokenCreationTime { get; set; }


    }
}
