using Microsoft.AspNetCore.Mvc;

namespace MVCWEBUI.Areas.Admin.Controllers
{
    public class TestController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
