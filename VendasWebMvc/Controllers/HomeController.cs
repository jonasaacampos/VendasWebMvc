using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;
using VendasWebMvc.Models.ViewModels;

namespace VendasWebMvc.Controllers

{
    public class HomeController : Controller
    {
        //ações do controlador Home

        /* IActionResult => este é o tipo genérico (Interface) para todo o resultado de uma ação
         * Como tipo de dado poderíamos utilizar o ViewResult, ou PartialView, 
         * Mas manter a interface permite a impletação de forma mais flexível
         */

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
