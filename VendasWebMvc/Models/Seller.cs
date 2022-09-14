using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<SallesRecord> Vendas { get; set; }

        public Seller()
        {
        }

        public Seller(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda(SallesRecord registroDeVenda)
        {
            Vendas.Add(registroDeVenda);
        }

        public void RemoverVenda(SallesRecord registroDeVenda)
        {
            Vendas.Remove(registroDeVenda);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(registroDeVenda => registroDeVenda.DataCompra >= inicio && registroDeVenda.DataCompra <= final).
                Sum(registroDeVenda => registroDeVenda.Valor);
        }
    }
}
