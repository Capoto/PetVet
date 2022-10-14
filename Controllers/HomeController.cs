using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVet.Models;

namespace PetVet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servico()
        {
            return View();
        }
        public IActionResult Sucesso()
        {
            List<Agendamento> agenda = Dados.Registro.Listar();
            return View(agenda);
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        public IActionResult Comprova()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Agendamento(Agendamento agendar)
        {

            Dados.Registro.Adiciconar(agendar);
            return View("Comprova");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
