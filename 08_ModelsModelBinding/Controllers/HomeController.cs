using _08_ModelsModelBinding.Models;
using _08_ModelsModelBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace _08_ModelsModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {

            Kisi kisi = new Kisi();
            kisi.Ad = "Lionel";
            kisi.Soyad = "Messi";
            kisi.Yas = 28;

            Adres adresim = new Adres();
            adresim.AdresTanim = "Caminin Yani";
            adresim.Sehir = "Ankara";

            //ctrl + "." ile menu acilip using acilir.
            HomePageViewModel mod = new HomePageViewModel();
            mod.KisiNesnesi = kisi;
            mod.AdresNesnesi = adresim;

            return View(mod);
        }

        [HttpPost]
        public ActionResult homepage(HomePageViewModel k)
        {
            
            return View(k);
        }
    }
}