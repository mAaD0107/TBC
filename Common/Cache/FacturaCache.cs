using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class FacturaCache
    {

        public static string Cliente {get; set;}
        public static string RazonSocial { get; set; }
        public static string RUC { get; set; }
        public static string ID_Tramite { get; set; }
        public static string DAI { get; set; }
        public static string SecuencialCliente { get; set;}
        public static int Tabla { get; set; }
        public static DateTime DateDesde { get; set; }
        public static DateTime DateHasta { get; set; }
        public static string Buscar { get; set; }


    }
}
