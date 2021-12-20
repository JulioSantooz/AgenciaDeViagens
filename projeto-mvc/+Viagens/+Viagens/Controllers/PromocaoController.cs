using Microsoft.AspNetCore.Mvc;

namespace _Viagens.Controllers
{
    public class PromocaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
