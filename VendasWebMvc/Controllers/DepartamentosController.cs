using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();

            listaDepartamentos.Add(new Departamento{ Id = 1, Nome = "Eletronicos" });
            listaDepartamentos.Add(new Departamento{ Id = 2, Nome = "Moda" });


            return View(listaDepartamentos);
        }
    }
}
