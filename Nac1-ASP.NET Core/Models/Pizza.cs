using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nac1_ASP.NET_Core.Models
{
    public class Pizza
    {
        private string Sabor { get; set; }

        private List<string> Ingredients { get; set; }

        private bool Recheada { get; set; }

        private double Preco { get; set; }
    }
}
