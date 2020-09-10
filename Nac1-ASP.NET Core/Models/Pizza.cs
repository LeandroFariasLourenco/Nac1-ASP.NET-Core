using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nac1_ASP.NET_Core.Models
{
    public class Pizza
    {

        public int Codigo { get; set; }

        [Display(Name = "Digite o nome que irá aparecer no cardápio")]
        public string Nome { get; set; }

        [Display(Name = "Escolha o sabor")]
        public Sabores Sabor { get; set; }

        [Display(Name = "Digite os ingredientes que irão compôr a pizza")]
        public string Ingredientes { get; set; }

        [Display(Name = "Sua pizza é recheada?")]
        public bool Recheada { get; set; }

        [Display(Name = "Digite o preço da sua pizza")]
        public float Preco { get; set; }
    }
}
