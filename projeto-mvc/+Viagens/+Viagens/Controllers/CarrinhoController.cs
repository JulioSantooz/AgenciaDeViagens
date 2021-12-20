using Microsoft.AspNetCore.Mvc;

namespace _Viagens.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
