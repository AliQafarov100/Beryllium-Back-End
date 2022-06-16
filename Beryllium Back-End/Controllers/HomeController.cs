using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.DAL;
using Beryllium_Back_End.Models;
using Beryllium_Back_End.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beryllium_Back_End.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Carousel> carousels = await _context.Carousels.ToListAsync();
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<News> news = await _context.News.ToListAsync();
            List<Work> works = await _context.Works.ToListAsync();

            HomeVM model = new HomeVM
            {
                Carousels = carousels,
                Sliders = sliders,
                News = news,
                Works = works
            };

            return View(model);
        }
    }
}
