using System;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public double Valor { get; set; }
        public SallesStatus Status { get; set; }
        public Seller Vendedor { get; set; }

        public SallesRecord()
        {
        }

        public SallesRecord(int id, DateTime dataCompra, double valor, SallesStatus status, Seller vendedor)
        {
            Id = id;
            DataCompra = dataCompra;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }


}
