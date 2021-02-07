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
            OgrenciVeri.Ogrenciler.Add(ogrenci);//Sayfa ön yüzünden gönderilen içi öğrenci bilgileri ile dolu parametreden gelen ogrenci isimli nesneyi OgrenciVeri.Ogrenciler.add diyerek ogrenci veri class ındaki ogrenciler adlı static listeye ekledik
            return RedirectToAction("Listele");//Kaydı ekledikten sonra listele action una git
        }

        public ActionResult Duzenle(int id)//öğrenci düzenle sayfası çalıştırıldığında çalışan metodumuz
        {
            var ogrenci = OgrenciVeri.Ogrenciler.Where(o => o.Id == id).FirstOrDefault();//Düzenlemek istediğimiz kaydı OgrenciVeri sınıfındaki Ogrenciler isimli listeye where sorgusunda int id parametresinden gelen değeri göndererek sorguluyoruz
            return View(ogrenci);//Sorgumuzun sonucunda bulunan ogrenci kaydını sayfaya model olarak gönderiyoruz
        }
        [HttpPost]
        public ActionResult Duzenle(Ogrenci ogrenci)
        {
            Ogrenci duzenlenecekOgrenci = OgrenciVeri.Ogrenciler.Where(o => o.Id == ogrenci.Id).FirstOrDefault();//Ogrencilerlistesinden post metoduyla gönderilen öğrenci bilgisi ile eşleşen kaydı bulduk
            duzenlenecekOgrenci.Ad = ogrenci.Ad;
            duzenlenecekOgrenci.BolumAd = ogrenci.BolumAd;
            duzenlenecekOgrenci.GirisYil = ogrenci.GirisYil;
            duzenlenecekOgrenci.Soyad = ogrenci.Soyad;
            duzenlenecekOgrenci.TCKimlikNo = ogrenci.TCKimlikNo;

            return RedirectToAction("Listele");//kayıt işleminden sonra listele sayfasına yönlendiriyoruz
        }

        public ActionResult Sil(int id)//adres çubuğundaki id parametresini yakala
        {
            var ogrenci = OgrenciVeri.Ogrenciler.Where(o => o.Id == id).FirstOrDefault();//ogrenciler listesine id parametresine uyan kaydı bulacak sorguyu gönder
            return View(ogrenci);//yukardaki sorguyla bulunan öğrenci kaydını sayfaya gönder
        }

        [HttpPost]
        public ActionResult Sil(Ogrenci ogrenci)//parametreyle gelen ogrenciyi yakala
        {
            Ogrenci silinecekOgrenci = OgrenciVeri.Ogrenciler.Where(o => o.Id == ogrenci.Id).FirstOrDefault();//listeden silinecek olan ogrenciyi parametreden gelen ogrenci nesnesinin id si ile sorgula ve listedeki ilgili kaydı bul
            OgrenciVeri.Ogrenciler.Remove(silinecekOgrenci);//OgrenciVeri sınıfı içerisindeki Ogrenciler isimli listeden ilgili kaydı sil
            return RedirectToAction("Listele");//silme işlemi bitince sayfayı listele sayfasına yönlendir
        }

    }
}