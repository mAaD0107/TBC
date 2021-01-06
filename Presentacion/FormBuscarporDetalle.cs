using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentacion
{
    public partial class FormBuscarporDetalle : Form
    {
        public FormBuscarporDetalle()
        {
            InitializeComponent();
        }

        private void FormBuscarporDetalle_Load(object sender, EventArgs e)
        {
            showFacturas();
        }

        private void dataGridDetalles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showFacturas();
            }
        }

        private void showFacturas()
        {
            UserModel Read = new UserModel();
            dataGridDetalles.DataSource = Read.readInfoFacturasT();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchFacturas();
            }
        }

        private void searchFacturas()
        {
            UserModel Read = new UserModel();
            dataGridDetalles.DataSource = Read.readInfoFacturasTB(txtBuscar.Text);
        }
    }
}
