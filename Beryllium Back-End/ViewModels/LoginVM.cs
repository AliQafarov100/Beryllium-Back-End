using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium_Back_End.ViewModels
{
    public class LoginVM
    {
        [Required,StringLength(maximumLength:15)]
        public string Username { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
