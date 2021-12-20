using Microsoft.AspNetCore.Mvc;
using _Viagens.Models;
using _Viagens.Data;
using System.Linq;
using System;

namespace _Viagens.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["feedback"] = dbcontext.Feedbacks.Where(p => p.Id_feedback > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(feedback);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Feedback feedback)
        {
            var dbcontext = new Contexto();

            var clienteDelete = dbcontext.Feedbacks.Find(feedback.Id_feedback);
            dbcontext.Remove(clienteDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Feedback novosDadosCliente)
        {
            var dbcontext = new Contexto();

            var antigosDadosCliente = dbcontext.Feedbacks.Find(novosDadosCliente.Id_feedback);

            antigosDadosCliente.Data = novosDadosCliente.Data;
            antigosDadosCliente.Descricao = novosDadosCliente.Descricao;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
