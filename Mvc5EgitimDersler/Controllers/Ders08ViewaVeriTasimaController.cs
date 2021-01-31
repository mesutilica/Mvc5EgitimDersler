using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5EgitimDersler.Controllers
{
    public class Ders08ViewaVeriTasimaController : Controller
    {
        // GET: Ders08ViewaVeriTasima
        public ActionResult Index()
        {
            ViewBag.KategoriAdi = "Dizüstü Bilgisayarlar";//Burada ViewBag.KategoriAdi şeklinde oluşturduğumuz ViewBag nesnesini sayfa ön yüzümüz olan View de @ViewBag.KategoriAdi şeklinde çağırarak kullanabiliriz
            ViewData["UrunAdi"] = "Monster Notebook";//Burada ViewData["UrunAdi"] şeklinde oluşturduğumuz ViewData nesnesini sayfa ön yüzümüz olan View de @ViewData["UrunAdi"] şeklinde çağırarak kullanabiliriz
            TempData["UrunFiyati"] = "14530";//Burada TempData["UrunFiyati"] şeklinde oluşturduğumuz TempData nesnesini sayfa ön yüzümüz olan View de @TempData["UrunFiyati"] şeklinde çağırarak kullanabiliriz
            ViewBag.UrunResmi = "Manzara.JPG";
            return View();
        }
    }
}