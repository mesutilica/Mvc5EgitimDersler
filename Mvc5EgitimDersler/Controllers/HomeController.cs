using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5EgitimDersler.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()//Bir action a view oluşturmak için Index e sağ tıklayıp Add view e tıklamalıyız
        {
            //Index sayfası çağrıldığında ilk olarak bu metot çalışır ve geriye Views klasörü altındaki home klasörü altındaki Index.cshtml sayfasını döndürür ve sayfa çalıştırılır
            return View();
        }
        [HttpPost]//Index sayfasında bir butona tıklandığında sayfa sunucuya yollanır bu işleme post işlemi denir
        public ActionResult Index(int id)
        {
            //Index sayfasında bir Post işlemi yapıldağında bu metot çalışır
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }

    }
}