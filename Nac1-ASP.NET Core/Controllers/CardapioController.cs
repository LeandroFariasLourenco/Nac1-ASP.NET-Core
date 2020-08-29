using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nac1_ASP.NET_Core.Controllers
{
    public class CardapioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
