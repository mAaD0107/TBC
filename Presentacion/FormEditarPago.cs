using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEditarPago : Form
    {
        public FormEditarPago()
        {
            InitializeComponent();

            this.panelContenedor.MouseWheel += new MouseEventHandler(panelScroll);
        }

        private void FormEditarPago_Load(object sender, EventArgs e)
        {
            txtDAI.Text = PagosCache.DAI;
            txtSecuencialCliente.Text = PagosCache.secuencialCliente;
            txtCliente.Text = PagosCache.Empresa;
            txtTramite.Text = PagosCache.idTramite;

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readListaPagos(PagosCache.idTramite);

            dataGridPagos.Columns[0].Visible = false;
            dataGridPagos.Columns[1].ReadOnly = true;

            dataGridPagos.Width = 920;

            vScrollBar.Minimum = panelContenedor.VerticalScroll.Minimum;
            vScrollBar.Maximum = panelContenedor.VerticalScroll.Maximum;

            panelContenedor.Dock = DockStyle.Fill;
        }

        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            panelContenedor.VerticalScroll.Value = e.Value;
        }

        private void panelScroll(object sender, MouseEventArgs e)
        {
            panelContenedor.Focus();
            vScrollBar.Value = panelContenedor.VerticalScroll.Value;
        }


        private void dataGridPagos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String celdaAnterior = dataGridPagos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (celda != celdaAnterior)
            {
                UserModel Write = new UserModel();
                string[] data = new string[8];

                data[0] = "Update";
                data[1] = dataGridPagos.Rows[e.RowIndex].Cells[0].Value.ToString();
                data[2] = dataGridPagos.Rows[e.RowIndex].Cells[2].Value.ToString();
                data[3] = dataGridPagos.Rows[e.RowIndex].Cells[3].Value.ToString();
                data[4] = Convert.ToDateTime(dataGridPagos.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString("yyyy-MM-dd");
                data[5] = dataGridPagos.Rows[e.RowIndex].Cells[4].Value.ToString();
                data[6] = dataGridPagos.Rows[e.RowIndex].Cells[1].Value.ToString();
                data[7] = dataGridPagos.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (Write.InsertDataPago(data))
                {
                    MessageBox.Show("El valor fue editado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo editar el Pago");
                    dataGridPagos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = celda;
                }
                
            }

        }

        private void dataGridPagos_Resize(object sender, EventArgs e)
        {
            dataGridPagos.Columns[1].Width = dataGridPagos.Width * 20 / 100;
            dataGridPagos.Columns[2].Width = dataGridPagos.Width * 10 / 100;
            dataGridPagos.Columns[3].Width = dataGridPagos.Width * 10 / 100;
            dataGridPagos.Columns[4].Width = dataGridPagos.Width * 40 / 100;
            dataGridPagos.Columns[5].Width = dataGridPagos.Width * 10 / 100;
            dataGridPagos.Columns[6].Width = dataGridPagos.Width * 10 / 100;
        }

        String celda;

        private void dataGridPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = dataGridPagos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void comprobarNumero(object sender, KeyPressEventArgs e)
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

        private void dataGridPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            int col = dataGridPagos.CurrentCell.ColumnIndex;
            int fila = dataGridPagos.CurrentRow.Index;
            if (col == 2 || col == 3)
            {
                comprobarNumero(sender, e);
            }
        }

        private void FormEditarPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                callCrearPago();
            }
        }

        private void callCrearPago()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormCrearPago formCrearPago = new FormCrearPago();
                formCrearPago.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formCrearPago.panelInfoPago.Visible = true;
                formCrearPago.panelTipoPago.RowStyles[1].Height = 0;
                formPrincipal.AddOwnedForm(formCrearPago);
                formPrincipal.AbrirFormInPanel(formCrearPago);
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            callCrearPago();
        }

        private void dataGridPagos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            celda = dataGridPagos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
}
