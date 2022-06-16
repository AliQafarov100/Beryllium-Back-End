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
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Work> works = await _context.Works.ToListAsync();
            return View(works);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Work work)
        {
            if (!ModelState.IsValid) return NotFound();

            _context.Works.Add(work);
            await _context.SaveChangesAsync();

            return RedirectToAction();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Work work = await _context.Works.FirstOrDefaultAsync(w => w.Id == id);

            if (work == null) return NotFound();

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id,Work work)
        {
            if (!ModelState.IsValid) return NotFound();
            Work existedWork = await _context.Works.FirstOrDefaultAsync(w => w.Id == id);

            if (existedWork == null) return View();

            existedWork.WorkName = work.WorkName;
            existedWork.WorkDescription = work.WorkDescription;
            existedWork.WorkIcon = work.WorkIcon;

            if(id != work.Id)
            {
                return BadRequest();
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Work work = await _context.Works.FirstOrDefaultAsync(w => w.Id == id);
            if (work == null) return NotFound();

            return View(work);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteWork(int id)
        {
            if (!ModelState.IsValid) return View();
            Work work = await _context.Works.FirstOrDefaultAsync(w => w.Id == id);

            if (work == null) return NotFound();

            _context.Works.Remove(work);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            if (!ModelState.IsValid) return NotFound();

            Work work = await _context.Works.FirstOrDefaultAsync(w => w.Id == id);

            return View(work);
        }
    }
}
