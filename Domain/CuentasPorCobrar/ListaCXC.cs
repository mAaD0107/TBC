using System;

namespace Domain.CuentasPorCobrar
{
    public class ListaCXC
    {
        public string Cliente { get; set; }
        public string CiudadNacionalizacion { get;  set; }
        public string NTramite { get;  set; }
        public string SecuencialCliente { get;  set; }
        public string DAI { get;  set; }
        public DateTime? dateSalidaPuerto { get;  set; }
        public DateTime? dateVencimiento { get;  set; }
        public string estadoVencimiento { get; set; }
        public string nFAG { get; set; }
        public string nFTBC { get; set; }
        public double AgenteGeneral { get; set; }
        public double? TBC { get; set; }
        public double? Transporte { get; set; }
        public double? Honorarios_1 { get; set; }
        public double? Honorarios_2 { get; set; }
        public double? Honorarios_3 { get; set; }
        public double? Gastos { get; set; }
        public double? Total { get; set; }
    }
}