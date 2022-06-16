using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.DAL;
using Beryllium_Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beryllium_Back_End.Areas.BeryAdmin.Controllers
{
    [Area("BeryAdmin")]
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;
        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<News> news = await _context.News.ToListAsync();
            return View(news);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid) return NotFound();

            _context.News.Add(news);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            News news = await _context.News.FirstOrDefaultAsync(n => n.Id == id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id,News news)
        {
            if (!ModelState.IsValid) return View();
            News existedNews = await _context.News.FirstOrDefaultAsync(n => n.Id == id);

            if(news.Id != id)
            {
                return BadRequest();
            }

            existedNews.TitleNews = news.TitleNews;
            existedNews.DescriptionNews = news.DescriptionNews;
            existedNews.Date = news.Date;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            News news = await _context.News.FirstOrDefaultAsync(n => n.Id == id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteNews(int id)
        {
            if (!ModelState.IsValid) return NotFound();
            News news = await _context.News.FirstOrDefaultAsync(n => n.Id == id);

            _context.News.Remove(news);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            News news = await _context.News.FirstOrDefaultAsync(n => n.Id == id);

            return View(news);
        }
    }
}
