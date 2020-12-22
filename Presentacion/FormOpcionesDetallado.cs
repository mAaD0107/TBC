using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormOpcionesDetallado : Form
    {
        public FormOpcionesDetallado()
        {
            InitializeComponent();
        }

        private void FormOpcionesDetallado_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        private void panelGeneral_Enter(object sender, EventArgs e)
        {
            lblCliente.ForeColor = Color.FromArgb(185, 209, 234);
            lblProveedor.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);

            btnCliente.Focus();
        }

        private void panelDetallado_Enter(object sender, EventArgs e)
        {
            lblCliente.ForeColor = Color.FromArgb(57, 60, 67);
            lblProveedor.ForeColor = Color.FromArgb(185, 209, 234);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);

            btnProveedor.Focus();
        }

        private void panelFactura_Enter(object sender, EventArgs e)
        {
            lblCliente.ForeColor = Color.FromArgb(57, 60, 67);
            lblProveedor.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(185, 209, 234);

            btnFactura.Focus();
        }

        private void panelCliente_Click(object sender, EventArgs e)
        {

        }

        private void panelProveedor_Click(object sender, EventArgs e)
        {

        }

        private void panelFactura_Click(object sender, EventArgs e)
        {

        }

        private void FormOpcionesDetallado_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 10;
        }
    }
}
