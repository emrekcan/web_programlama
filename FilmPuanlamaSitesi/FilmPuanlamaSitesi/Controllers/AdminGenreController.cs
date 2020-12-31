using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminGenreController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Genres.ToList();
            return View(degerler);
        }

        public IActionResult Update(int id)
        {
            var up = c.Genres.Find(id);
            return View("Update", up);
        }

        public IActionResult UpdateGenre(Genre g)
        {
            var gen = c.Genres.Find(g.ID);
            gen.ID = g.ID;
            gen.Baslik = g.Baslik;
            gen.FilmLink = g.FilmLink;
            gen.FilmAd = g.FilmAd;
            gen.Kategori = g.Kategori;
            gen.Sure = g.Sure;
            gen.FilmResim = g.FilmResim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
