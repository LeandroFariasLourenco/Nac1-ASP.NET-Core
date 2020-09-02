using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nac1_ASP.NET_Core.Models
{
    public class Pizza
    {
        public Pizza(int codigo, string sabor, List<string> ingredients, bool recheada, double preco)
        {
            Codigo = codigo;
            Sabor = sabor;
            Ingredients = ingredients;
            Recheada = recheada;
            Preco = preco;
        }

        public int Codigo { get; set; }

        public string Sabor { get; set; }

        public List<string> Ingredients { get; set; }

        public bool Recheada { get; set; }

        public double Preco { get; set; }
    }
}
