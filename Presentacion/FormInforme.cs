using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Facturacion;
using Domain.Carta;
using Common.Cache;

namespace Presentacion
{
    public partial class FormInforme : Form
    {
        public FormInforme()
        {
            InitializeComponent();
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            getListaFacturas();
        }

        private void getListaFacturas()
        {
            InformeFacturas informeFacturas = new InformeFacturas();
            InformeCarta informeCarta = new InformeCarta();
           
            informeFacturas.crearInformeFacturas(6);
            informeCarta.CrearInformeCarta(FacturaCache.ID_Tramite);

            InformeCartaBindingSource.DataSource = informeCarta;
            InformeFacturasBindingSource.DataSource = informeFacturas;
            ListadoFacturasBindingSource.DataSource = informeFacturas.listadoFacturas;
            
            

            this.reportViewer1.RefreshReport();
        }
    }
}
