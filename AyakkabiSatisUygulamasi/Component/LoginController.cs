using Microsoft.AspNetCore.Mvc;

namespace AyakkabiSatisUygulamasi.Component
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
