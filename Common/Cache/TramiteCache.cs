using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class TramiteCache
    {
        public static bool crearTramite { get; set; }
        public static int nFactura { get; set; }
        public static string tipoTramite { get; set; }
        public static string empresa { get; set; }
        public static string ciudadNacionalizacion { get; set; }
        public static string DAI { get; set; }
        public static DateTime fechaInicio { get; set; }
        public static DateTime fechaLimite { get; set; }
        public static string secuencialCliente { get; set; }
        public static string nFacturaProveedor { get; set; }
        public static string nLiquidacion { get; set; }
        public static string nOrdenLDM { get; set; }
        public static string nCOntenedor { get; set; }
        public static string naviera { get; set; }
        public static string nGuia { get; set; }
        public static string aerolinea { get; set; }
        public static string nPasePuerta { get; set; }
        public static string forwarder { get; set; }
        public static DateTime fechaFinalizacion { get; set; }
        public static string comentarios { get; set; }
        public static string proveedor { get; set; }
        public static string rucEmpresa { get; set; }

        public static double porcentajeRetRentaAgente { get; set; }
        public static double porcentajeRetRentaTBC { get; set; }
        public static double porcentajeRetIVAAgente { get; set; }
        public static double porcentajeRetIVATBC { get; set; }

        public static Int32 diasCreditoFacturaAgente { get; set; }
        public static Int32 diasCreditoFacturaTBC { get; set; }
        public static Int32 diasCreditoGastos { get; set; }
        public static Int32 diasCreditoTransporte { get; set; }
    }
}
