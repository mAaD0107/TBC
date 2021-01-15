using System;
using System.Collections.Generic;
using System.Data;

namespace Domain.Carta
{
    public class ListadoFacturas
    {
        public string TipoGasto { get; set; }
        public string Empresa { get; set; }
        public string NFactura { get; set; }
        public double TotalFactura { get; set; }
        public string NRetencion { get; set; }
        public double TotalRetencion { get; set; }
        public string NNC { get; set; }
        public double TotalNC { get; set; }
        public double ValorAPagar { get; set; }
        public double abono { get; set; }
        public DateTime? dateAbono { get; set; }
        public string detalleAbono { get; set; }
        public double valorPendientePago { get; set; }
    }
}