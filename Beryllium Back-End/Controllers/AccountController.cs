using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.Models;
using Beryllium_Back_End.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Beryllium_Back_End.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signIn;

        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signIn)
        {
            _userManager = userManager;
            _signIn = signIn;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Register(RegisterVM register)
        {
            AppUser user = new AppUser
            {
                FirtsName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.Username
            };

            if(register.Term == true)
            {
                IdentityResult result = await _userManager.CreateAsync(user, register.Password);

                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Incredible registration without our conditiions!");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _userManager.FindByNameAsync(login.Username);

            Microsoft.AspNetCore.Identity.SignInResult sigInResult =  await _signIn.PasswordSignInAsync(user,login.Password,false,false);
            if (!sigInResult.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
