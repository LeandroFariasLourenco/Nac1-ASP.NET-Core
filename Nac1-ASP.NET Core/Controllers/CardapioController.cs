using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nac1_ASP.NET_Core.Models;

namespace Nac1_ASP.NET_Core.Controllers
{
    public class CardapioController : Controller
    {

        public List<Pizza> _pizzas = new List<Pizza>();
        public List<string> _ingredients = new List<string>();
        public IActionResult Index()
        {
            _ingredients.Add("Farinha de Trigo");
            _ingredients.Add("Óleo");
            _ingredients.Add("Ovos");
            _ingredients.Add("Sal");
            _ingredients.Add("Leite");
            _ingredients.Add("Fermento");
            _ingredients.Add("Açúcar");
            _ingredients.Add("Água");


            Pizza pizza1 = new Pizza(_pizzas.Count + 1, "Bacon", _ingredients, false, 31.30);
            _pizzas.Add(pizza1);

            Pizza pizza2 = new Pizza(_pizzas.Count + 1, "Mussarela", _ingredients, true, 24.00);
            _pizzas.Add(pizza2);

            Pizza pizza3 = new Pizza(_pizzas.Count + 1, "Nordestina", _ingredients, true, 33.50);
            _pizzas.Add(pizza3);

            Pizza pizza4 = new Pizza(_pizzas.Count + 1, "Toscana", _ingredients, false, 29.50);
            _pizzas.Add(pizza4);
            return View(_pizzas);
        }
    }
}
