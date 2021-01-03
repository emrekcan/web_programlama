using FilmPuanlamaSitesi.Models.Siniflar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Controllers
{
    public class KullaniciController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Kullanicis.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(Kullanici k)
        {
            if (!ModelState.IsValid)
            {
                return View("AddUser");
            }
            c.Kullanicis.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var b = c.Kullanicis.Find(id);
            c.Kullanicis.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var up = c.Kullanicis.Find(id);
            return View("Update", up);
        }

        public IActionResult UpdateUser(Kullanici k)
        {

            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            var upd = c.Kullanicis.Find(k.ID);
            upd.ID = k.ID;
            upd.KullaniciAd = k.KullaniciAd;
            upd.Email = k.Email;
            upd.Sifre = k.Sifre;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
