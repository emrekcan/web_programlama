using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminContactUsController : Controller
    {
        Context d = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = d.ContactUses.ToList();
            return View(degerler);
        }

        public IActionResult Update(int id)
        {
            var up = d.ContactUses.Find(id);
            return View("Update", up);
        }

        public IActionResult UpdateContactUs(ContactUs c)
        {
            var con = d.ContactUses.Find(c.ID);
            con.ID = c.ID;
            con.Baslik = c.Baslik;
            con.Mail = c.Mail;
            con.Telefon = c.Telefon;
            con.Adres = c.Adres;
            d.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
