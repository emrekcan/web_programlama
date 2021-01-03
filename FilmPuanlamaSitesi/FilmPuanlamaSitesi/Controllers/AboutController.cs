using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmPuanlamaSitesi.Models.Siniflar;
namespace FilmPuanlamaSitesi.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var aciklama = c.Abouts.ToList();
            return View(aciklama);
        }
    }
}
