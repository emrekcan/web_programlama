using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FilmPuanlamaSitesi.Controllers
{
    public class FilmController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        [HttpGet]
        [Authorize]
        public IActionResult Contact()
        {
            var degerler = c.ContactUses.ToList();
            return View(degerler);
        }

        [HttpPost]
        public IActionResult Contact(Contact t)
        {
                c.Contacts.Add(t);
                c.SaveChanges();
                return RedirectToAction("Contact");
        }

        [Authorize]
        public IActionResult TRIndex()
        {
            return View();
        }
    }
}
