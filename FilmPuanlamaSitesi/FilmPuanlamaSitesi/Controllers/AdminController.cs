using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Authorization;

namespace FilmPuanlamaSitesi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin a)
        {
            if (!ModelState.IsValid)
            {
                return View("AddAdmin");
            }
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var b = c.Admins.Find(id);
            c.Admins.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var up = c.Admins.Find(id);
            return View("Update", up);
        }

        public IActionResult UpdateAdmin(Admin a)
        {

            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            var upd = c.Admins.Find(a.ID);
            upd.ID = a.ID;
            upd.KullaniciAd = a.KullaniciAd;
            upd.Email = a.Email;
            upd.Sifre = a.Sifre;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
