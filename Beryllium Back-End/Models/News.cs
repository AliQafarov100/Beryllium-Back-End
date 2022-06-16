using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium_Back_End.Models
{
    public class News
    {
        public int Id { get; set; }
        public string TitleNews { get; set; }
        public string DescriptionNews { get; set; }
        public string Date { get; set; }
    }
}
