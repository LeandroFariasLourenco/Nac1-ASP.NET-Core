using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nac1_ASP.NET_Core.Models;

namespace Nac1_ASP.NET_Core.Controllers
{
    public class PizzaController : Controller
    {
        private static List<Pizza> _pizzas = new List<Pizza>();

        // Regras de negócios

        [HttpPost]
        public IActionResult RegistrarPizza(Pizza pizza)
        {
            TempData["msg"] = "Cadastrado com sucesso";
            pizza.Codigo = _pizzas.Count + 1;
            _pizzas.Add(pizza);
            return RedirectToAction("cadastrar");
        }

        [HttpGet, Route("Apagar/{id:int}")]
        public IActionResult ApagarPizza(int id)
        {
            var pizzaParaRemover = _pizzas.First(p => p.Codigo == id);
            TempData["msg"] = "A pizza " + pizzaParaRemover.Nome + " foi removida com sucesso!";

            _pizzas.Remove(pizzaParaRemover);
            return RedirectToAction("listagem");
        }

        [HttpPost]
        public IActionResult AtualizarPizza(Pizza pizza)
        {
            var pizzaParaAtualizar = _pizzas.First(p => p.Codigo == pizza.Codigo);

            pizzaParaAtualizar = pizza;

            _pizzas[pizzaParaAtualizar.Codigo - 1] = pizzaParaAtualizar;
            TempData["msg"] = "A pizza " + pizzaParaAtualizar.Nome + " foi atualizada com sucesso!";
            return RedirectToAction("listagem");
        }



        // Retorno de páginas

        [Route("Atualizar/{id:int}"), HttpGet]
        public IActionResult Atualizar(int id)
        {
            var pizzaParaAtualizar = _pizzas.First(p => p.Codigo == id);
            return View(pizzaParaAtualizar);
        }
        
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            return View(_pizzas);
        }
    }
}
