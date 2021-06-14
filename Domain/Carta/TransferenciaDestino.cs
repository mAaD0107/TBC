using System;


namespace Domain.Carta
{
    public class TransferenciaDestino
    {
        public double valor { get; set; }
        public DateTime? dateTransferencia { get; set; }
        public string idDestino { get; set; }
        public string detalleTransferencia { get; set; }
    }
}
