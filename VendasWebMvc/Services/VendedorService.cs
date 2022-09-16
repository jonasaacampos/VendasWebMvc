using System.Collections.Generic;
using System.Linq;
using VendasWebMvc.Data;

namespace VendasWebMvc.Models
{
    public class VendedorService
    {
        private readonly VendasWebMvcContext _context;

        public VendedorService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Vendedores.ToList();
        }
    }
}
