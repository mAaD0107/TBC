using Common.Cache;
using Domain;
using System;
using System.Globalization;
using System.Threading;
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
            loadScreen();
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
            if (celda != celdaAnterior && celda != null && celda != "")
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dataGridPagos.CurrentCell.RowIndex;
            string idPago = dataGridPagos.Rows[index].Cells[0].Value.ToString();
            string nFactura = dataGridPagos.Rows[index].Cells[1].Value.ToString();
            string value = string.Format("{0:C2}", dataGridPagos.Rows[index].Cells[3].Value);
            string asiento = dataGridPagos.Rows[index].Cells[4].Value.ToString();
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el pago de la factura: " +
                "\nNúmero: " + nFactura +
                "\nAbono: " + value +
                "\nAsiento: " + asiento
                , "Advertencia", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);

            if(result == DialogResult.OK)
            {
                UserModel write = new UserModel();

                if (write.deletePago(idPago))
                {
                    MessageBox.Show("Se elimino el pago de la factura numero: " + nFactura, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadScreen();
            }
        }

        private void loadScreen()
        {
            txtDAI.Text = PagosCache.DAI;
            txtSecuencialCliente.Text = PagosCache.secuencialCliente;
            txtCliente.Text = PagosCache.Empresa;
            txtTramite.Text = PagosCache.idTramite;

            UserModel read = new UserModel();
            dataGridPagos.DataSource = read.readListaPagos(PagosCache.idTramite);

            dataGridPagos.Columns[0].Visible = false;
            dataGridPagos.Columns[1].ReadOnly = true;
            dataGridPagos.Columns[2].ReadOnly = true;

            dataGridPagos.Width = 920;

            vScrollBar.Minimum = panelContenedor.VerticalScroll.Minimum;
            vScrollBar.Maximum = panelContenedor.VerticalScroll.Maximum;

            panelContenedor.Dock = DockStyle.Fill;
        }
    }
}
