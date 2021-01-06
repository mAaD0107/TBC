using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class EmpresaCache
    {
        public static bool crearEmpresa { get; set; }
        public static string numeroFactura { get; set; }
        public static string Empresa { get; set; }
        public static int listaFactura { get; set; }
        public static DateTime fechaFactura { get; set; }
        public static string conceptoFactura { get; set; }
        public static string subTotal { get; set; }
        public static string totalFactura { get; set; }
        public static string ivaFactura { get; set; }
        public static string ivaRetRenta { get; set; }
        public static string ivaRetIVA { get; set; }

    }
}
