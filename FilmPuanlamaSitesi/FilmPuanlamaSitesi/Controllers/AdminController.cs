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
            var degerler = c.Kullanicis.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Kullanici k)
        {
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
            var upd = c.Kullanicis.Find(k.ID);
            upd.ID = k.ID;
            upd.KullaniciAd = k.KullaniciAd;
            upd.Email = k.Email;
            upd.Sifre = k.Sifre;
            upd.Yetki = k.Yetki;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
