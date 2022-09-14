using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Departamento
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> Vendedores { get; set; } = new List<Seller>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Seller vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicio, DateTime fim)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicio, fim));
        }

    }
}
