using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5EgitimDersler.Models
{
    public class UyeGiris
    {
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAd { get; set; }

        [DisplayName("Şifre")]
        [DataType(DataType.Password)]//Şifre alanının ekranda password alanı olarak görünmesi için
        public string Sifre { get; set; }
    }


    public class Uye
    {
        public int Id { get; set; }

        [EmailAddress()]//Bu alana gelebilecek verinin e mail adresi formatında olması içün
        public string EPosta { get; set; }

        [DisplayName("Şifre")]
        [DataType(DataType.Password)]//Şifre alanının ekranda password alanı olarak görünmesi için
        public string Sifre { get; set; }

        [DisplayName("Şifre Tekrarı")]
        [DataType(DataType.Password)]
        [Compare("Sifre")]
        public string Sifre2 { get; set; }
    }

}