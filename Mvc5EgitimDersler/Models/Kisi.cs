using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;//Özelliklere attribute ekleyebilmek için class lara bu using i eklememiz lazım
using System.Linq;
using System.Web;

namespace Mvc5EgitimDersler.Models
{
    //Model Validation : Projelerimizde kullandığımız class larda verilerin tiplerini geçerlilik durumlarını, zorunlu alan olup olmadığını vb özelliklerini ayarlamak için kullanılır.
    public class Kisi
    {
        public int Id { get; set; }

        [Required, StringLength(50)]//Ad alanı zorunlu alan olsun ve maksimum 50 karakter girilebilsin
        public string Ad { get; set; }

        [Required, StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [DisplayName("TC Kimlik Numarası")]//Otomatik oluşturduğumuz ekle, düzenle, sil sayfalarında TCKimlikNo yerine TC Kimlik Numarası şeklinde yazması için bu özellik kullanılıyor
        [MinLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır")]//Bu özelliğe eklenebilecek minimum değer
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır")]//Bu özelliğe eklenebilecek maksimum değer
        public string TCKimlikNo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]//Ekranda gösterilecek olan tarihin hangi formatta gösterileceğini ayarlayabiliriz
        public DateTime DogumTarih { get; set; }
    }
}