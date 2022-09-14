using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class HomeController : Controller
    {
        //ações do controlador Home

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Sobre este Projeto";
            ViewData["Message"] = "Sistema de gestão de vendas para estudos de C#";
            ViewData["Github"] = "https://github.com/jonasaacampos";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
