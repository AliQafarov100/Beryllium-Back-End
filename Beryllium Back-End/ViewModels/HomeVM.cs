using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.Models;

namespace Beryllium_Back_End.ViewModels
{
    public class HomeVM
    {
        public List<Carousel> Carousels { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<News> News { get; set; }
        public List<Work> Works { get; set; }
    }
}
