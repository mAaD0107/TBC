
using System;

namespace Domain.Facturacion
{
    public class ListadoFacturas
    {
        public string tipoGasto { get; set; }
        public string empresa { get; set; }
        public string nFactura { get; set; }
        public double totalFactura { get; set; }
        public string nRetencion { get; set; }
        public double totalRetencion { get; set; }
        public string nNC { get; set; }
        public double totalNC { get; set; }
        public double valorAPagar { get; set; }
        public double abono { get; set; }
        public DateTime dateAbono { get; set; }
        public string detalleAbono { get; set; }
        public double valorPendientePago { get; set; }


    }
}