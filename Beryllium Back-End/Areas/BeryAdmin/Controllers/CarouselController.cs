using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.DAL;
using Beryllium_Back_End.Extensions;
using Beryllium_Back_End.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beryllium_Back_End.Areas.BeryAdmin.Controllers
{
    [Area("BeryAdmin")]
    public class CarouselController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CarouselController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Carousel> carousels = await _context.Carousels.ToListAsync();

            return View(carousels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Carousel carousel)
        {
            if (!ModelState.IsValid) return NotFound();

            if(carousel.Photo != null)
            {
                if (carousel.Photo.IsOkay(1))
                {
                    string fileName = carousel.Photo.FileName;
                    string filePath = Path.Combine(_env.WebRootPath, "assets", "Image", "Carousel");
                    string fullPath = Path.Combine(filePath, fileName);

                    using(FileStream stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await carousel.Photo.CopyToAsync(stream);
                    }

                    carousel.Image = fileName;
                    _context.Carousels.Add(carousel);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("Photo", "Choosen file size of more than 1Mb or choosen another file format");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file!");
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Carousel carousel = await _context.Carousels.FirstOrDefaultAsync(c => c.Id == id);
            if (carousel == null) return NotFound();

            return View(carousel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id,Carousel carousel)
        {
            Carousel existedCarousel = await _context.Carousels.FirstOrDefaultAsync(c => c.Id == id);

            if(carousel.Photo != null)
            {
                if (carousel.Photo.IsOkay(1))
                {
                    string fileName = carousel.Photo.FileName;
                    string filePath = Path.Combine(_env.WebRootPath, "assets", "Image", "Slider");
                    string fullPath = Path.Combine(filePath, fileName);

                    using(FileStream stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await carousel.Photo.CopyToAsync(stream);
                    }

                    existedCarousel.Image = fileName;
                }
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose image file");
                return View();
            }

            existedCarousel.Lacation = carousel.Lacation;
            existedCarousel.Town = carousel.Town;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Carousel carousel = await _context.Carousels.FirstOrDefaultAsync(c => c.Id == id);

            if (carousel == null) return NotFound();

            return View(carousel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteCarousel(int id)
        {
            if (!ModelState.IsValid) return View();
            Carousel carousel = await _context.Carousels.FirstOrDefaultAsync(c => c.Id == id);

            _context.Carousels.Remove(carousel);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            if (!ModelState.IsValid) return View();
            Carousel carousel = await _context.Carousels.FirstOrDefaultAsync(c => c.Id == id);

            return View();
        }
    }
}
