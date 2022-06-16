using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.DAL;
using Beryllium_Back_End.Models;
using Beryllium_Back_End.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Beryllium_Back_End.Areas.BeryAdmin.Controllers
{
    [Area("BeryAdmin")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        //public async Task<IActionResult> Index(RegisterVM register)
        //{
        //    AppUser user = await _userManager.FindById(register.Username);
        //    return View(user);
        //}
    }
}
