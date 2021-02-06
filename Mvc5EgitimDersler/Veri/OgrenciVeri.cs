using Mvc5EgitimDersler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5EgitimDersler.Veri
{
    public class OgrenciVeri
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci
            {
                Id = 1,
                Ad = "Melih",
                Soyad = "Aktolgalı",
                BolumAd = "Yazılım Mühendisliği",
                TCKimlikNo = "1111111111",
                GirisYil = 2023
            },
            new Ogrenci
            {
                Id = 2,
                Ad = "Ünal",
                Soyad = "Dağdelen",
                BolumAd = "Biyoloji Mühendisliği",
                TCKimlikNo = "2222222222",
                GirisYil = 2014
            },
            new Ogrenci
            {
                Id = 3,
                Ad = "Emrah",
                Soyad = "Çakmaktaş",
                BolumAd = "Bilgisayar Formatçısı",
                TCKimlikNo = "33333333333",
                GirisYil = 2015
            }
        };
    }
}