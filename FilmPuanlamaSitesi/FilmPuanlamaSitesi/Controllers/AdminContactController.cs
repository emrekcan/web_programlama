using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminContactController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Contacts.ToList();
            return View(degerler);
        }

        public IActionResult DeleteContact(int id)
        {
            var b = c.Contacts.Find(id);
            c.Contacts.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
