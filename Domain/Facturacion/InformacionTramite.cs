
using System; 

namespace Domain.Facturacion
{
    public class InformacionTramite
    {
        public string nInforme { get; set; }
        public string cliente { get; set; }
        public string dai { get; set; }
        public string secuencialCliente { get; set; }
        public string numeroFacturaLDM { get; set; }
        public double subtoTalLDM { get; set; }
        public string personasComision { get; set; }
        public double valorComision { get; set; }
        public string personasComisionExtra { get; set; }
        public double valorComisionExtra { get; set; }
    }
}