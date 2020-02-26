using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code_360.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Code_360.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationViewModel registrationViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = registrationViewModel.Email, Email = registrationViewModel.Email };
                var result = await userManager.CreateAsync(user, registrationViewModel.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
            }
            return View(registrationViewModel);
        }

        [HttpGet]
        public IActionResult Login()

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, 
                                                                     loginViewModel.Remember_Me, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
            }
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}
