using ASPNET_CORE_IlkProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASPNET_CORE_IlkProje.Controllers
{
    //[NonController] //Controller erişilmesini istemediğimizde kullanıyoruz.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Urun u = new Urun() { _adi = "TV", _fiyat = 12000 };
            Kullanici k = new Kullanici() { Ad = "Hatice", Soyad = "Deniz" };

            ViewModel vm = new ViewModel()
            { kullanici = k,
              urun = u
            };
            //Veri Taşıma

            ViewBag.urun = u;
            ViewData["urun"] = u;

            string data = JsonSerializer.Serialize(u);
            TempData["urun"] = data;

            var tuple = (k, u);
            ViewResult result = View(tuple);
            return result;
           // return RedirectToAction("VeriGetir");
        }

        public IActionResult VeriGetir()
        {
            var v1=ViewBag.urun;
            var v2 = ViewData["urun"];
            var v3 = TempData["urun"].ToString();
            JsonSerializer.Deserialize<Urun>(v3);
            return View();
        }
        public PartialViewResult Index2()
        {
            PartialViewResult result = PartialView();

            return result;
        }

        public JsonResult Index3()
        {
            JsonResult result = Json(new Urun
            {
                _adi="bilgisayar", _fiyat=15000
            });
            return result;
        }

        public EmptyResult Index4()
        {
            return new EmptyResult();
        }

        [NonAction] //Metot olarak kullanacaksam dışarıdan erişilmesini engelleriz.
        public string Index5()
        {
            return "deneme";
        }

        public ContentResult Index6()
        {
            ContentResult result = Content("Deneme");
            return result;
        }

        public ActionResult Index7()
        {
            ViewResult result = View();

            return result;
        }



    }
}
