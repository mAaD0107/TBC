using Bunifu.UI.WinForms;
using Common.Cache;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCrearPago : Form
    {
        public FormCrearPago()
        {
            InitializeComponent();

            panelPagos.Scroll += (s, e) => {
                HandleScroll();
            };
            panelPagos.MouseWheel += (s, e) => {
                HandleScroll();
            };


            panelPagoCompleto.Scroll += (s, e) => {
                HandleScroll();
            };
            panelPagoCompleto.MouseWheel += (s, e) => {
                HandleScroll();
            };
        }

        bool maximized = false;
        private float valAnterior = 0;

        private void maximizar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            PanelGeneral.Visible = false;

            if (!maximized)
            {
                formPrincipal.panelMenuVertical.Visible = false;
                valAnterior = formPrincipal.panelGlobal.ColumnStyles[0].Width;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;

                formPrincipal.panelInferior.Visible = false;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;

                PanelGeneral.ColumnStyles[1].Width = 40;



            }
            else
            {

                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                formPrincipal.panelInferior.Visible = true;

                PanelGeneral.ColumnStyles[1].Width = 40;
            }

            maximized = !maximized;

            PanelGeneral.Visible = true;
        }

        private void acoplarPaneles()
        {

            // panelInfoPago.Left = (panelInfoPago.Parent.Width / 2) - (panelInfoPago.Width / 2);
            panelTituloForm.Width = panelPagos.Width - 10;

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormCrearPago_Load(object sender, EventArgs e)
        {
            readTramite();
            readSaldo();
            cargarDatosTramite();
            //InitializeListView();
            dateFactura.Value = DateTime.Today;
            datePagoGeneral.Value = DateTime.Today;
        }

        double transferencia = 0, devolucion = 0, pagoTransferencia = 0, transferenciaHacia = 0, devolucionTransferencia = 0;
        private void readSaldo()
        {
            UserModel Read = new UserModel();

            saldCliente = Read.saldoTramite(PagosCache.numeroTramite);
            transferencia = Read.trasnferenciaTramite(PagosCache.idTramite);                 // TRansferencia Desde 
            devolucion = Read.devolucionTramite(PagosCache.numeroTramite);
            devolucionTransferencia = Read.devolucionTransferencia(PagosCache.numeroTramite);
            pagoTransferencia = Read.pagoTransferencia(PagosCache.idTramite);
            transferenciaHacia = Read.trasnferenciaTramiteHacia(PagosCache.idTramite);      // Transferencia Hacia

            saldCliente = saldCliente - devolucion - transferencia;
            transferenciaHacia = transferenciaHacia - pagoTransferencia - devolucionTransferencia; 
            // Hay dos tipos de transferencia 
            // Desde -> se resta de saldo cliente
            // Hacia -> se suma a saldo cliente 
            lblSaldoCliente.Text = "Saldo Cliente: $" + (saldCliente).ToString("N2");
            lblSaldoTransferencia.Text = "Saldo Transferencia: $" + (transferenciaHacia).ToString("N2");
        }


        private void cargarDatosTramite()
        {
            txtDAI.Text = PagosCache.DAI;
            txtSecuencialCliente.Text = PagosCache.secuencialCliente;
            txtCliente.Text = PagosCache.Empresa;
            txtIDTramite.Text = PagosCache.idTramite;
        }




        private bool cerrarVentana = false;
        DataTable Pagos = new DataTable();

        List<string> Agente = new List<string>();
        List<string> AgenteLDM = new List<string>();
        List<string> TBC = new List<string>();
        List<string> Transporte = new List<string>();
        List<string> GastosLocales = new List<string>();
        List<string> VistoTHC = new List<string>();
        List<string> RetiroBL = new List<string>();
        List<string> LiquidacionAduana = new List<string>();
        List<string> RetiroGuia = new List<string>();
        List<string> Demoraje = new List<string>();
        List<string> ActualizacionCarta = new List<string>();
        List<string> Almacenaje = new List<string>();
        List<string> DevContenedor = new List<string>();
        List<string> ManipContenedor = new List<string>();
        List<string> GastosI = new List<string>();
        List<string> GastosII = new List<string>();
        List<string> GastosIII = new List<string>();
        List<string> GastosIV = new List<string>();
        List<string> GastosV = new List<string>();
        List<string> HonorariosI = new List<string>();
        List<string> HonorariosII = new List<string>();
        List<string> HonorariosIII = new List<string>();
        List<string> TransporteI = new List<string>();
        List<string> TransporteII = new List<string>();
        List<string> TransporteIII = new List<string>();


        double pAgente, pAgenteLDM, pTBC, pTransporte, pGastosLocales, pVistoTHC, pRetiroBL,
               pLiquidacionAduana, pRetiroGuia, pDemoraje, pActualizacionCarta,
               pAlmacenaje, pDevContenedor, pManipContenedor, pGastosI, pGastosII,
               pGastosIII, pGastosIV, pGastosV, pHonorariosI, pHonorariosII, pHonorariosIII,
               pTransporteI, pTransporteII, pTransporteIII;

        double totPago = 0;
        private void readTramite()
        {
            UserModel Read = new UserModel();

            Pagos = Read.readPagos(PagosCache.numeroTramite);


            checkListFacturas.DataSource = Pagos;
            checkListFacturas.DisplayMember = "Tipo_Factura";
            checkListFacturas.ValueMember = "Tipo_Factura";

            clearListas();
            listas.Clear();

            DataTable Abonos = new DataTable();

            double totalPagos = 0;

            if (Pagos.Rows.Count != 0)
            {
                foreach (DataRow pago in Pagos.Rows)
                {
                    switch (pago["Tipo_Factura"].ToString())
                    {
                        case "Agente":
                            lblEmpresaAgente.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaAgente.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobAgente.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            Agente.Add(pago["Empresa_Factura"].ToString());
                            Agente.Add(pago["Numero_Factura"].ToString());
                            Agente.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            Agente.Add(pago["Numero_Retencion"].ToString());
                            Agente.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            Agente.Add(pago["Numero_Nota_Credito"].ToString());
                            Agente.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            Agente.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pAgente = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pAgente;

                            Abonos = Read.readAbonos(Agente[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pAgente -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pAgente -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                Agente[7] = pAgente.ToString("N2");
                                lblValCobAgente.Text = "Valor a Cobrar: " + Agente[7];
                            }


                            listas.Add(Agente.ToArray());


                            panelAgente.Visible = true;
                            break;

                        case "Agente_LDM":
                            lblEmpresaLDM.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblNFacturaLDM.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobAgenteLDM.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            AgenteLDM.Add(pago["Empresa_Factura"].ToString());
                            AgenteLDM.Add(pago["Numero_Factura"].ToString());
                            AgenteLDM.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            AgenteLDM.Add(pago["Numero_Retencion"].ToString());
                            AgenteLDM.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            AgenteLDM.Add(pago["Numero_Nota_Credito"].ToString());
                            AgenteLDM.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            AgenteLDM.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pAgenteLDM = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pAgenteLDM;

                            Abonos = Read.readAbonos(AgenteLDM[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pAgenteLDM -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pAgenteLDM -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                AgenteLDM[7] = pAgenteLDM.ToString("N2");
                                lblValCobAgenteLDM.Text = "Valor a Cobrar: " + AgenteLDM[7];
                            }


                            listas.Add(AgenteLDM.ToArray());


                            panelAgenteLDM.Visible = true;
                            break;

                        case "TBC":
                            lblEmpresaTBC.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaTBC.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobTBC.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            TBC.Add(pago["Empresa_Factura"].ToString());
                            TBC.Add(pago["Numero_Factura"].ToString());
                            TBC.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            TBC.Add(pago["Numero_Retencion"].ToString());
                            TBC.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            TBC.Add(pago["Numero_Nota_Credito"].ToString());
                            TBC.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            TBC.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pTBC = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pTBC;

                            Abonos = Read.readAbonos(TBC[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pTBC -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pTBC -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                TBC[7] = pTBC.ToString("N2");
                                lblValCobTBC.Text = "Valor a Cobrar: " + TBC[7];
                            }


                            listas.Add(TBC.ToArray());

                            panelTBC.Visible = true;
                            break;

                        case "Transporte":
                            lblEmpresaTransporte.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaTransporte.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobTransporte.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            Transporte.Add(pago["Empresa_Factura"].ToString());
                            Transporte.Add(pago["Numero_Factura"].ToString());
                            Transporte.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            Transporte.Add(pago["Numero_Retencion"].ToString());
                            Transporte.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            Transporte.Add(pago["Numero_Nota_Credito"].ToString());
                            Transporte.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            Transporte.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pTransporte = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pTransporte;

                            Abonos = Read.readAbonos(Transporte[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pTransporte -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pTransporte -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                Transporte[7] = pTransporte.ToString("N2");
                                lblValCobTransporte.Text = "Valor a Cobrar: " + Transporte[7];
                            }

                            listas.Add(Transporte.ToArray());

                            panelTransporte.Visible = true;
                            break;

                        case "Gastos_Locales":
                            lblEmpresaGastos.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaGastos.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobGastos.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            GastosLocales.Add(pago["Empresa_Factura"].ToString());
                            GastosLocales.Add(pago["Numero_Factura"].ToString());
                            GastosLocales.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            GastosLocales.Add(pago["Numero_Retencion"].ToString());
                            GastosLocales.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            GastosLocales.Add(pago["Numero_Nota_Credito"].ToString());
                            GastosLocales.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            GastosLocales.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pGastosLocales = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pGastosLocales;

                            Abonos = Read.readAbonos(GastosLocales[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pGastosLocales -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pGastosLocales -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                GastosLocales[7] = pGastosLocales.ToString("N2");
                                lblValCobGastos.Text = "Valor a Cobrar: " + GastosLocales[7];
                            }

                            listas.Add(GastosLocales.ToArray());

                            panelGastosLocales.Visible = true;
                            break;

                        case "Visto_THC":
                            lblEmpresaVistoTHV.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaVistoTHC.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobVistoTHC.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            VistoTHC.Add(pago["Empresa_Factura"].ToString());
                            VistoTHC.Add(pago["Numero_Factura"].ToString());
                            VistoTHC.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            VistoTHC.Add(pago["Numero_Retencion"].ToString());
                            VistoTHC.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            VistoTHC.Add(pago["Numero_Nota_Credito"].ToString());
                            VistoTHC.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            VistoTHC.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pVistoTHC = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pVistoTHC;

                            Abonos = Read.readAbonos(VistoTHC[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pVistoTHC -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pVistoTHC -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                VistoTHC[7] = pVistoTHC.ToString("N2");
                                lblValCobVistoTHC.Text = "Valor a Cobrar: " + VistoTHC[7];
                            }

                            listas.Add(VistoTHC.ToArray());

                            panelVistoTHC.Visible = true;
                            break;

                        case "Retiro_BL":
                            lblEmpresaRetiroBL.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaRetiroBL.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobRetiroBL.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            RetiroBL.Add(pago["Empresa_Factura"].ToString());
                            RetiroBL.Add(pago["Numero_Factura"].ToString());
                            RetiroBL.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            RetiroBL.Add(pago["Numero_Retencion"].ToString());
                            RetiroBL.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            RetiroBL.Add(pago["Numero_Nota_Credito"].ToString());
                            RetiroBL.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            RetiroBL.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pRetiroBL = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pRetiroBL;

                            Abonos = Read.readAbonos(RetiroBL[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pRetiroBL -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pRetiroBL -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                RetiroBL[7] = pRetiroBL.ToString("N2");
                                lblValCobRetiroBL.Text = "Valor a Cobrar: " + RetiroBL[7];
                            }

                            listas.Add(RetiroBL.ToArray());

                            panelRetiroBL.Visible = true;
                            break;

                        case "Liquidación_Aduana":
                            lblEmpresaLiq.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaLiq.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobLiq.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            LiquidacionAduana.Add(pago["Empresa_Factura"].ToString());
                            LiquidacionAduana.Add(pago["Numero_Factura"].ToString());
                            LiquidacionAduana.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            LiquidacionAduana.Add(pago["Numero_Retencion"].ToString());
                            LiquidacionAduana.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            LiquidacionAduana.Add(pago["Numero_Nota_Credito"].ToString());
                            LiquidacionAduana.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            LiquidacionAduana.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pLiquidacionAduana = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pLiquidacionAduana;

                            Abonos = Read.readAbonos(LiquidacionAduana[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pLiquidacionAduana -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pLiquidacionAduana -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                LiquidacionAduana[7] = pLiquidacionAduana.ToString("N2");
                                lblValCobLiq.Text = "Valor a Cobrar: " + LiquidacionAduana[7];
                            }

                            listas.Add(LiquidacionAduana.ToArray());

                            panelLiquidacionAduana.Visible = true;
                            break;

                        case "Retiro_Guía":
                            lblEmpresaRetiroGuia.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaRetiroGuia.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobRetiroGuia.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            RetiroGuia.Add(pago["Empresa_Factura"].ToString());
                            RetiroGuia.Add(pago["Numero_Factura"].ToString());
                            RetiroGuia.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            RetiroGuia.Add(pago["Numero_Retencion"].ToString());
                            RetiroGuia.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            RetiroGuia.Add(pago["Numero_Nota_Credito"].ToString());
                            RetiroGuia.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            RetiroGuia.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pRetiroGuia = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pRetiroGuia;

                            Abonos = Read.readAbonos(RetiroGuia[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pRetiroGuia -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pRetiroGuia -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                RetiroGuia[7] = pRetiroGuia.ToString("N2");
                                lblValCobRetiroGuia.Text = "Valor a Cobrar: " + RetiroGuia[7];
                            }

                            listas.Add(RetiroGuia.ToArray());

                            panelRetiroGuía.Visible = true;
                            break;

                        case "Demoraje":
                            lblEmpresaDemoraje.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaDemoraje.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobDemoraje.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            Demoraje.Add(pago["Empresa_Factura"].ToString());
                            Demoraje.Add(pago["Numero_Factura"].ToString());
                            Demoraje.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            Demoraje.Add(pago["Numero_Retencion"].ToString());
                            Demoraje.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            Demoraje.Add(pago["Numero_Nota_Credito"].ToString());
                            Demoraje.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            Demoraje.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pDemoraje = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pDemoraje;

                            Abonos = Read.readAbonos(Demoraje[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pDemoraje -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pDemoraje -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                Demoraje[7] = pDemoraje.ToString("N2");
                                lblValCobDemoraje.Text = "Valor a Cobrar: " + Demoraje[7];
                            }

                            listas.Add(Demoraje.ToArray());

                            panelDemoraje.Visible = true;
                            break;

                        case "Actualización_Carta":
                            lblEmpresaActCArta.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaActCarta.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobActCarta.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            ActualizacionCarta.Add(pago["Empresa_Factura"].ToString());
                            ActualizacionCarta.Add(pago["Numero_Factura"].ToString());
                            ActualizacionCarta.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            ActualizacionCarta.Add(pago["Numero_Retencion"].ToString());
                            ActualizacionCarta.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            ActualizacionCarta.Add(pago["Numero_Nota_Credito"].ToString());
                            ActualizacionCarta.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            ActualizacionCarta.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pActualizacionCarta = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pActualizacionCarta;

                            Abonos = Read.readAbonos(ActualizacionCarta[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pActualizacionCarta -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pActualizacionCarta -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                ActualizacionCarta[7] = pActualizacionCarta.ToString("N2");
                                lblValCobActCarta.Text = "Valor a Cobrar: " + ActualizacionCarta[7];
                            }

                            listas.Add(ActualizacionCarta.ToArray());


                            panelActualizacionCarta.Visible = true;
                            break;

                        case "Almacenaje":
                            lblEmpresaAlmacenaje.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaAlmacenaje.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobAlmacenaje.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            Almacenaje.Add(pago["Empresa_Factura"].ToString());
                            Almacenaje.Add(pago["Numero_Factura"].ToString());
                            Almacenaje.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            Almacenaje.Add(pago["Numero_Retencion"].ToString());
                            Almacenaje.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            Almacenaje.Add(pago["Numero_Nota_Credito"].ToString());
                            Almacenaje.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            Almacenaje.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pAlmacenaje = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pAlmacenaje;

                            Abonos = Read.readAbonos(Almacenaje[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pAlmacenaje -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pAlmacenaje -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                Almacenaje[7] = pAlmacenaje.ToString("N2");
                                lblValCobAlmacenaje.Text = "Valor a Cobrar: " + Almacenaje[7];
                            }

                            listas.Add(Almacenaje.ToArray());

                            panelAlmacenaje.Visible = true;
                            break;


                        case "Devolución_Contenedor":
                            lblEmpresaDevCont.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaDevCont.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobDevCont.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            DevContenedor.Add(pago["Empresa_Factura"].ToString());
                            DevContenedor.Add(pago["Numero_Factura"].ToString());
                            DevContenedor.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            DevContenedor.Add(pago["Numero_Retencion"].ToString());
                            DevContenedor.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            DevContenedor.Add(pago["Numero_Nota_Credito"].ToString());
                            DevContenedor.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            DevContenedor.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pDevContenedor = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pDevContenedor;

                            Abonos = Read.readAbonos(DevContenedor[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pDevContenedor -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pDevContenedor -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                DevContenedor[7] = pDevContenedor.ToString("N2");
                                lblValCobDevCont.Text = "Valor a Cobrar: " + DevContenedor[7];
                            }

                            listas.Add(DevContenedor.ToArray());


                            panelDevolucionContenedor.Visible = true;
                            break;

                        case "Manipulación_Contenedor":
                            lblEmpresaManContenedor.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblFacturaManContenedor.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobManCont.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            ManipContenedor.Add(pago["Empresa_Factura"].ToString());
                            ManipContenedor.Add(pago["Numero_Factura"].ToString());
                            ManipContenedor.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            ManipContenedor.Add(pago["Numero_Retencion"].ToString());
                            ManipContenedor.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            ManipContenedor.Add(pago["Numero_Nota_Credito"].ToString());
                            ManipContenedor.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            ManipContenedor.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            pManipContenedor = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pManipContenedor;

                            Abonos = Read.readAbonos(ManipContenedor[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pManipContenedor -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pManipContenedor -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                ManipContenedor[7] = pManipContenedor.ToString("N2");
                                lblValCobManCont.Text = "Valor a Cobrar: " + ManipContenedor[7];
                            }

                            listas.Add(ManipContenedor.ToArray());


                            panelManipulacionContenedor.Visible = true;
                            break;

                        case "Gastos_I":
                            lblEmpresaGastosI.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaGastosI.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobGastosI.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            GastosI.Add(pago["Empresa_Factura"].ToString());
                            GastosI.Add(pago["Numero_Factura"].ToString());
                            GastosI.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            GastosI.Add(pago["Numero_Retencion"].ToString());
                            GastosI.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            GastosI.Add(pago["Numero_Nota_Credito"].ToString());
                            GastosI.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            GastosI.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            GastosI.Add(pago["Concepto"].ToString());

                            pGastosI = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pGastosI;


                            Abonos = Read.readAbonos(GastosI[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pGastosI -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pGastosI -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                GastosI[7] = pGastosI.ToString("N2");
                                lblValCobGastosI.Text = "Valor a Cobrar: " + GastosI[7];
                            }

                            listas.Add(GastosI.ToArray());


                            panelGastosI.Visible = true;
                            break;

                        case "Gastos_II":
                            lblEmpresaGastosII.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaGastosII.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobGastosII.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            GastosII.Add(pago["Empresa_Factura"].ToString());
                            GastosII.Add(pago["Numero_Factura"].ToString());
                            GastosII.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            GastosII.Add(pago["Numero_Retencion"].ToString());
                            GastosII.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            GastosII.Add(pago["Numero_Nota_Credito"].ToString());
                            GastosII.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            GastosII.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            GastosII.Add(pago["Concepto"].ToString());

                            pGastosII = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pGastosII;


                            Abonos = Read.readAbonos(GastosII[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pGastosII -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pGastosII -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                GastosII[7] = pGastosII.ToString("N2");
                                lblValCobGastosII.Text = "Valor a Cobrar: " + GastosII[7];
                            }

                            listas.Add(GastosII.ToArray());


                            panelGastosII.Visible = true;
                            break;

                        case "Gastos_III":
                            lblEmpresaGastosIII.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaGastosIII.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobGastosIII.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            GastosIII.Add(pago["Empresa_Factura"].ToString());
                            GastosIII.Add(pago["Numero_Factura"].ToString());
                            GastosIII.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            GastosIII.Add(pago["Numero_Retencion"].ToString());
                            GastosIII.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            GastosIII.Add(pago["Numero_Nota_Credito"].ToString());
                            GastosIII.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            GastosIII.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            GastosIII.Add(pago["Concepto"].ToString());

                            pGastosIII = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pGastosIII;

                            Abonos = Read.readAbonos(GastosIII[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pGastosIII -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pGastosIII -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                GastosIII[7] = pGastosIII.ToString("N2");
                                lblValCobGastosIII.Text = "Valor a Cobrar: " + GastosIII[7];
                            }

                            listas.Add(GastosIII.ToArray());

                            panelGastosIII.Visible = true;
                            break;

                        case "Gastos_IV":
                            lblEmpresaGastosIV.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaGastosIV.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobGastosIV.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            GastosIV.Add(pago["Empresa_Factura"].ToString());
                            GastosIV.Add(pago["Numero_Factura"].ToString());
                            GastosIV.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            GastosIV.Add(pago["Numero_Retencion"].ToString());
                            GastosIV.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            GastosIV.Add(pago["Numero_Nota_Credito"].ToString());
                            GastosIV.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            GastosIV.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            GastosIV.Add(pago["Concepto"].ToString());

                            pGastosIV = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pGastosIV;

                            Abonos = Read.readAbonos(GastosIV[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pGastosIV -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pGastosIV -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                GastosIV[7] = pGastosIV.ToString("N2");
                                lblValCobGastosIV.Text = "Valor a Cobrar: " + GastosIV[7];
                            }

                            listas.Add(GastosIV.ToArray());

                            panelGastosIV.Visible = true;
                            break;

                        case "Gastos_V":
                            lblEmpresaGastosV.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaGastosV.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobGastosV.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            GastosV.Add(pago["Empresa_Factura"].ToString());
                            GastosV.Add(pago["Numero_Factura"].ToString());
                            GastosV.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            GastosV.Add(pago["Numero_Retencion"].ToString());
                            GastosV.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            GastosV.Add(pago["Numero_Nota_Credito"].ToString());
                            GastosV.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            GastosV.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            GastosV.Add(pago["Concepto"].ToString());

                            pGastosV = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pGastosV;

                            Abonos = Read.readAbonos(GastosV[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pGastosV -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pGastosV -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                GastosV[7] = pGastosV.ToString("N2");
                                lblValCobGastosV.Text = "Valor a Cobrar: " + GastosV[7];
                            }


                            listas.Add(GastosV.ToArray());

                            panelGastosV.Visible = true;
                            break;

                        case "Honorarios_I":
                            lblEmpresaHonorariosI.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaHonorariosI.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobHonorariosI.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            HonorariosI.Add(pago["Empresa_Factura"].ToString());
                            HonorariosI.Add(pago["Numero_Factura"].ToString());
                            HonorariosI.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            HonorariosI.Add(pago["Numero_Retencion"].ToString());
                            HonorariosI.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            HonorariosI.Add(pago["Numero_Nota_Credito"].ToString());
                            HonorariosI.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            HonorariosI.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            HonorariosI.Add(pago["Concepto"].ToString());

                            pHonorariosI = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pHonorariosI;

                            Abonos = Read.readAbonos(HonorariosI[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pHonorariosI -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pHonorariosI -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                HonorariosI[7] = pHonorariosI.ToString("N2");
                                lblValCobHonorariosI.Text = "Valor a Cobrar: " + HonorariosI[7];
                            }


                            listas.Add(HonorariosI.ToArray());

                            panelHonorariosI.Visible = true;
                            break;

                        case "Honorarios_II":
                            lblEmpresaHonorariosII.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaHonorariosII.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobHonorariosII.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            HonorariosII.Add(pago["Empresa_Factura"].ToString());
                            HonorariosII.Add(pago["Numero_Factura"].ToString());
                            HonorariosII.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            HonorariosII.Add(pago["Numero_Retencion"].ToString());
                            HonorariosII.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            HonorariosII.Add(pago["Numero_Nota_Credito"].ToString());
                            HonorariosII.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            HonorariosII.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            HonorariosII.Add(pago["Concepto"].ToString());

                            pHonorariosII = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pHonorariosII;

                            Abonos = Read.readAbonos(HonorariosII[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pHonorariosII -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pHonorariosII -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                HonorariosII[7] = pHonorariosII.ToString("N2");
                                lblValCobHonorariosII.Text = "Valor a Cobrar: " + HonorariosII[7];
                            }


                            listas.Add(HonorariosII.ToArray());

                            panelHonorariosII.Visible = true;
                            break;


                        case "Honorarios_III":
                            lblEmpresaHonorariosIII.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaHonorariosIII.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobHonorariosIII.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            HonorariosIII.Add(pago["Empresa_Factura"].ToString());
                            HonorariosIII.Add(pago["Numero_Factura"].ToString());
                            HonorariosIII.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            HonorariosIII.Add(pago["Numero_Retencion"].ToString());
                            HonorariosIII.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            HonorariosIII.Add(pago["Numero_Nota_Credito"].ToString());
                            HonorariosIII.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            HonorariosIII.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            HonorariosIII.Add(pago["Concepto"].ToString());

                            pHonorariosIII = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pHonorariosIII;

                            Abonos = Read.readAbonos(HonorariosIII[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pHonorariosIII -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pHonorariosIII -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                HonorariosIII[7] = pHonorariosIII.ToString("N2");
                                lblValCobHonorariosIII.Text = "Valor a Cobrar: " + HonorariosIII[7];
                            }


                            listas.Add(HonorariosIII.ToArray());

                            panelHonorariosIII.Visible = true;
                            break;


                        case "Transporte_I":
                            lblEmpresaTransporteI.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaTransporteI.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobTransporteI.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            TransporteI.Add(pago["Empresa_Factura"].ToString());
                            TransporteI.Add(pago["Numero_Factura"].ToString());
                            TransporteI.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            TransporteI.Add(pago["Numero_Retencion"].ToString());
                            TransporteI.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            TransporteI.Add(pago["Numero_Nota_Credito"].ToString());
                            TransporteI.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            TransporteI.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            TransporteI.Add(pago["Concepto"].ToString());

                            pTransporteI = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pTransporteI;

                            Abonos = Read.readAbonos(TransporteI[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pTransporteI -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pTransporteI -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                TransporteI[7] = pTransporteI.ToString("N2");
                                lblValCobTransporteI.Text = "Valor a Cobrar: " + TransporteI[7];
                            }


                            listas.Add(TransporteI.ToArray());

                            panelTransporteI.Visible = true;
                            break;


                        case "Transporte_II":
                            lblEmpresaTransporteII.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaTransporteII.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobTransporteII.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            TransporteII.Add(pago["Empresa_Factura"].ToString());
                            TransporteII.Add(pago["Numero_Factura"].ToString());
                            TransporteII.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            TransporteII.Add(pago["Numero_Retencion"].ToString());
                            TransporteII.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            TransporteII.Add(pago["Numero_Nota_Credito"].ToString());
                            TransporteII.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            TransporteII.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            TransporteII.Add(pago["Concepto"].ToString());

                            pTransporteII = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pTransporteII;

                            Abonos = Read.readAbonos(TransporteII[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pTransporteII -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pTransporteII -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                TransporteII[7] = pTransporteII.ToString("N2");
                                lblValCobTransporteII.Text = "Valor a Cobrar: " + TransporteII[7];
                            }


                            listas.Add(TransporteII.ToArray());

                            panelTransporteII.Visible = true;
                            break;


                        case "Transporte_III":
                            lblEmpresaTransporteIII.Text = "Empresa: " + pago["Empresa_Factura"].ToString();
                            lblnFacturaTransporteIII.Text = "Número de Factura: " + pago["Numero_Factura"].ToString();
                            lblValCobTransporteIII.Text = "Valor a Cobrar: " + double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2");

                            TransporteIII.Add(pago["Empresa_Factura"].ToString());
                            TransporteIII.Add(pago["Numero_Factura"].ToString());
                            TransporteIII.Add(double.Parse(pago["TotalFactura"].ToString()).ToString("N2"));
                            TransporteIII.Add(pago["Numero_Retencion"].ToString());
                            TransporteIII.Add(double.Parse(pago["Total_Retencion"].ToString()).ToString("N2"));
                            TransporteIII.Add(pago["Numero_Nota_Credito"].ToString());
                            TransporteIII.Add(double.Parse(pago["Total_Nota_Credito"].ToString()).ToString("N2"));
                            TransporteIII.Add(double.Parse(pago["ValorACobrarFactura"].ToString()).ToString("N2"));

                            TransporteIII.Add(pago["Concepto"].ToString());

                            pTransporteIII = double.Parse(pago["ValorACobrarFactura"].ToString());
                            totalPagos += pTransporteIII;

                            Abonos = Read.readAbonos(TransporteIII[1]);

                            if (Abonos.Rows.Count > 0)
                            {
                                for (int i = 0; i < Abonos.Rows.Count; i++)
                                {
                                    pTransporteIII -= double.Parse(Abonos.Rows[i]["AbonoFactura"].ToString());
                                    //pTransporteIII -= double.Parse(Abonos.Rows[i]["PagoGeneral"].ToString());
                                }

                                TransporteIII[7] = pTransporteIII.ToString("N2");
                                lblValCobTransporteIII.Text = "Valor a Cobrar: " + TransporteIII[7];
                            }


                            listas.Add(TransporteIII.ToArray());

                            panelTransporteIII.Visible = true;
                            break;

                        default:
                            break;
                    }
                }

                switch (facturaSelecionada)
                {
                    case "Agente":
                        txtValorCobrar.Text = Agente[7];
                        break;
                    case "AgenteLDM":
                        txtValorCobrar.Text = AgenteLDM[7];
                        break;

                    case "TBC":
                        txtValorCobrar.Text = TBC[7];
                        break;

                    case "Transporte":
                        txtValorCobrar.Text = Transporte[7];
                        break;

                    case "GastosLocales":
                        txtValorCobrar.Text = GastosLocales[7];
                        break;

                    case "VistoTHC":
                        txtValorCobrar.Text = VistoTHC[7];
                        break;

                    case "RetiroBL":
                        txtValorCobrar.Text = RetiroBL[7];
                        break;

                    case "LiquidacionAduana":
                        txtValorCobrar.Text = LiquidacionAduana[7];
                        break;

                    case "RetiroGuia":
                        txtValorCobrar.Text = RetiroGuia[7];
                        break;

                    case "Demoraje":
                        txtValorCobrar.Text = Demoraje[7];
                        break;

                    case "ActualizacionCarta":
                        txtValorCobrar.Text = ActualizacionCarta[7];
                        break;

                    case "Almacenaje":
                        txtValorCobrar.Text = Almacenaje[7];
                        break;


                    case "DevContenedor":
                        txtValorCobrar.Text = DevContenedor[7];
                        break;

                    case "ManipContenedor":
                        txtValorCobrar.Text = ManipContenedor[7];
                        break;

                    case "GastosI":
                        txtValorCobrar.Text = GastosI[7];
                        break;

                    case "GastosII":
                        txtValorCobrar.Text = GastosII[7];
                        break;

                    case "GastosIII":
                        txtValorCobrar.Text = GastosIII[7];
                        break;

                    case "GastosIV":
                        txtValorCobrar.Text = GastosIV[7];
                        break;

                    case "GastosV":
                        txtValorCobrar.Text = GastosV[7];
                        break;

                    case "HonorariosI":
                        txtValorCobrar.Text = HonorariosI[7];
                        break;

                    case "HonorariosII":
                        txtValorCobrar.Text = HonorariosII[7];
                        break;

                    case "HonorariosIII":
                        txtValorCobrar.Text = HonorariosIII[7];
                        break;

                    case "TransporteI":
                        txtValorCobrar.Text = TransporteI[7];
                        break;

                    case "TransporteII":
                        txtValorCobrar.Text = TransporteII[7];
                        break;

                    case "TransporteIII":
                        txtValorCobrar.Text = TransporteIII[7];
                        break;


                    default:
                        break;
                }


                switch (facturaSelecionada)
                {
                    case "AgenteLDM":
                        lblDestinopago.Visible = true;
                        cmbDestinoPago.Visible = true;
                        break;

                    default:
                        lblDestinopago.Visible = false;
                        cmbDestinoPago.Visible = false;
                        break;
                }

                totPago = pAgente + pAgenteLDM + pTBC + pTransporte + pGastosLocales + pVistoTHC + pRetiroBL +
                           pLiquidacionAduana + pRetiroGuia + pDemoraje + pActualizacionCarta +
                           pAlmacenaje + pDevContenedor + pManipContenedor + pGastosI + pGastosII +
                           pGastosIII + pGastosIV + pGastosV + pHonorariosI + pHonorariosII + pHonorariosIII +
                           pTransporteI + pTransporteII + pTransporteIII;


                lblTotalaPagar.Text = "Saldo TBC:  $ " + totPago.ToString("N2");
                lblTotalCobrado.Text = "Cobrado:  $" + (totalPagos - totPago).ToString("N2");

                if (totalPagos != 0)
                {
                    porcentajePago.Value = (int)(100 - totPago / totalPagos * 100);
                }
                else
                {
                    porcentajePago.Value = 0;
                }
                if (cargarPagoGeneral)
                {
                    panelPagoGeneral.Visible = true;
                }


            }
            else
            {
                cerrarVentana = true;
            }
        }


        private void clearListas()
        {
            Agente.Clear();
            AgenteLDM.Clear();
            TBC.Clear();
            Transporte.Clear();
            GastosLocales.Clear();
            VistoTHC.Clear();
            RetiroBL.Clear();
            LiquidacionAduana.Clear();
            RetiroGuia.Clear();
            Demoraje.Clear();
            ActualizacionCarta.Clear();
            Almacenaje.Clear();
            DevContenedor.Clear();
            ManipContenedor.Clear();
            GastosI.Clear();
            GastosII.Clear();
            GastosIII.Clear();
            GastosIV.Clear();
            GastosV.Clear();
            HonorariosI.Clear();
            HonorariosII.Clear();
            HonorariosIII.Clear();
            TransporteI.Clear();
            TransporteII.Clear();
            TransporteIII.Clear();
        }





        private void FormCrearPago_Resize(object sender, EventArgs e)
        {
            acoplarPaneles();
        }

        private void txtAbonoPagoGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);


        }



        #region AjustesInterfaz

        #region fondoPanlees

        private void colorPanel(object sender)
        {
            if (checkListFacturas.CheckedItems.Count == 0)
            {
                Panel panel = sender as Panel;
                Panel panelIn = null;
                bool esPanelInterno = false;

                if (panel != null)
                {
                    foreach (Panel panelInterno in panelPagos.Controls)
                    {
                        foreach (var control in panelInterno.Controls)
                        {
                            if (control is Panel)
                            {
                                panelIn = control as Panel;
                                if (panel.Name == panelIn.Name)
                                {
                                    esPanelInterno = true;
                                }
                            }
                        }

                        if (panelInterno.Name == panel.Name || esPanelInterno)
                        {
                            panelInterno.BackColor = Color.FromArgb(50, 79, 115, 143);
                            esPanelInterno = false;
                        }
                        else
                        {
                            if (panelInterno.Name != "panelSeparador")
                            {
                                panelInterno.BackColor = Color.FromArgb(100, 33, 31, 41);
                            }
                        }
                    }
                }
            }
        }

        private void panelAgente_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelTBC_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelTranasporte_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelGastosLocales_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelVistoTHC_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelRetiroBL_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelLiqAduana_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelRetiroGuia_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);

        }

        private void panelDemoraje_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelActCarta_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelAlmacenaje_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelDevCont_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelManipuContenedor_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelGastosI_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelGastosII_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelGastosIII_Enter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelGastosIV_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelGastosV_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelHonorariosI_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelHonorariosII_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelHonorariosIII_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelTransporteI_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelTransporteII_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelTransporteIII_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }

        private void panelAgenteLDM_MouseEnter(object sender, EventArgs e)
        {
            colorPanel(sender);
        }


        #endregion

        #region CargarDatosInformacion

        private void clearFactura()
        {
            txtDetalleAbono.Text = "";
            txtAbonoFactura.Text = "";
            dateFactura.Value = DateTime.Now;
            BtnAgregarAbono.Visible = true;
        }

        string facturaSelecionada;
        private void panelAgente_Click(object sender, EventArgs e)
        {

            lblTituloInfoPagos.Text = "Agente";

            txtEmpresa.Text = Agente[0].ToString();
            txtnFactura.Text = Agente[1].ToString();
            txtTotalFactura.Text = Agente[2].ToString();
            txtnRetencion.Text = Agente[3].ToString();
            txtTotalRetencion.Text = Agente[4].ToString();
            txtnNotaCredito.Text = Agente[5].ToString();
            txtTotalNotaCredita.Text = Agente[6].ToString();
            txtValorCobrar.Text = Agente[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "Agente";

            readTramite();
            clearFactura();

        }

        private void panelAgenteLDM_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Agente LDM";

            txtEmpresa.Text = AgenteLDM[0].ToString();
            txtnFactura.Text = AgenteLDM[1].ToString();
            txtTotalFactura.Text = AgenteLDM[2].ToString();
            txtnRetencion.Text = AgenteLDM[3].ToString();
            txtTotalRetencion.Text = AgenteLDM[4].ToString();
            txtnNotaCredito.Text = AgenteLDM[5].ToString();
            txtTotalNotaCredita.Text = AgenteLDM[6].ToString();
            txtValorCobrar.Text = AgenteLDM[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "AgenteLDM";

            readTramite();
            clearFactura();
        }


        private void panelTBC_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "TBC";

            txtEmpresa.Text = TBC[0].ToString();
            txtnFactura.Text = TBC[1].ToString();
            txtTotalFactura.Text = TBC[2].ToString();
            txtnRetencion.Text = TBC[3].ToString();
            txtTotalRetencion.Text = TBC[4].ToString();
            txtnNotaCredito.Text = TBC[5].ToString();
            txtTotalNotaCredita.Text = TBC[6].ToString();
            txtValorCobrar.Text = TBC[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "TBC";

            readTramite();
            clearFactura();
        }

        private void lblTPTransporte_Click_1(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Transporte";

            txtEmpresa.Text = Transporte[0].ToString();
            txtnFactura.Text = Transporte[1].ToString();
            txtTotalFactura.Text = Transporte[2].ToString();
            txtnRetencion.Text = Transporte[3].ToString();
            txtTotalRetencion.Text = Transporte[4].ToString();
            txtnNotaCredito.Text = Transporte[5].ToString();
            txtTotalNotaCredita.Text = Transporte[6].ToString();
            txtValorCobrar.Text = Transporte[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "Transporte";

            readTramite();
            clearFactura();
        }

        private void panelGastosLocales_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Gastos Locales";

            txtEmpresa.Text = GastosLocales[0].ToString();
            txtnFactura.Text = GastosLocales[1].ToString();
            txtTotalFactura.Text = GastosLocales[2].ToString();
            txtnRetencion.Text = GastosLocales[3].ToString();
            txtTotalRetencion.Text = GastosLocales[4].ToString();
            txtnNotaCredito.Text = GastosLocales[5].ToString();
            txtTotalNotaCredita.Text = GastosLocales[6].ToString();
            txtValorCobrar.Text = GastosLocales[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "GastosLocales";

            readTramite();
            clearFactura();
        }



        private void panelVistoTHC_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Visto THC";

            txtEmpresa.Text = VistoTHC[0].ToString();
            txtnFactura.Text = VistoTHC[1].ToString();
            txtTotalFactura.Text = VistoTHC[2].ToString();
            txtnRetencion.Text = VistoTHC[3].ToString();
            txtTotalRetencion.Text = VistoTHC[4].ToString();
            txtnNotaCredito.Text = VistoTHC[5].ToString();
            txtTotalNotaCredita.Text = VistoTHC[6].ToString();
            txtValorCobrar.Text = VistoTHC[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "VistoTHC";

            readTramite();
            clearFactura();
        }

        private void panelRetiroBL_Click_1(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Retiro BL";

            txtEmpresa.Text = RetiroBL[0].ToString();
            txtnFactura.Text = RetiroBL[1].ToString();
            txtTotalFactura.Text = RetiroBL[2].ToString();
            txtnRetencion.Text = RetiroBL[3].ToString();
            txtTotalRetencion.Text = RetiroBL[4].ToString();
            txtnNotaCredito.Text = RetiroBL[5].ToString();
            txtTotalNotaCredita.Text = RetiroBL[6].ToString();
            txtValorCobrar.Text = RetiroBL[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "RetiroBL";

            readTramite();
            clearFactura();
        }


        private void panelLiquidacionAduana_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Liquidación Aduna";

            txtEmpresa.Text = LiquidacionAduana[0].ToString();
            txtnFactura.Text = LiquidacionAduana[1].ToString();
            txtTotalFactura.Text = LiquidacionAduana[2].ToString();
            txtnRetencion.Text = LiquidacionAduana[3].ToString();
            txtTotalRetencion.Text = LiquidacionAduana[4].ToString();
            txtnNotaCredito.Text = LiquidacionAduana[5].ToString();
            txtTotalNotaCredita.Text = LiquidacionAduana[6].ToString();
            txtValorCobrar.Text = LiquidacionAduana[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "LiquidacionAduana";

            readTramite();
            clearFactura();
        }

        private void panelRetiroGuía_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Retiro Guía";

            txtEmpresa.Text = RetiroGuia[0].ToString();
            txtnFactura.Text = RetiroGuia[1].ToString();
            txtTotalFactura.Text = RetiroGuia[2].ToString();
            txtnRetencion.Text = RetiroGuia[3].ToString();
            txtTotalRetencion.Text = RetiroGuia[4].ToString();
            txtnNotaCredito.Text = RetiroGuia[5].ToString();
            txtTotalNotaCredita.Text = RetiroGuia[6].ToString();
            txtValorCobrar.Text = RetiroGuia[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "RetiroGuia";

            readTramite();
            clearFactura();
        }

        private void panelDemoraje_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Demoraje";

            txtEmpresa.Text = Demoraje[0].ToString();
            txtnFactura.Text = Demoraje[1].ToString();
            txtTotalFactura.Text = Demoraje[2].ToString();
            txtnRetencion.Text = Demoraje[3].ToString();
            txtTotalRetencion.Text = Demoraje[4].ToString();
            txtnNotaCredito.Text = Demoraje[5].ToString();
            txtTotalNotaCredita.Text = Demoraje[6].ToString();
            txtValorCobrar.Text = Demoraje[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "Demoraje";

            readTramite();
            clearFactura();
        }

        private void panelActualizacionCarta_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Actualización Carta";

            txtEmpresa.Text = ActualizacionCarta[0].ToString();
            txtnFactura.Text = ActualizacionCarta[1].ToString();
            txtTotalFactura.Text = ActualizacionCarta[2].ToString();
            txtnRetencion.Text = ActualizacionCarta[3].ToString();
            txtTotalRetencion.Text = ActualizacionCarta[4].ToString();
            txtnNotaCredito.Text = ActualizacionCarta[5].ToString();
            txtTotalNotaCredita.Text = ActualizacionCarta[6].ToString();
            txtValorCobrar.Text = ActualizacionCarta[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "ActualizacionCarta";

            readTramite();
            clearFactura();
        }


        private void panelAlmacenaje_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Almacenaje";

            txtEmpresa.Text = Almacenaje[0].ToString();
            txtnFactura.Text = Almacenaje[1].ToString();
            txtTotalFactura.Text = Almacenaje[2].ToString();
            txtnRetencion.Text = Almacenaje[3].ToString();
            txtTotalRetencion.Text = Almacenaje[4].ToString();
            txtnNotaCredito.Text = Almacenaje[5].ToString();
            txtTotalNotaCredita.Text = Almacenaje[6].ToString();
            txtValorCobrar.Text = Almacenaje[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "Almacenaje";

            readTramite();
            clearFactura();
        }

        public bool cargarPagoGeneral = false;
        private void panelPagos_Resize(object sender, EventArgs e)
        {
            if (cargarPagoGeneral)
            {
                panelPagoGeneral.Width = panelPagos.Width - panelPagos.Width * 20 / 100;
            }
            panelInfoTramite.Width = panelPagos.Width - panelPagos.Width * 20 / 100;
        }

        private void panelDevolucionContenedor_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Devolución Contenedor";

            txtEmpresa.Text = DevContenedor[0].ToString();
            txtnFactura.Text = DevContenedor[1].ToString();
            txtTotalFactura.Text = DevContenedor[2].ToString();
            txtnRetencion.Text = DevContenedor[3].ToString();
            txtTotalRetencion.Text = DevContenedor[4].ToString();
            txtnNotaCredito.Text = DevContenedor[5].ToString();
            txtTotalNotaCredita.Text = DevContenedor[6].ToString();
            txtValorCobrar.Text = DevContenedor[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "DevContenedor";

            readTramite();
            clearFactura();
        }



        private void panelManipulacionContenedor_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = "Manipulación Contenedor";

            txtEmpresa.Text = ManipContenedor[0].ToString();
            txtnFactura.Text = ManipContenedor[1].ToString();
            txtTotalFactura.Text = ManipContenedor[2].ToString();
            txtnRetencion.Text = ManipContenedor[3].ToString();
            txtTotalRetencion.Text = ManipContenedor[4].ToString();
            txtnNotaCredito.Text = ManipContenedor[5].ToString();
            txtTotalNotaCredita.Text = ManipContenedor[6].ToString();
            txtValorCobrar.Text = ManipContenedor[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "ManipContenedor";

            readTramite();
            clearFactura();
        }


        double restante = 0;
        private void calcularSaldoAbono()
        {

            if (txtAbonoPagoGeneral.Text != "")
            {
                valorPagoGeneral = double.Parse(txtAbonoPagoGeneral.Text);
            }

            double abonados = 0;

            for (int i = 0; i < dataGridTipoFactura.Rows.Count; i++)
            {
                string t = dataGridTipoFactura.Rows[i].Cells["Valor"].Value.ToString();
                string[] array = t.Split('$');
                abonados += Convert.ToDouble(array[1]);
            }

            restante = valorPagoGeneral - abonados;
            lblSaldoAbono.Text = "Saldo Abono:   $" + restante.ToString("N2");
        }




        private void txtValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtValorPago.Text != "")
                {
                    double valor = Convert.ToDouble(txtValorPago.Text);


                    string[] array = lblTotalFacturas.Text.Split('$');
                    double valFactura = double.Parse(array[1]);

                    if (valor != valFactura)
                    {
                        if (valor < valFactura)
                        {
                            dataGridTipoFactura.Rows.Add(checkListFacturas.Text, "$ " + valor.ToString("N2"));
                            dataGridTipoFactura.Rows[dataGridTipoFactura.Rows.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(33, 31, 41);
                            dataGridTipoFactura.Rows[dataGridTipoFactura.Rows.Count - 1].Selected = false;


                            txtValorPago.Text = "";
                            txtValorPago.Enabled = false;
                            checkListFacturas.Enabled = true;
                            btnAbonoGeneral.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("El monto ingresado es superior al valor de la factura a pagar.\n" +
                                            "Por favor, ingrese un monto válido.\n",
                                            "Información",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);


                            checkListFacturas.SetItemCheckState(checkListFacturas.SelectedIndex, CheckState.Unchecked);

                            checkListFacturas.Enabled = true;
                            txtValorPago.Enabled = true;
                            btnAbonoGeneral.Enabled = true;

                            txtValorPago.Focus();

                        }

                    }
                    else
                    {
                        dataGridTipoFactura.Rows.Add(checkListFacturas.Text, "$ " + valor.ToString("N2"));


                        txtValorPago.Text = "";
                        txtValorPago.Enabled = false;
                        checkListFacturas.Enabled = true;
                        btnAbonoGeneral.Enabled = true;
                    }

                    calcularSaldoAbono();


                }
            }
        }


        //int indiceDataGrid = 0;
        private bool buscarTipoFactura(string tipoFactura)
        {
            foreach (DataGridViewRow row in dataGridTipoFactura.Rows)
            {
                if (tipoFactura == Convert.ToString(row.Cells["TipoFactura"].Value))
                {
                    return true;
                }
            }
            return false;
        }


        private int buscarIndice(string tipoFactura)
        {
            int j = 0;

            foreach (DataGridViewRow row in dataGridTipoFactura.Rows)
            {
                j++;

                if (tipoFactura == Convert.ToString(row.Cells["TipoFactura"].Value))
                {
                    return j - 1;
                }
            }
            return -1;
        }




        private double totalFacturas = 0;
        private bool agenteSeleccionado = false;
        private int items = 0, antItems = 0;
        private int iCheckedList = 0;

        private void checkListFacturas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!bloquearCheck)
            {
                antItems = items;
                items = checkListFacturas.CheckedItems.Count;


                // capturar la posicion de tabla 1 y tabla 2
                iCheckedList = checkListFacturas.SelectedIndex;

                // Busca si la factura ya fue ingresada

                if (buscarTipoFactura(checkListFacturas.Text))
                {
                    //MessageBox.Show("Si hay");
                    dataGridTipoFactura.Rows.RemoveAt(buscarIndice(checkListFacturas.Text));
                    checkListFacturas.SetItemChecked(iCheckedList, false);
                    checkListFacturas.Enabled = true;
                }
            }





            switch (checkListFacturas.Text)
            {
                case "Agente":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelAgente.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pAgente;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pAgente.ToString("N2");
                    }
                    else
                    {
                        panelAgente.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pAgente;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Agente_LDM":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelAgenteLDM.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pAgenteLDM;
                        lblDestinoPagoPG.Visible = true;
                        cmbDestinoPagoGL.Visible = true;
                        agenteSeleccionado = true;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pAgenteLDM.ToString("N2");
                    }
                    else
                    {
                        panelAgenteLDM.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas += pAgenteLDM;
                        agenteSeleccionado = false;
                        lblDestinoPagoPG.Visible = false;
                        cmbDestinoPagoGL.Visible = false;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "TBC":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelTBC.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pTBC;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pTBC.ToString("N2");

                    }
                    else
                    {
                        panelTBC.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pTBC;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Transporte":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelTransporte.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pTransporte;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pTransporte.ToString("N2");
                    }
                    else
                    {
                        panelTransporte.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pTransporte;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Gastos_Locales":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelGastosLocales.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pGastosLocales;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pGastosLocales.ToString("N2");
                    }
                    else
                    {
                        panelGastosLocales.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pGastosLocales;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Visto_THC":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelVistoTHC.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pVistoTHC;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pVistoTHC.ToString("N2");
                    }
                    else
                    {
                        panelVistoTHC.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pVistoTHC;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Retiro_BL":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelRetiroBL.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pRetiroBL;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pRetiroBL.ToString("N2");
                    }
                    else
                    {
                        panelRetiroBL.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pRetiroBL;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Liquidación_Aduana":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelLiquidacionAduana.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pLiquidacionAduana;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pLiquidacionAduana.ToString("N2");
                    }
                    else
                    {
                        panelLiquidacionAduana.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pLiquidacionAduana;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Retiro_Guía":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelRetiroGuía.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pRetiroGuia;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pRetiroGuia.ToString("N2");
                    }
                    else
                    {
                        panelRetiroGuía.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pRetiroGuia;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Demoraje":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelDemoraje.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pDemoraje;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pDemoraje.ToString("N2");
                    }
                    else
                    {
                        panelDemoraje.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pDemoraje;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Actualización_Carta":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelActualizacionCarta.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pActualizacionCarta;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pActualizacionCarta.ToString("N2");
                    }
                    else
                    {
                        panelActualizacionCarta.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pActualizacionCarta;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Almacenaje":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelAlmacenaje.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pAlmacenaje;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pAlmacenaje.ToString("N2");
                    }
                    else
                    {
                        panelAlmacenaje.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pAlmacenaje;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;


                case "Devolución_Contenedor":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelDevolucionContenedor.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pDevContenedor;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pDevContenedor.ToString("N2");
                    }
                    else
                    {
                        panelDevolucionContenedor.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pDevContenedor;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Manipulación_Contenedor":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelManipulacionContenedor.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pManipContenedor;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pManipContenedor.ToString("N2");
                    }
                    else
                    {
                        panelManipulacionContenedor.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pManipContenedor;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Gastos_I":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelGastosI.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pGastosI;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pGastosI.ToString("N2");
                    }
                    else
                    {
                        panelGastosI.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pGastosI;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Gastos_II":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelGastosII.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pGastosII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pGastosII.ToString("N2");
                    }
                    else
                    {
                        panelGastosII.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pGastosII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Gastos_III":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelGastosIII.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pGastosIII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pGastosIII.ToString("N2");
                    }
                    else
                    {
                        panelGastosIII.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pGastosIII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Gastos_IV":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelGastosIV.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pGastosIV;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pGastosIV.ToString("N2");
                    }
                    else
                    {
                        panelGastosIV.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pGastosIV;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Gastos_V":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelGastosV.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pGastosV;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pGastosV.ToString("N2");
                    }
                    else
                    {
                        panelGastosV.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pGastosV;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Honorarios_I":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelHonorariosI.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pHonorariosI;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pHonorariosI.ToString("N2");
                    }
                    else
                    {
                        panelHonorariosI.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pHonorariosI;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Honorarios_II":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelHonorariosII.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pHonorariosII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pHonorariosII.ToString("N2");
                    }
                    else
                    {
                        panelHonorariosII.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas += pHonorariosII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Honorarios_III":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelHonorariosIII.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pHonorariosIII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pHonorariosIII.ToString("N2");
                    }
                    else
                    {
                        panelHonorariosIII.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pHonorariosIII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Transporte_I":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelTransporteI.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pTransporteI;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pTransporteI.ToString("N2");
                    }
                    else
                    {
                        panelTransporteI.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pTransporteI;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Transporte_II":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelTransporteII.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pTransporteII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pTransporteII.ToString("N2");
                    }
                    else
                    {
                        panelTransporteII.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pTransporteII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                case "Transporte_III":
                    if (!checkListFacturas.GetItemChecked(e.Index))
                    {
                        panelTransporteIII.BackColor = Color.FromArgb(75, 205, 92, 92);
                        totalFacturas += pTransporteIII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + pTransporteIII.ToString("N2");
                    }
                    else
                    {
                        panelTransporteIII.BackColor = Color.FromArgb(100, 33, 31, 41);
                        totalFacturas -= pTransporteIII;
                        lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
                    }
                    break;

                default:
                    break;
            }

            if (checkListFacturas.Items.Count == 0)
            {
                lblTotalFacturas.Text = "Valor Factura:   $" + "0,00";
            }

            if (!bloquearCheck)
            {
                if (antItems != items || items == 0)
                {
                    txtValorPago.Enabled = true;
                    checkListFacturas.Enabled = false;
                    btnAbonoGeneral.Enabled = false;
                    txtValorPago.Focus();
                }
            }

            bloquearCheck = false;




            calcularSaldoAbono();


            // lblTotalFacturas.Text = "Total Facturas:   $" + totalFacturas.ToString("N2");

        }

        double valorPagoGeneral;
        bool bloquearEntrada = false;

        private void dataGridPagos_Resize(object sender, EventArgs e)
        {
            if (!bloquearEntrada)
            {
                try
                {
                    ajustarAnchoDatagrid();
                }
                catch
                {

                }

            }
            bloquearEntrada = false;
        }

        private void dataGridPagos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!bloquearEntrada)
            {
                try
                {
                    ajustarAnchoDatagrid();
                }
                catch
                {

                }
            }
            bloquearEntrada = false;
        }

        private void ajustarAnchoDatagrid()
        {
            int j = 0;

            for (int i = 0; i < dataGridPagos.Rows.Count; i++)
            {
                if (dataGridPagos.Rows[i].Cells["destinoPago"].Value.ToString() == "")
                {
                    j++;
                }
            }

            if (j == 0)
            {
                if (dataGridPagos.Columns.Count > 3)
                {
                    dataGridPagos.Columns[3].Visible = true;
                    dataGridPagos.Columns[0].Width = dataGridPagos.Width * 20 / 100;
                    dataGridPagos.Columns[1].Width = dataGridPagos.Width * 25 / 100;
                    dataGridPagos.Columns[2].Width = dataGridPagos.Width * 25 / 100;
                    dataGridPagos.Columns[3].Width = dataGridPagos.Width * 30 / 100;

                }
            }
            else
            {
                if (dataGridPagos.Columns.Count > 2)
                {
                    dataGridPagos.Columns[3].Visible = false;
                    dataGridPagos.Columns[0].Width = dataGridPagos.Width * 20 / 100;
                    dataGridPagos.Columns[1].Width = dataGridPagos.Width * 25 / 100;
                    dataGridPagos.Columns[2].Width = dataGridPagos.Width * 55 / 100;
                }
            }
        }


        private void panelGastosI_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = GastosI[8].ToString();

            txtEmpresa.Text = GastosI[0].ToString();
            txtnFactura.Text = GastosI[1].ToString();
            txtTotalFactura.Text = GastosI[2].ToString();
            txtnRetencion.Text = GastosI[3].ToString();
            txtTotalRetencion.Text = GastosI[4].ToString();
            txtnNotaCredito.Text = GastosI[5].ToString();
            txtTotalNotaCredita.Text = GastosI[6].ToString();
            txtValorCobrar.Text = GastosI[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "GastosI";
        }


        private void panelGastosII_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = GastosII[8].ToString();

            txtEmpresa.Text = GastosII[0].ToString();
            txtnFactura.Text = GastosII[1].ToString();
            txtTotalFactura.Text = GastosII[2].ToString();
            txtnRetencion.Text = GastosII[3].ToString();
            txtTotalRetencion.Text = GastosII[4].ToString();
            txtnNotaCredito.Text = GastosII[5].ToString();
            txtTotalNotaCredita.Text = GastosII[6].ToString();
            txtValorCobrar.Text = GastosII[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "GastosII";
        }

        private void panelGastosIII_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = GastosI[8].ToString();

            txtEmpresa.Text = GastosIII[0].ToString();
            txtnFactura.Text = GastosIII[1].ToString();
            txtTotalFactura.Text = GastosIII[2].ToString();
            txtnRetencion.Text = GastosIII[3].ToString();
            txtTotalRetencion.Text = GastosIII[4].ToString();
            txtnNotaCredito.Text = GastosIII[5].ToString();
            txtTotalNotaCredita.Text = GastosIII[6].ToString();
            txtValorCobrar.Text = GastosIII[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "GastosIII";
        }

        private void panelGastosIV_Click_1(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = GastosI[8].ToString();

            txtEmpresa.Text = GastosIV[0].ToString();
            txtnFactura.Text = GastosIV[1].ToString();
            txtTotalFactura.Text = GastosIV[2].ToString();
            txtnRetencion.Text = GastosIV[3].ToString();
            txtTotalRetencion.Text = GastosIV[4].ToString();
            txtnNotaCredito.Text = GastosIV[5].ToString();
            txtTotalNotaCredita.Text = GastosIV[6].ToString();
            txtValorCobrar.Text = GastosIV[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "GastosIV";
        }

        private void panelPagoGeneral_Click(object sender, EventArgs e)
        {
            if (panelPagoGeneral.Height == 71)
            {
                panelPagoGeneral.Height = 392;
            }
            else
            {
                panelPagoGeneral.Height = 71;
            }
        }

        private void dataGridPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double abono = double.Parse(dataGridPagos.Rows[dataGridPagos.CurrentCell.RowIndex].Cells[0].Value.ToString());
            DateTime fechaAbono = Convert.ToDateTime(dataGridPagos.Rows[dataGridPagos.CurrentCell.RowIndex].Cells[1].Value.ToString());
            string detalleAbono = dataGridPagos.Rows[dataGridPagos.CurrentCell.RowIndex].Cells[2].Value.ToString();

            txtAbonoFactura.Text = abono.ToString("N2");
            txtDetalleAbono.Text = detalleAbono;
            dateFactura.Value = fechaAbono;
            if (cmbDestinoPago.Visible)
            {
                cmbDestinoPago.Text = dataGridPagos.Rows[dataGridPagos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            }

            BtnAgregarAbono.Visible = false;
        }

        private void txtAbonoFactura_Enter(object sender, EventArgs e)
        {
            BtnAgregarAbono.Visible = true;
        }

        private void panelGastosV_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = GastosI[8].ToString();

            txtEmpresa.Text = GastosV[0].ToString();
            txtnFactura.Text = GastosV[1].ToString();
            txtTotalFactura.Text = GastosV[2].ToString();
            txtnRetencion.Text = GastosV[3].ToString();
            txtTotalRetencion.Text = GastosV[4].ToString();
            txtnNotaCredito.Text = GastosV[5].ToString();
            txtTotalNotaCredita.Text = GastosV[6].ToString();
            txtValorCobrar.Text = GastosV[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "GastosV";
        }



        private void panelHonorariosI_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = HonorariosI[8].ToString();

            txtEmpresa.Text = HonorariosI[0].ToString();
            txtnFactura.Text = HonorariosI[1].ToString();
            txtTotalFactura.Text = HonorariosI[2].ToString();
            txtnRetencion.Text = HonorariosI[3].ToString();
            txtTotalRetencion.Text = HonorariosI[4].ToString();
            txtnNotaCredito.Text = HonorariosI[5].ToString();
            txtTotalNotaCredita.Text = HonorariosI[6].ToString();
            txtValorCobrar.Text = HonorariosI[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "HonorariosI";
        }

        private void panelContenedorPagos_Resize(object sender, EventArgs e)
        {
            panelPagos.Width = panelContenedorPagos.Width;
        }

        private void PanelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHonorariosII_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = HonorariosII[8].ToString();

            txtEmpresa.Text = HonorariosII[0].ToString();
            txtnFactura.Text = HonorariosII[1].ToString();
            txtTotalFactura.Text = HonorariosII[2].ToString();
            txtnRetencion.Text = HonorariosII[3].ToString();
            txtTotalRetencion.Text = HonorariosII[4].ToString();
            txtnNotaCredito.Text = HonorariosII[5].ToString();
            txtTotalNotaCredita.Text = HonorariosII[6].ToString();
            txtValorCobrar.Text = HonorariosII[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "HonorariosII";
        }

        private void panelPagoCompleto_Resize(object sender, EventArgs e)
        {
            //panelPagoCompleto.Width = panelFondoDerecho.Width;
        }

        private void panelFondoDerecho_Resize(object sender, EventArgs e)
        {
            panelPagoCompleto.Width = panelFondoDerecho.Width;
            dataGridPagos.Width = panelPagoCompleto.Width - 20;

            if (panelInfoPago.Visible)
            {
                panelInfoPago.Width = panelPagoCompleto.Width - 20;
            }

            if (panelPagoGeneral.Visible)
            {
                panelPagoGeneral.Width = panelPagoCompleto.Width - 20;
            }
        }

        private void bunifuVScrollBar1_MouseEnter(object sender, EventArgs e)
        {
            bunifuVScrollBar1.ThumbColor = Color.FromArgb(50, 170, 170, 170);
        }

        private void bunifuVScrollBar1_MouseLeave(object sender, EventArgs e)
        {
            bunifuVScrollBar1.ThumbColor = Color.FromArgb(10, 41, 46, 54);
        }

        private void txtAbonoPagoGeneral_TextChanged(object sender, EventArgs e)
        {
            if (txtAbonoPagoGeneral.Text != "" && txtAbonoPagoGeneral.Text != ",")
            {
                if (Convert.ToDouble(txtAbonoPagoGeneral.Text) > 0)
                {
                    lblFacturas.Visible = true;
                    lineFacturas.Visible = true;
                    checkListFacturas.Visible = true;
                    lblTotalFacturas.Visible = true;
                    lineaTotalFacturas.Visible = true;
                    lblValor.Visible = true;
                    txtValorPago.Visible = true;
                    lblSaldoAbono.Visible = true;
                    btnAbonoGeneral.Visible = true;
                    lblPorPagar.Visible = true;
                    linePorPagar.Visible = true;
                    dataGridTipoFactura.Visible = true;

                }
                calcularSaldoAbono();
            }
            else
            {
                lblFacturas.Visible = false;
                lineFacturas.Visible = false;
                checkListFacturas.Visible = false;
                lblTotalFacturas.Visible = false;
                lineaTotalFacturas.Visible = false;
                lblValor.Visible = false;
                txtValorPago.Visible = false;
                lblSaldoAbono.Visible = false;
                btnAbonoGeneral.Visible = false;
                lblPorPagar.Visible = false;
                linePorPagar.Visible = false;
                dataGridTipoFactura.Visible = false;
            }
        }

        private void txtAbonoPagoGeneral_Leave(object sender, EventArgs e)
        {
            formatoAbonoPG();
        }

        double AbonoPG = 0;
        private void formatoAbonoPG()
        {
            if (txtAbonoPagoGeneral.Text != "")
            {
                AbonoPG = Convert.ToDouble(txtAbonoPagoGeneral.Text);
                txtAbonoPagoGeneral.Text = AbonoPG.ToString("N2");
            }
        }




        private void txtAbonoPagoGeneral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                formatoAbonoPG();
            }
        }




        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void panelHonorariosIII_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = HonorariosIII[8].ToString();

            txtEmpresa.Text = HonorariosIII[0].ToString();
            txtnFactura.Text = HonorariosIII[1].ToString();
            txtTotalFactura.Text = HonorariosIII[2].ToString();
            txtnRetencion.Text = HonorariosIII[3].ToString();
            txtTotalRetencion.Text = HonorariosIII[4].ToString();
            txtnNotaCredito.Text = HonorariosIII[5].ToString();
            txtTotalNotaCredita.Text = HonorariosIII[6].ToString();
            txtValorCobrar.Text = HonorariosIII[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "HonorariosIII";
        }

        private void panelTransporteI_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = TransporteI[8].ToString();

            txtEmpresa.Text = TransporteI[0].ToString();
            txtnFactura.Text = TransporteI[1].ToString();
            txtTotalFactura.Text = TransporteI[2].ToString();
            txtnRetencion.Text = TransporteI[3].ToString();
            txtTotalRetencion.Text = TransporteI[4].ToString();
            txtnNotaCredito.Text = TransporteI[5].ToString();
            txtTotalNotaCredita.Text = TransporteI[6].ToString();
            txtValorCobrar.Text = TransporteI[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "TransporteI";
        }

        private void lblSaldoCliente_Click(object sender, EventArgs e)
        {
            UserModel read = new UserModel();
            bloquearEntrada = true;

            DataTable dt = read.readTransferencia(PagosCache.idTramite);
            DataTable dtDev = read.readDevolucion(PagosCache.numeroTramite);
            DataTable dtSaldo = read.readTablaSaldoCliente(PagosCache.numeroTramite);

            if (dt.Rows.Count > 0)
            {
                dataGridPagos.DataSource = dt;
            }
            else if(dtDev.Rows.Count > 0)
            {
                dataGridPagos.DataSource = dtDev;   
            }
            else
            {
                dataGridPagos.DataSource = dtSaldo; 
            }

            lblAbonos.Text = "Historial";
        }

        bool pagarConTransferencia = false; 


        private void acoplarPagoGeneral()
        {
            if (PagosCache.tipoPago == "unico")
            {
                datePagoGeneral.Visible = false;
                panelInfoPago.Visible = false;
                panelTipoPago.RowStyles[0].Height = 0;
                cargarPagoGeneral = true;
                panelPagoGeneral.Width = panelInfoPago.Width;
                panelPagoGeneral.Visible = true;
                panelInfoTramite.Width = panelPagos.Width - panelPagos.Width * 20 / 100;

                datePagoGeneral.Visible = true;
                datePagoGeneral.Refresh();
                PagosCache.tipoPago = "multiple";
            }
        }

        private void acoplarInfoPago()
        {
            if (PagosCache.tipoPago == "multiple")
            {
                panelPagoGeneral.Visible = false;
                panelTipoPago.RowStyles[1].Height = 0;

                panelInfoPago.Width = panelPagoGeneral.Width;
                panelInfoPago.Visible = true;
                panelPagoGeneral.Width = panelPagos.Width - panelPagos.Width * 20 / 100;
                PagosCache.tipoPago = "unico";
            }
        }

        private void lblSaldoTransferencia_Click(object sender, EventArgs e)
        {
            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readPagoTransferencia(PagosCache.idTramite);

            lblAbonos.Text = "Historial";
        }

      

        private void lblPagoUnico_Click(object sender, EventArgs e)
        {
            acoplarInfoPago();
        }

    

        private void actionOnClicItem1()
        {
            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readPagoTransferencia(PagosCache.idTramite);
            lblAbonos.Text = "Historial";
        }

        private void actionOnClicItem2()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormDevolucionTransferencia formOpciones = new FormDevolucionTransferencia();
                formOpciones.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formOpciones.ValorSaldo = transferenciaHacia; 
                formPrincipal.AddOwnedForm(formOpciones);
                formPrincipal.AbrirFormInPanel(formOpciones);
            }
        }

        private void actionOnClicItem3()
        {
            pagarConTransferencia = true;
            txtAbonoPagoGeneral.Text = obtenerValorSaldo(lblSaldoTransferencia.Text);
            txtAbonoPagoGeneral.ReadOnly = true;

            if (PagosCache.tipoPago == "unico")
            {
                acoplarPagoGeneral();
            }
            txtAbonoPagoGeneral.Focus();
        }

        private void dataGridPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPagos.Rows.Count > 0)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (formPrincipal != null)
                {
                    FormEditarPago formEditarPago = new FormEditarPago();
                    formEditarPago.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formEditarPago);
                    formPrincipal.AbrirFormInPanel(formEditarPago);
                }
            }
        }

        private void lblSaldoTransferencia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                ToolStripMenuItem mi;

                // Item 1, null in constructor to say : no picture on the label
                mi = new ToolStripMenuItem("Historial", null, (s, a) => actionOnClicItem1());
                mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                mi.ForeColor = Color.White;
                menu.Items.Add(mi);

                // Separator
                //menu.Items.Add(new ToolStripSeparator());

                // Item 2
                if (transferenciaHacia > 0)
                {
                    mi = new ToolStripMenuItem("Devolver", null, (s, a) => actionOnClicItem2());
                    mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                    mi.ForeColor = Color.White;
                    menu.Items.Add(mi);

                // Item 3
                    mi = new ToolStripMenuItem("Pagar", null, (s, a) => actionOnClicItem3());
                    mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                    mi.ForeColor = Color.White;
                    menu.Items.Add(mi);
                }

                menu.BackColor = Color.FromArgb(100, 41, 46, 54);
                menu.Show(new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50));
            }
        }

        private void lblPagoMultiple_Click(object sender, EventArgs e)
        {
            acoplarPagoGeneral();
        }

        private string obtenerValorSaldo(string t)
        {
            string[] array = t.Split('$');
            return array[1];
        }

        private void panelTransporteII_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = TransporteII[8].ToString();

            txtEmpresa.Text = TransporteII[0].ToString();
            txtnFactura.Text = TransporteII[1].ToString();
            txtTotalFactura.Text = TransporteII[2].ToString();
            txtnRetencion.Text = TransporteII[3].ToString();
            txtTotalRetencion.Text = TransporteII[4].ToString();
            txtnNotaCredito.Text = TransporteII[5].ToString();
            txtTotalNotaCredita.Text = TransporteII[6].ToString();
            txtValorCobrar.Text = TransporteII[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "TransporteII";
        }

        private void panelTransporteIII_Click(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Text = TransporteIII[8].ToString();

            txtEmpresa.Text = TransporteIII[0].ToString();
            txtnFactura.Text = TransporteIII[1].ToString();
            txtTotalFactura.Text = TransporteIII[2].ToString();
            txtnRetencion.Text = TransporteIII[3].ToString();
            txtTotalRetencion.Text = TransporteIII[4].ToString();
            txtnNotaCredito.Text = TransporteIII[5].ToString();
            txtTotalNotaCredita.Text = TransporteIII[6].ToString();
            txtValorCobrar.Text = TransporteIII[7].ToString();

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);

            facturaSelecionada = "TransporteIII";
        }

        #endregion

        #endregion

        bool bloquearCheck = false;
        private void FormCrearPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                if (!checkListFacturas.Enabled)
                {
                    checkListFacturas.SetItemChecked(iCheckedList, false);
                    checkListFacturas.Enabled = true;
                    btnAbonoGeneral.Enabled = true; 
                }
            }


            if (e.KeyData == Keys.Delete)
            {
                if (dataGridTipoFactura.Focused)
                {
                    int indice = dataGridTipoFactura.CurrentCell.RowIndex;
                    string value = dataGridTipoFactura.Rows[indice].Cells[0].Value.ToString();

                    int index = GetItemIndex(value);
                    if (index != -1)
                    {
                        bloquearCheck = true;
                        checkListFacturas.SetItemChecked(index, false);
                    }

                    dataGridTipoFactura.Rows.RemoveAt(indice);
                    dataGridTipoFactura.Update();

                    calcularSaldoAbono();

                    txtValorPago.Enabled = true; 


                }
            }
        }

        private int GetItemIndex(string item)
        {
            UserModel Read = new UserModel();
            Pagos = Read.readPagos(PagosCache.numeroTramite);

            int index = 0; 

            foreach (DataRow o in Pagos.Rows)
            {
                if (item == o["Tipo_Factura"].ToString())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private void lblSaldoCliente_DoubleClick(object sender, EventArgs e)
        {
            if (saldCliente > 0)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (formPrincipal != null)
                {
                    FormOpcionesSaldoCliente formOpciones = new FormOpcionesSaldoCliente();
                    formOpciones.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formOpciones.ValorSaldo = saldCliente;
                    formOpciones.tramiteOrigen = txtIDTramite.Text; 
                    formPrincipal.AddOwnedForm(formOpciones);
                    formPrincipal.AbrirFormInPanel(formOpciones);
                }
            }
        }


        private void checkListFacturas_Leave(object sender, EventArgs e)
        {
            if (checkListFacturas.CheckedItems.Count > 0)
            {
                lineFacturas.BorderColor = Color.DimGray;
                lblFacturas.ForeColor = Color.FromArgb(170, 170, 170);
            }

        }
        private void FormCrearPago_Shown(object sender, EventArgs e)
        {
            UserModel Read = new UserModel();
            DataTable anticipo = Read.readAnticipo(PagosCache.numeroTramite);

            if (cerrarVentana)
            {
                if (anticipo.Rows.Count <= 3)
                {
                    DialogResult result = MessageBox.Show(
                    "El tramite: " + PagosCache.numeroTramite.ToString("D5") +
                    "\nNo tiene facturas registrados" +
                    "\n\nDesea agregar un anticipo al trámite ?",
                    "Info.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);



                    if (result == DialogResult.No)
                    {

                        result = MessageBox.Show(
                        "Desea agregar una factura al trámite?",
                        "Info",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            agregarFactura();
                        }
                        else
                        {
                            menuAnterior();
                        }

                    }
                    else
                    {

                        panelAnticipo.Visible = true;
                        panelInfoPago.Visible = false;
                        panelListaPagos.Visible = false;

                        dateAnticipo.Value = DateTime.Today;
                    }
                }
                else
                {
                    double totAnticipo = 0;

                    for (int i = 0; i < anticipo.Rows.Count; i++)
                    {
                        totAnticipo += double.Parse(anticipo.Rows[i]["Valor"].ToString());
                    }

                    DialogResult result = MessageBox.Show(
                                    "El tramite: " + PagosCache.numeroTramite.ToString("D5") +
                                    "\nRegistra un anticipo de " +
                                    totAnticipo.ToString("N2") +
                                    "\n\nPero no registra facturas, desea ingresar una factura?",
                                    "Info",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        agregarFactura();
                    }
                    else
                    {
                        menuAnterior();
                    }
                }


            }

            bunifuVScrollBar1.Maximum = panelPagos.VerticalScroll.Maximum;
            bunifuVScrollBar2.Maximum = panelPagoCompleto.VerticalScroll.Maximum;
            // MessageBox.Show("Maximo: "+ bunifuVScrollBar1.Maximum);
            bunifuVScrollBar1.ThumbLength = 80;
            bunifuVScrollBar2.ThumbLength = 40;
            InterfaceCache.idImportaciones = 4;

        }


        private void bunifuVScrollBar1_Scroll_1(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            panelPagos.AutoScrollPosition = new Point(panelPagos.AutoScrollPosition.X, e.Value);
        }


        private void bunifuVScrollBar2_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            panelPagoCompleto.AutoScrollPosition = new Point(panelPagoCompleto.AutoScrollPosition.X, e.Value);
        }


        private void HandleScroll()
        {
            //int x = System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
             //panelPagos.VerticalScroll.Maximum = bunifuVScrollBar1.Maximum;
            // bunifuVScrollBar1.Minimum = panelPagos.VerticalScroll.Minimum;
            //double val = (double)panelPagos.VerticalScroll.Value / panelPagos.VerticalScroll.Maximum * bunifuVScrollBar1.Maximum;
            
            bunifuVScrollBar1.Value = panelPagos.VerticalScroll.Value;
            bunifuVScrollBar2.Value = panelPagoCompleto.VerticalScroll.Value;


        }

        private void panelInfoPago_Resize(object sender, EventArgs e)
        {

            lblTituloInfoPagos.Left = (lblTituloInfoPagos.Parent.Width / 2) - (lblTituloInfoPagos.Width / 2);
            BtnAgregarAbono.Left = (BtnAgregarAbono.Parent.Width / 2) - (BtnAgregarAbono.Width / 2);
            //BtnAgregarAbono.Width = panelInfoPago.Width / 2;
            /*if (lblDestinopago.Visible)
            {
                lblDestinopago.Width = panelInfoPago.Width / 2;
                cmbDestinoPago.Width = panelInfoPago.Width / 2;
            }*/
        }

        private void panelTituloForm_Resize(object sender, EventArgs e)
        {
            lblTituloP.Left = (lblTituloP.Parent.Width / 2) - (lblTituloP.Width / 2);
        }

        private void lblTituloInfoPagos_TextChanged(object sender, EventArgs e)
        {
            lblTituloInfoPagos.Left = (lblTituloInfoPagos.Parent.Width / 2) - (lblTituloInfoPagos.Width / 2);
        }

        private void comprobarDecimal(object sender, KeyPressEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-EC");

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAbonoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }


        private void txtValAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void btnAnticipo_Click(object sender, EventArgs e)
        {
            if (txtValAnticipo.Text != "")
            {
                UserModel Write = new UserModel();
                string[] data = new string[5];

                double anticipo = double.Parse(txtValAnticipo.Text);

                DialogResult result = MessageBox.Show(
                                      "Seguro desea realizar el anticipo de " +
                                      double.Parse(txtValAnticipo.Text).ToString("N2") + 
                                      " al trámite " + 
                                      PagosCache.numeroTramite.ToString("D4"),
                                      "Info.",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Exclamation
                                      );
                
                if(result == DialogResult.Yes)
                {
                    data[0] = "Insert";
                    data[1] = PagosCache.numeroTramite.ToString();
                    data[2] = anticipo.ToString();
                    data[3] = txtDetalleAnticipo.Text;
                    data[4] = dateAnticipo.Value.ToString("yyyy-MM-dd");

                    if (Write.InsertDataAnticipo(data))
                    {
                        MessageBox.Show("El anticipo fue realizado exitosamente.");
                        menuAnterior();
                    }
                    else
                    {
                        MessageBox.Show("En estos momentos no se puede realizar el anticipo");
                        menuAnterior();
                    }

                }

            }
            else
            {
                MessageBox.Show(
                                "El valor del anticipo no puede estar vacío",
                                "Info.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation
                                );
            }
        }


        private void menuAnterior()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesPagos formOpcionesPagos = new FormOpcionesPagos();
                formOpcionesPagos.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesPagos);
                formPrincipal.AbrirFormInPanel(formOpcionesPagos);
            }
        }

        private void agregarFactura()
        {
            UserModel Read = new UserModel();
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearFactura formCrearFactura = new FormCrearFactura();

                formCrearFactura.txtBuscarTramite.Text = PagosCache.numeroTramite.ToString("D5");

                formCrearFactura.txtBuscarTramite.TextAlign = HorizontalAlignment.Center;
                using (Font font = new Font("Century Gothic", 14.0f)) formCrearFactura.txtBuscarTramite.Font = font;
                formCrearFactura.txtBuscarTramite.ForeColor = Color.White;
                formCrearFactura.txtBuscarTramite.Enabled = false;


                Read.searchRetenciones(TramiteCache.rucEmpresa);

                List<string> tipoFactura = new List<string>();
                List<string> tipoFacturaOtros = new List<string>();

                string[] array = Read.readTipoFactura(PagosCache.numeroTramite).ToArray();
                int indice = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == "Otros")
                    {
                        indice = i;
                        break;
                    }
                }

                for (int i = 0; i <= indice; i++)
                {
                    tipoFactura.Add(array[i]);
                }

                for (int i = indice + 1; i < array.Length; i++)
                {
                    tipoFacturaOtros.Add(array[i]);
                }

                formCrearFactura.cmbTipoFactura.DataSource = tipoFactura;
                formCrearFactura.cmbOtros.DataSource = tipoFacturaOtros;


                formCrearFactura.readRetenciones();
                formCrearFactura.buscarEstaAbierta = false;

                formCrearFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formCrearFactura);
                formPrincipal.AbrirFormInPanel(formCrearFactura);
            }
        }


        private void BtnAgregarAbono_Click(object sender, EventArgs e)
        {
            if (txtAbonoFactura.Text != "")
            {
                if (txtnFactura.Text != "")
                {
                    UserModel Write = new UserModel();

                    string[] data = new string[8];
                    
                    double abono = double.Parse(txtAbonoFactura.Text);
                    double valorAPagar = double.Parse(txtValorCobrar.Text);

                    DialogResult result = MessageBox.Show(
                                          "Seguro desea abonar la factura "+ txtnFactura.Text + " ?",
                                          "",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Exclamation
                                          );

                    if (result == DialogResult.Yes)
                    {
                        bool estadoDestinoPago = false ; 

                        if (lblDestinopago.Visible)
                        {
                            if (cmbDestinoPago.Text != "")
                            {
                                estadoDestinoPago = false;
                            }
                            else
                            {
                                estadoDestinoPago = true;
                                MessageBox.Show("Por favor ingrese el destino pago");
                                cmbDestinoPago.Focus();
                            }
                        }

                        if (!estadoDestinoPago)
                        {
                            if (abono <= valorAPagar)
                            {
                                data[0] = "Insert";
                                data[1] = "0";
                                data[2] = "0";
                                data[3] = abono.ToString();
                                data[4] = dateFactura.Value.ToString("yyyy-MM-dd");
                                data[5] = txtDetalleAbono.Text;
                                data[6] = txtnFactura.Text;

                                if (facturaSelecionada == "Agente")
                                {
                                    data[7] = cmbDestinoPago.Text;
                                }
                                else
                                {
                                    data[7] = "";
                                }


                                if (Write.InsertDataPago(data))
                                {
                                    MessageBox.Show("El abono fue realizado exitosamente.");
                                    readTramite();

                                    txtAbonoFactura.Text = "";
                                    txtDetalleAbono.Text = "";


                                    UserModel read = new UserModel();
                                    dataGridPagos.DataSource = read.readAbonoFactura(txtnFactura.Text);
                                }
                                else
                                {
                                    MessageBox.Show("FALLO");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El abono supera el monto de la factura", "Error");
                            }
                        }

                        
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione la factura a abonar");
                }
            }
        }


        private double buscarValorDG(string TipoFactura)
        {
            foreach (DataGridViewRow row in dataGridTipoFactura.Rows)
            {
                if (TipoFactura == Convert.ToString(row.Cells["TipoFactura"].Value))
                {
                    string t = row.Cells["Valor"].Value.ToString();
                    string[] array = t.Split('$');
                    return Convert.ToDouble(array[1]);
                }
            }
            return -1; 
        }


        List<string[]> listas = new List<string[]>();

        double saldCliente = 0;
        bool falloPago = false; 

        private void btnAbonoGeneral_Click(object sender, EventArgs e)
        {

            AbonoPG = Math.Round(AbonoPG, 2);       // Valor del abono general
            totPago = Math.Round(totPago, 2);       // Suma de todas las facturas 
            restante = Math.Round(restante, 2);     // Lo que se carga a saldo cliente 

            if (restante >= 0)
            {
                if (checkListFacturas.CheckedItems.Count > 0)
                {
                    if (AbonoPG > 0)
                    {


                        UserModel Write = new UserModel();
                        string[] data = new string[8];



                        if (agenteSeleccionado && cmbDestinoPagoGL.Text == "")
                        {
                            MessageBox.Show("Ha seleccioado un pago al Agente LDM.\n" +
                                            "Se necesita ingresar el destino pago.\n",
                                            "Ingreso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            lblDestinoPagoPG.ForeColor = Color.FromArgb(187, 42, 89);
                            cmbDestinoPagoGL.Focus();
                        }
                        else
                        {
                            for (int i = 0; i < listas.Count; i++)
                            {
                                if (AbonoPG > 0)
                                {
                                    foreach (var item in checkListFacturas.CheckedItems)
                                    {
                                        var row = (item as DataRowView).Row;
                                        string idF = row.Field<string>("Tipo_Factura");
                                        double valCob = row.Field<double>("ValorACobrarFactura");
                                        string nFactura = row.Field<string>("Numero_Factura");

                                        if (nFactura == listas[i][1].ToString())
                                        {
                                            double valorFactura = Math.Round(Double.Parse(listas[i][7].ToString()), 2);         // Valor de la factura 
                                            if (valorFactura > 0)
                                            {
                                                if (AbonoPG > valorFactura)
                                                {
                                                    // Algoritmo de busqueda 
                                                    AbonoPG -= valorFactura;
                                                }
                                                else
                                                {
                                                    AbonoPG = 0;
                                                }


                                                data[0] = "Insert";
                                                data[1] = "0";
                                                data[2] = txtAbonoPagoGeneral.Text;
                                                data[3] = Math.Round(buscarValorDG(idF), 2).ToString("N2");                // Aqui tengo que abonar el valor que esta en el DataGrid
                                                data[4] = datePagoGeneral.Value.ToString("yyyy-MM-dd");
                                                data[5] = txtDetallePagoGeneral.Text +" "+ txtAbonoPagoGeneral.Text + " " + datePagoGeneral.Value.ToString("yyyy-MM-dd") + " "+ DateTime.Now.ToString("HH:mm");
                                                data[6] = listas[i][1].ToString();

                                                if (idF == "Agente_LDM")
                                                {
                                                    data[7] = cmbDestinoPagoGL.Text;
                                                }
                                                else
                                                {
                                                    data[7] = "";
                                                }


                                                if (Write.InsertDataPago(data))
                                                {
                                                    readTramite();
                                                }
                                                else
                                                {
                                                    falloPago = true; 
                                                    MessageBox.Show("Falló el pago a la factura: " + nFactura);
                                                }
                                               
                                                if (pagarConTransferencia)
                                                {
                                                    string[] dataPT = new string[5];
                                                    dataPT[0] = "Insert";
                                                    dataPT[1] = "0";
                                                    dataPT[2] = Math.Round(buscarValorDG(idF), 2).ToString("N2"); 
                                                    dataPT[3] = datePagoGeneral.Value.ToString("yyyy-MM-dd");
                                                    dataPT[4] = PagosCache.idTramite;

                                                    Write.InsertDataPT(dataPT);
                                                }

                                                break;
                                            }
                                            else
                                            {
                                                MessageBox.Show("La factura " + nFactura + " ya se encuentra pagada");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Pago: " + saldCliente.ToString());
                                    break;
                                }
                            }
                            if (restante > 0 && !pagarConTransferencia)
                            {
                                //Saldo clientes
                                string[] dataSaldo = new string[5];

                                dataSaldo[0] = "Insert";
                                dataSaldo[1] = "0";
                                dataSaldo[2] = restante.ToString("N2");
                                dataSaldo[3] = datePagoGeneral.Value.ToString("yyyy-MM-dd");
                                dataSaldo[4] = PagosCache.numeroTramite.ToString();

                                Write.InsertDataSaldo(dataSaldo);

                                saldCliente = Write.saldoTramite(PagosCache.numeroTramite);
                                readTramite();
                            }


                            bool state = false;

                            for (int i = 0; i < checkListFacturas.Items.Count; i++)
                                checkListFacturas.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));

                            dataGridTipoFactura.Rows.Clear();

                            checkListFacturas.Enabled = true;
                            txtValorPago.Enabled = true;
                            btnAbonoGeneral.Enabled = true;

                            txtValorPago.Focus();

                            totalFacturas = 0;
                            lblTotalFacturas.Text = "Total Facturas:   $" + totalFacturas.ToString("N2");
                            
                            if (!falloPago)
                            {
                                MessageBox.Show("Todos los pagos se han realizado exitosamente.\n",
                                                "Información",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Uno o más abonos no han sido procesados.\n"+
                                                "Por favor revise el estado de los abonos.\n",
                                                "Información",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                falloPago = false; 
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("error");

                    }
                }
                else
                {
                    MessageBox.Show(
                                        "Por favor, elija las facturas a pagar",
                                        "Info",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    lineFacturas.BorderColor = Color.FromArgb(205, 92, 92);
                    lblFacturas.ForeColor = Color.FromArgb(205, 92, 92);
                }
            }
            else
            {
                MessageBox.Show("El valor del abono ($ "+ txtAbonoPagoGeneral.Text + ")\nNo es suficiente para cancelar el valor total" +
                    "de las facturas selecionadas, hace falta $ " + (-1*restante).ToString("N2") +" para realizar el abono.\n" +
                "\nPor favor, revise los valores a pagar.",
                "Ingreso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            readSaldo();
        }  
    }
}
