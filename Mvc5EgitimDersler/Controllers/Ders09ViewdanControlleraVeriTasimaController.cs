using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5EgitimDersler.Controllers
{
    public class Ders09ViewdanControlleraVeriTasimaController : Controller
    {
        // GET: Ders09ViewdanControlleraVeriTasima index isimli sayfa çalıştırıldığında get metodu devreye girer
        public ActionResult Index()//Controller oluşturduğumuzda vistdyo 1 tane actionresult oluşturuyor
        {
            return View();//bu metot geriye Index ismindeki view ı döndürür. Yalnız controller ı ilk oluşturduğumuzda view oluşmaz o yüzden ındex e sağ tıklayıp go to view dediğimizde hata çıkar. Bu hatayı gidermek için ındexe sağ tıklayıp add view diyerek bir view oluşturmamız lazım
        }
        [HttpPost]//Bir metodu post metodu yapmak için metodun başına buradaki httppost tanımlamasını yapmalıyız
        public ActionResult Index(string text1, bool check1, string list1)//Post işlemleri ile index sayfasından gönderilen verileri yakalayacağımız metot
        {
            //Mvc de sayfa ön yüzünden gelen datayı request.form yapısıyla elde edebiliriz
            var t1 = Request.Form["text1"];
            var l1 = Request.Form["list1"];
            var c1 = Request.Form.GetValues("check1")[0];

            //Bir diğer yöntem ise sayfa ön yüzündeki html elemanlarının name bilgileri ile aynı veri tipinde parametreler oluşturup gönderilen veriyi yakalayabiliriz

            //Aşağıdaki tempdata nesneleri yardımıyla ön yüzden gönderilen verileri tekrar sayfaya gönderebiliriz

            TempData["text1Veri"] = t1;//text1;//text1 den gelen değeri ön yüze gönder
            TempData["list1Veri"] = l1;//list1;//list1 den gelen değeri ön yüze gönder
            TempData["check1Veri"] = c1;//check1;//check1 den gelen değeri ön yüze gönder

            return View();
        }
    }
}