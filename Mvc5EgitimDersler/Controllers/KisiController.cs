using Mvc5EgitimDersler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5EgitimDersler.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Kisi yeniKisi)
        {
            bool modeldekiDegerlerDogruMu = ModelState.IsValid;//Modelstate isvalid özelliği sayfadan gönderilen verilerin geçerli olup olmadığını kontrol eder
            TempData["ModelDurum"] = modeldekiDegerlerDogruMu;
            yeniKisi.Ad += modeldekiDegerlerDogruMu;

            if (ModelState.IsValid)//Eğer Sayfa ön yüzünden gelen veriler geçerliyse
            {
                Response.Write("Sayfa içerikleri geçerli");//Ekrana çıktı yaz
                //Veriler doğru ise bu kısımda verileri veritabaınına yollarız ve sayfayı liste sayfasına yönlendiririz
            }
            //Eğer ön yüzden gelen veriler geçersizse kayıt yukardaki if şartına uymadığı için kod buradan devam eder ve 
            return View(yeniKisi);//modelden gelen yeniKisi nesnesi yeni sayfasına tekrar yollanır ve ekranda hata mesajlarının gösterilmesi sağlanır
        }
    }
}