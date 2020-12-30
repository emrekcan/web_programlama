using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminLoginController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Email == a.Email && x.Sifre == a.Sifre);

            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, a.Email)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");
            }

            return View();
        }

    }
}
