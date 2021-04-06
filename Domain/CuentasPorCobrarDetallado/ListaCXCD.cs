using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CuentasPorCobrarDetallado
{
    public class ListaCXCD
    {
        public string Cliente { get; set; }
        public string CiudadNacionalizacion { get; set; }
        public string NTramite { get; set; }
        public string SecuencialCliente { get; set; }
        public string DAI { get; set; }
        public DateTime? dateSalidaPuerto { get; set; }
        public string EmpresaFactura { get; set; }
        public DateTime? dateVencimiento { get; set; }
        public DateTime? dateFactura { get; set; }
        public string estadoVencimiento { get; set; }
        public string TF { get; set; }
        public string nFactura { get; set; }
        public double valorACobrar { get; set; }
        public double Total { get; set; }

    }
}
