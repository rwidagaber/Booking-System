using BookingSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MVC.ViewModels;
using System.Runtime.Intrinsics.Arm;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;  
        private readonly SignInManager<User> _signinManager;  

        public AccountController(UserManager<User> userManager, SignInManager<User> signinManager)
        {
            _userManager = userManager;  
            _signinManager = signinManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CrtUserVM userVM)
        {
            if (ModelState.IsValid)
            {
               User newUser = new()
                {
                    UserName = userVM.UserName,
                   
                };

                IdentityResult res = await _userManager.CreateAsync(newUser, userVM.Password); 

                if (res.Succeeded)
                {
                    await _signinManager.SignInAsync(newUser, isPersistent: false);
                    return RedirectToAction("Index", "Booking");
                }
                else
                {
                    foreach (var error in res.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(userVM);
        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(LoginVM userVM)
        {
            if (ModelState.IsValid)
            {

                var res = await _signinManager.PasswordSignInAsync(userVM.Username, userVM.Password, false, true);  // hash password and save user to database

                if (res.Succeeded)
                {
                    return RedirectToAction("Index", "Booking");
                }
                else
                {

                    ModelState.AddModelError("", "Invalid name");

                }
            }
            return View(userVM);
        }

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("login");
        }

    } 
}
