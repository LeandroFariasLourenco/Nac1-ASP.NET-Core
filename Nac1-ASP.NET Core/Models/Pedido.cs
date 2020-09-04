using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nac1_ASP.NET_Core.Models
{
    public class Pedido
    {
        public Pedido(int codigo, Cliente cliente, Pizza pizza)
        {
            Codigo = codigo;
            Cliente = cliente;
            Pizza = pizza;
        }
        public int Codigo { get; set; }

        public Cliente Cliente { get; set; }

        public Pizza Pizza { get; set; }
    }
}
