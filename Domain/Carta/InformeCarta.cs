using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using System.Data;
using Common.Cache;

namespace Domain.Carta
{
    public class InformeCarta
    {
        public DateTime dateInforme { get; private set; }
        public string Cliente { get; private set; }
        public string PersonaContacto { get; private set; }
        public string AduanaNacionalizacion { get; private set; }
        public string NumeroLiquidacion { get; private set; }
        public string NContGuia { get; private set; }
        public string DAI { get; private set; }
        public string TipoDAI { get; private set; }
        public string TipoConteGuiPP { get; private set; }
        public string SecuencialCliente { get; private set; }
        public string OrdenLDM { get; private set; }
        public string Proveedor { get; private set; }
        public string NFacturaProveedor { get; private set; }
        public double TotalValorTramite { get; private set; }
        public double TotalSaldoAFavor { get; private set; }
        public double TotalPagos { get; private set; }
        public string Observaciones { get; private set; }
        public string Usuario { get; private set; }
        public double totalAbonado { get; private set; }
        public double Saldo { get; private set; }
        public double SaldoTramite { get; private set; }
        public double SaldoTramiteST { get; private set; }
        public List<AbonosFacturas> listadoAbono { get; private set; }
        public List<DevolucionSaldo> listadoDevoluciones { get; private set; }
        public List<ListadoFacturas> listadoFacturas { get; private set; }
        public List<TransferenciaDestino> listadoTransferenciaDestino { get; private set; }
        public List<TransferenciaOrigen> listadoTransferenciaOrigen { get; private set; }


        List<string> NumeroFactura;

        public void CrearInformeCarta(string ID_Tramite)
        {
            UserDao Read = new UserDao();
            DataTable InfoCarta = Read.getInfoCarta(ID_Tramite);

            dateInforme = DateTime.Now;
            Cliente = InfoCarta.Rows[0][0].ToString();
            PersonaContacto = InfoCarta.Rows[0][1].ToString();
            AduanaNacionalizacion = InfoCarta.Rows[0][2].ToString();
            NumeroLiquidacion = InfoCarta.Rows[0][3].ToString();
            DAI = InfoCarta.Rows[0][4].ToString();

            string tipoTramite = InfoCarta.Rows[0][5].ToString();

            switch (tipoTramite)
            {
                case "Aéreo":
                    NContGuia = InfoCarta.Rows[0][7].ToString();
                    TipoDAI = "DAI:";
                    TipoConteGuiPP = "No. Guía:";
                    break;
                case "Marítimo":
                    NContGuia = InfoCarta.Rows[0][6].ToString();
                    TipoDAI = "DAI:";
                    TipoConteGuiPP = "No. Contenedor:";
                    break;
                case "Terrestre":
                    NContGuia = InfoCarta.Rows[0][13].ToString();    // Hay que agregar el CPI OK Es pase puerta
                    TipoDAI = "DAI:";
                    TipoConteGuiPP = "No. CPI:";
                    break;
                case "Por Courier":
                    NContGuia = InfoCarta.Rows[0][8].ToString();
                    TipoDAI = "DAS:";
                    TipoConteGuiPP = "No. Guía:";
                    break;
                default:
                    break;
            }

            SecuencialCliente = InfoCarta.Rows[0][9].ToString();
            OrdenLDM = InfoCarta.Rows[0][10].ToString();
            Proveedor = InfoCarta.Rows[0][11].ToString();
            NFacturaProveedor = InfoCarta.Rows[0][12].ToString();

            int NTramite = obtenerNTramite(ID_Tramite);
            DataTable facturasPagadas = Read.getFacturasPagos(NTramite);
            DataTable facturasImpagas = Read.getFacturasImpagas(NTramite);
            DataTable infoFacturas = Read.readInfoFacturas(FacturaCache.ID_Tramite);
            DataTable pagos = Read.getAbonosCarta(NTramite);
            DataTable saldoCliente = Read.getSaldoCliente(NTramite);
            DataTable saldoTransferencias = Read.getSaldoTransferencia(FacturaCache.ID_Tramite);
            DataTable saldoDevoluciones = Read.seacrhDevoluciones(obtenerNTramite(FacturaCache.ID_Tramite));
            DataTable transferenciaOrigen = Read.getTransferenciaOrigen(FacturaCache.ID_Tramite);
            DataTable transferenciaDestino = Read.getTransferenciaDestino(FacturaCache.ID_Tramite);
            DataTable pagoConTransferencia = Read.getPagoConTransferencia(FacturaCache.ID_Tramite);


            listadoFacturas = new List<ListadoFacturas>();
            listadoAbono = new List<AbonosFacturas>();
            listadoDevoluciones = new List<DevolucionSaldo>();
            listadoTransferenciaDestino = new List<TransferenciaDestino>();
            listadoTransferenciaOrigen = new List<TransferenciaOrigen>();

            NumeroFactura = new List<string>();
            double valPagar = 0;
            double totalSaldoFavor = 0;
            string tipoG;

            foreach (DataRow rowrs in facturasPagadas.Rows)
            {
                if (existeFactura(rowrs[0].ToString()))
                {
                    if (necesitaConcepto(Convert.ToString(rowrs[0])))
                    {
                        tipoG = Convert.ToString(rowrs[12]);
                    }
                    else
                    {
                        tipoG = Convert.ToString(rowrs[0]);
                    }

                    var facturasModel = new ListadoFacturas()
                    {
                        TipoGasto = tipoG,
                        Empresa = Convert.ToString(rowrs[1]),
                        NFactura = Convert.ToString(rowrs[2]),
                        TotalFactura = Convert.ToDouble(rowrs[3]),
                        NRetencion = Convert.ToString(rowrs[4]),
                        TotalRetencion = Convert.ToDouble(rowrs[5]),
                        NNC = Convert.ToString(rowrs[6]),
                        TotalNC = Convert.ToDouble(rowrs[7]),
                        ValorAPagar = Convert.ToDouble(rowrs[8]),
                        abono = Convert.ToDouble(rowrs[9]),
                        dateAbono = Convert.ToDateTime(rowrs[10]),
                        detalleAbono = Convert.ToString(rowrs[11]),
                        valorPendientePago = Read.getValorPendientePago(rowrs[2].ToString())
                    };

                    listadoFacturas.Add(facturasModel);
                    NumeroFactura.Add((rowrs[2].ToString()));
                    //valPagar += Convert.ToDouble(rowrs[8]);
                    totalSaldoFavor += Convert.ToDouble(rowrs[9]);
                }

            }

            foreach (DataRow row in facturasImpagas.Rows)
            {
                if (existeFactura(row[0].ToString()))
                {
                    if (necesitaConcepto(Convert.ToString(row[0])))
                    {
                        tipoG = Convert.ToString(row[9]);
                    }
                    else
                    {
                        tipoG = Convert.ToString(row[0]);
                    }
                    var facturasModel = new ListadoFacturas()
                    {
                        TipoGasto = tipoG,
                        Empresa = Convert.ToString(row[1]),
                        NFactura = Convert.ToString(row[2]),
                        TotalFactura = Convert.ToDouble(row[3]),
                        NRetencion = Convert.ToString(row[4]),
                        TotalRetencion = Convert.ToDouble(row[5]),
                        NNC = Convert.ToString(row[6]),
                        TotalNC = Convert.ToDouble(row[7]),
                        ValorAPagar = Convert.ToDouble(row[8]),
                        abono = 0,
                        dateAbono = null,
                        detalleAbono = "",
                        valorPendientePago = Convert.ToDouble(row[8])
                    };
                    listadoFacturas.Add(facturasModel);
                    NumeroFactura.Add((row[2].ToString()));
                    //valPagar += Convert.ToDouble(row[8]);
                }
            }

            foreach (DataRow row in infoFacturas.Rows)
            {
                if (existeFactura(row[0].ToString()))
                {
                    valPagar += Convert.ToDouble(row[10]);
                }
            }

            foreach (DataRow row in pagos.Rows)
            {
                if (existeNumeroFactura(row[3].ToString()))
                {
                    var pagoModel = new AbonosFacturas()
                    {
                        abono = Convert.ToDouble(row[0]),
                        dateAbono = Convert.ToDateTime(row[1]),
                        detalleAbono = Convert.ToString(row[2])
                    };

                    listadoAbono.Add(pagoModel);
                }
            }

            foreach (DataRow row in saldoDevoluciones.Rows)
            {
                var Devolucion = new DevolucionSaldo()
                {
                    valor = Convert.ToDouble(row[2]),
                    dateDevolucion = Convert.ToDateTime(row[0]),
                    detalleDevolucion = Convert.ToString(row[1])
                };
                listadoDevoluciones.Add(Devolucion);
            }

            foreach (DataRow row in transferenciaOrigen.Rows)
            {
                var transfOrigen = new TransferenciaOrigen()
                {
                    valor = Convert.ToDouble(row[0]),
                    dateTransferencia = Convert.ToDateTime(row[1]),
                    idOrigen = Convert.ToString(row[2]),
                    detalleTransferencia = Convert.ToString(row[3])
                };
                listadoTransferenciaOrigen.Add(transfOrigen);
            }

            foreach (DataRow row in transferenciaDestino.Rows)
            {
                var transfDestino = new TransferenciaDestino()
                {
                    valor = Convert.ToDouble(row[0]),
                    dateTransferencia = Convert.ToDateTime(row[1]),
                    idDestino = Convert.ToString(row[2]),
                    detalleTransferencia = Convert.ToString(row[3])
                };
                listadoTransferenciaDestino.Add(transfDestino);
            }


            double saldo = 0;
            foreach (DataRow row in saldoCliente.Rows)
            {
                saldo += Convert.ToDouble(row[0] is DBNull ? 0 : row[0]);
            }

            double saldoTransferencia = 0;

            foreach (DataRow row in saldoTransferencias.Rows)
            {
                saldoTransferencia += Convert.ToDouble(row[0] is DBNull ? 0 : row[0]);
            }

            double devoluciones = 0;
            foreach (DataRow row in saldoDevoluciones.Rows)
            {
                devoluciones += Convert.ToDouble(row[2] is DBNull ? 0 : row[2]);
            }

            double pagoTransferencia = 0;
            foreach (DataRow row in pagoConTransferencia.Rows)
            {
                pagoTransferencia += Convert.ToDouble(row[0] is DBNull ? 0 : row[0]);
            }

            TotalValorTramite = valPagar;
            TotalPagos = TotalValorTramite - totalSaldoFavor;
            TotalSaldoAFavor = TotalValorTramite - totalSaldoFavor + saldo - saldoTransferencia + devoluciones;

            Observaciones = CartaCache.Observaciones;

            Usuario = UserCache.FirstName + " " + UserCache.LastName;

            Observaciones = CartaCache.Observaciones;

            Usuario = UserCache.FirstName + " " + UserCache.LastName;


        }

        private int obtenerNTramite(string ID_Tramite)
        {
            string[] texto = ID_Tramite.Split(new string[] { "-" }, StringSplitOptions.None);
            return int.Parse(texto[1]);
        }

        private bool existeFactura(string tipoFactura)
        {
            return CartaCache.Facturas.Any(x => x == tipoFactura);
        }

        private bool existeNumeroFactura(string nFactura)
        {
            return NumeroFactura.Any(x => x == nFactura);
        }

        List<string> listaConceptos = new List<string>()
        {
            "Gastos_I",
            "Gastos_II",
            "Gastos_III",
            "Gastos_IV",
            "Gastos_V",
            "Honorarios_I",
            "Honorarios_II",
            "Honorarios_III",
            "Transporte_I",
            "Transporte_II",
            "Transporte_III"
        };

        private bool necesitaConcepto(string tipoFactura)
        {
            return listaConceptos.Any(x => x == tipoFactura);
        }
    }
}
