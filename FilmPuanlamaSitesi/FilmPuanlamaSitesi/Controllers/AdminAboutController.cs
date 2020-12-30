
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmPuanlamaSitesi.Models.Siniflar;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminAboutController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Abouts.ToList();
            return View(degerler);
        }

        public IActionResult Update(int id)
        {
            var up = c.Abouts.Find(id);
            return View("Update", up);
        }

        public IActionResult UpdateAbout(About a)
        {
            var abo = c.Abouts.Find(a.ID);
            abo.ID = a.ID;
            abo.Baslik = a.Baslik;
            abo.FotoUrl = a.FotoUrl;
            abo.Aciklama = a.Aciklama;
            abo.Istatistik = a.Istatistik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
