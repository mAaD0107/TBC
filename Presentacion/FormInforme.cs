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

            this.reportViewer1.RefreshReport();
        }

        private void getListaFacturas()
        {
            InformeFacturas informeFacturas = new InformeFacturas();
            informeFacturas.crearInformeFacturas(6);

            InformeFacturasBindingSource.DataSource = informeFacturas;
            ListadoFacturasBindingSource.DataSource = informeFacturas.listadoFacturas;

            this.reportViewer1.RefreshReport();
        }
    }
}
