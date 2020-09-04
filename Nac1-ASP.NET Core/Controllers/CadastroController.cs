using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nac1_ASP.NET_Core.Models;

namespace Nac1_ASP.NET_Core.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar(Cliente cliente, Pizza pizza)
        {
            return RedirectToAction("Registrar", "PedidosController");
        }
    }
}
