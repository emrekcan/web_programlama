using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Controllers
{
    public class GenreController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var film = c.Genres.ToList();
            return View(film);
        }

    }
}
