using Mvc5EgitimDersler.Models;
using Mvc5EgitimDersler.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5EgitimDersler.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()//Listele isminde bir sayfa oluşturacağız ve bu sayfada öğrenci listesini göstereceğiz
        {
            return View(OgrenciVeri.Ogrenciler);//view in parantezinin içinde parametre olarak ogrenciveri altındaki ogrenciler isimli veri listesini listele sayfasına sayfa modeli olarak gönderiyoruz
        }

        public ActionResult Yeni()//Yeni öğrenci kaydı yapacağımız sayfa metodu
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Ogrenci ogrenci)//Yeni öğrenci kaydı yapacağımız sayfa metodu
        {
            OgrenciVeri.Ogrenciler.Add(ogrenci);
            return RedirectToAction("Listele");//Kaydı ekledikten sonra listele action una git
        }

    }
}