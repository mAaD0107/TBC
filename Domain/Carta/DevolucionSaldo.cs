using System;


namespace Domain.Carta
{
    public class DevolucionSaldo
    {
        public double valor { get; set; }
        public DateTime? dateDevolucion { get; set; }
        public string detalleDevolucion { get; set; }
    }
}
