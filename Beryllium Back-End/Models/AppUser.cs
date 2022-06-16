using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Beryllium_Back_End.Models
{
    public class AppUser : IdentityUser
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
    }
}
