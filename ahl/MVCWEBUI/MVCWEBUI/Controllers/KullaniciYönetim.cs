using MVCWEBUI.Models.DB;
using Microsoft.AspNetCore.Mvc;

namespace MVCWEBUI.Controllers
{
    public class KullaniciYönetim : Controller
    {
        public IActionResult Delete(int? id)
        {
            BigdataContext db = new BigdataContext();
            var silinecek = db.Users.FirstOrDefault(x => x.Surname == "Ozsecer");
            //var silinecek=db.Users.FirstOrDefault(x=>x.Surname==id);
            db.Users.Remove(silinecek);
            return View();
        }
    }
}
