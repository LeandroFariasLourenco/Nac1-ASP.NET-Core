using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nac1_ASP.NET_Core.Models;

namespace Nac1_ASP.NET_Core.Controllers
{
    public class PedidosController : Controller
    {
        public List<Pedido> _pedidos = new List<Pedido>();
        int Codigo = 1;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Registrar(Cliente cliente, Pizza pizza)
        {
            Pedido pedido = new Pedido(Codigo, cliente, pizza);
            _pedidos.Add(pedido);
            Codigo++;
        }
    }
}
