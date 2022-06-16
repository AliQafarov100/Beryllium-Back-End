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
    public class DashBoardController : Controller
    {
        private readonly AppDbContext _context;
        public DashBoardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }
    }
}
