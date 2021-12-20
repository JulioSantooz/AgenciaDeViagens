using Microsoft.AspNetCore.Mvc;

namespace _Viagens.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
