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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return NotFound();

            if (slider.Photo != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    string fileName = slider.Photo.FileName;
                    string filePath = Path.Combine(_env.WebRootPath, "assets", "Image", "Slider");
                    string fullPath = Path.Combine(filePath, fileName);

                    using (FileStream stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await slider.Photo.CopyToAsync(stream);
                    }

                    slider.Image = fileName;

                    _context.Sliders.Add(slider);
                    await _context.SaveChangesAsync();


                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose image file");
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id, Slider slider)
        {
            Slider existedSlider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if(slider.Photo != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    string fileName = slider.Photo.FileName;
                    string filePath = Path.Combine(_env.WebRootPath, "assets", "Image", "Slider");
                    string fullPath = Path.Combine(filePath, fileName);

                    using(FileStream stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await slider.Photo.CopyToAsync(stream);
                    }

                    string anyPath = _env.WebRootPath + @"assets\Image\Slider\" + slider.Image;

                    if (System.IO.File.Exists(anyPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }

                    existedSlider.Image = fileName;
                }            
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }

           
            
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteSlider(int id)
        {
            if (!ModelState.IsValid) return View();
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);

            _context.Sliders.Remove(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);

            return View(slider);
        }
    }
}
