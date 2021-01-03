using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var aciklama = c.Abouts.ToList();
            return View(aciklama);
        }
    }
}
