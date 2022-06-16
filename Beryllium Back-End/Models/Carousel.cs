using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Beryllium_Back_End.Models
{
    public class Carousel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Lacation { get; set; }
        public string Town { get; set; }

        [NotMapped]

        public IFormFile Photo { get; set; }
    }
}
