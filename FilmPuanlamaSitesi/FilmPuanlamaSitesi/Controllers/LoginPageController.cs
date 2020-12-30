
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
    public class LoginPageController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(Kullanici k)
        {
            var bilgiler = c.Kullanicis.FirstOrDefault(x => x.Email == k.Email && x.Sifre == k.Sifre);
            
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, k.Email)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Film");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(Kullanici k)
        {
            c.Kullanicis.Add(k);
            c.SaveChanges();
            return RedirectToAction("Login");
        }

    }
}
