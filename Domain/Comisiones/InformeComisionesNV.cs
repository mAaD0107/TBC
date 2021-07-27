using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace Domain.Comisiones
{
    public class InformeComisionesNV
    {
        public string fecha { get; private set; }
        public string valorComision { get; private set; }
        public string DAI { get; private set; }
        public string Secuencial { get; private set; }
        public string Mes { get; private set; }
        public string Id_Tamite { get; private set; }

        public void CrearInformeComisionesNV()
        {
            Id_Tamite = ComisionesNVCache.Id_Tamite;
            valorComision = ComisionesNVCache.valorComision;
            fecha = ComisionesNVCache.fecha;
            DAI = ComisionesNVCache.DAI;
            Secuencial = ComisionesNVCache.Secuencial;
            Mes = ComisionesNVCache.Mes;
            }
        }
}
