using ASPNET_CORE_IlkProje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASPNET_CORE_IlkProje.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.mesaj = "Merhaba";
            Urun u = new Urun() { _adi = "deneme" };
            return View(u);
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult UrunOlustur()
        {
            var tuple = (new Kullanici(), new Urun());
            return View(tuple);
        }

        [HttpPost]
        //public IActionResult UrunOlustur(IFormCollection data)
        public IActionResult UrunOlustur([Bind(Prefix ="Item1")]Kullanici k, [Bind(Prefix = "Item2")] Urun u)
        {
           var querystring= Request.QueryString;//istek yapılan url de querystring eklenip eklenmediği bilgisini verir.
            var deger = Request.Query["sehir"].ToString();
            //var deger1 = data["txturun"].ToString();
            //var deger2 = data["txtfiyat"].ToString();
            return View();
        }

        public IActionResult VeriAl(string sehir, int id)
        {
            var deger = Request.RouteValues;
            return View();
        }

        [HttpPost]
        public IActionResult VeriAl(string sehir)
        {
            return View();
        }
    }
}
