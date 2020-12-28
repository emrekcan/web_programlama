using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmPuanlamaSitesi.Models.Siniflar;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Kullanicis.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Kullanici k)
        {
            c.Kullanicis.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
