using System;
using System.Windows.Forms;
using Domain.Carta;
using Common.Cache;
using Microsoft.Reporting.WinForms;

namespace Presentacion
{
    public partial class FormInformeCarta : Form
    {
        public FormInformeCarta()
        {
            InitializeComponent();
        }

        private void FormInformeCarta_Load(object sender, EventArgs e)
        {
            getCarta();
        }

        private void getCarta()
        {
            InformeCarta informeCarta = new InformeCarta();
            informeCarta.CrearInformeCarta(FacturaCache.ID_Tramite);
            
            InformeCartaBindingSource.DataSource = informeCarta;
            AbonosFacturasBindingSource.DataSource = informeCarta.listadoAbono;
            ListadoFacturasBindingSource.DataSource = informeCarta.listadoFacturas;
            DevolucionSaldoBindingSource.DataSource = informeCarta.listadoDevoluciones;
            TransferenciaOrigenBindingSource.DataSource = informeCarta.listadoTransferenciaOrigen;
            TransferenciaDestinoBindingSource.DataSource = informeCarta.listadoTransferenciaDestino;
            
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("NCVisible", "TRUE");
            if (CartaCache.TipoCarta == "SIN LOGO")
            {
                parameters[1] = new ReportParameter("Fondo", "FALSE");
            }
            else
            {
                parameters[1] = new ReportParameter("Fondo", "TRUE");
            }
            

            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
