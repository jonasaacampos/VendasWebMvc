using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedoresService;

        public VendedoresController(VendedorService vendedoresService)
        {
            _vendedoresService = vendedoresService;
        }

        public IActionResult Index()
        {
            var listaDeVendedores = _vendedoresService.FindAll();
            return View(listaDeVendedores);
        }
    }
}
