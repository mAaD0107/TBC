using Common.Cache;
using Domain;
using System;
using System.Drawing;
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
            loadTablePagos();
            loadTablaSaldoCliente();
            loadTablaTransferenciaSaldo();
            vScrollBar.Minimum = panelContenedor.VerticalScroll.Minimum;
            vScrollBar.Maximum = panelContenedor.VerticalScroll.Maximum;

            panelContenedor.Dock = DockStyle.Fill;
        }

        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            //panelContenedor.VerticalScroll.Value = e.Value;
            panelContenedor.AutoScrollPosition = new Point(panelContenedor.AutoScrollPosition.X, e.Value);
        }

        private void panelScroll(object sender, MouseEventArgs e)
        {
            panelContenedor.Focus();
            vScrollBar.Value = panelContenedor.VerticalScroll.Value;
        }


        private void dataGridPagos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string celdaAnterior = dataGridPagos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (celda != celdaAnterior && celda != null && celda != "")
            {

               DialogResult result = MessageBox.Show("Desea actualizar los pagos?", "Advertencia",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
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
                } else if(result == DialogResult.Cancel || result == DialogResult.No)
                {
                    BeginInvoke(new MethodInvoker(() => {
                        loadTablePagos();
                    }));
                }

                
            }

        }

        private void dataGridPagos_Resize(object sender, EventArgs e)
        {
            try
            {
                dataGridPagos.Columns[1].Width = dataGridPagos.Width * 20 / 100;
                dataGridPagos.Columns[2].Width = dataGridPagos.Width * 10 / 100;
                dataGridPagos.Columns[3].Width = dataGridPagos.Width * 10 / 100;
                dataGridPagos.Columns[4].Width = dataGridPagos.Width * 40 / 100;
                dataGridPagos.Columns[5].Width = dataGridPagos.Width * 10 / 100;
                dataGridPagos.Columns[6].Width = dataGridPagos.Width * 10 / 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }

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
                loadTablePagos();
            }
        }

        private void loadTablePagos()
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

            if (dataGridPagos.RowCount == 0) {
                panelSaldoCliente.Visible = false;
            }
        }

        private void loadTablaSaldoCliente()
        {
            UserModel read = new UserModel();
            dataGridSaldoCliente.DataSource = read.readListaSaldoCliente(PagosCache.numeroTramite.ToString());

            dataGridSaldoCliente.Columns[0].Visible = false;
            dataGridSaldoCliente.Columns[3].Visible = false;

            dataGridSaldoCliente.Width = 920;


            if (dataGridSaldoCliente.RowCount == 0)
            {
                panelSaldoCliente.Visible = false;
            }

        }

        private void loadTablaTransferenciaSaldo()
        {
            UserModel read = new UserModel();
            dataGridTransferenciaSaldo.DataSource = read.readTransferencias(PagosCache.idTramite);

            dataGridTransferenciaSaldo.Columns[0].Visible = false;
            dataGridTransferenciaSaldo.Columns[6].Visible = false;

            dataGridTransferenciaSaldo.Columns[3].ReadOnly = true;
            dataGridTransferenciaSaldo.Columns[4].ReadOnly = true;
            dataGridTransferenciaSaldo.Width = 920;

            if (dataGridTransferenciaSaldo.RowCount == 0)
            {
                panelTransferencia.Visible = false;
            }

        }



        string celdaSaldo;
        private void dataGridSaldoCliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            celdaSaldo = dataGridSaldoCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridSaldoCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaSaldo = dataGridSaldoCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridSaldoCliente_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string celdaAnterior = dataGridSaldoCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (celdaSaldo != celdaAnterior)
            {

                DialogResult result = MessageBox.Show("Desea actualizar el saldo cliente?", "Advertencia",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    UserModel Write = new UserModel();
                    string[] data = new string[5];

                    data[0] = "Update";
                    data[1] = dataGridSaldoCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data[2] = dataGridSaldoCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data[3] = Convert.ToDateTime(dataGridSaldoCliente.Rows[e.RowIndex].Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                    data[4] = dataGridSaldoCliente.Rows[e.RowIndex].Cells[3].Value.ToString();

                    if (Write.InsertDataSaldo(data))
                    {
                        MessageBox.Show("El saldo cliente fue editado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el saldo cliente");
                    }
                }
                else if (result == DialogResult.Cancel || result == DialogResult.No)
                {
                    BeginInvoke(new MethodInvoker(() => {
                        loadTablaSaldoCliente();
                    }));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridSaldoCliente.CurrentCell.RowIndex;

            string[] data = new string[5];
            data[0] = "Delete";
            data[1] = dataGridSaldoCliente.Rows[index].Cells[0].Value.ToString();
            data[2] = dataGridSaldoCliente.Rows[index].Cells[1].Value.ToString();
            data[3] = Convert.ToDateTime(dataGridSaldoCliente.Rows[index].Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
            data[4] = dataGridSaldoCliente.Rows[index].Cells[3].Value.ToString();

            string value = string.Format("{0:C2}", data[2]);
            string fechaFactura = Convert.ToDateTime(dataGridSaldoCliente.Rows[index].Cells[2].Value.ToString()).ToString("dd-MM-yyyy");
            data[4] = dataGridSaldoCliente.Rows[index].Cells[3].Value.ToString();


            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el saldo cliente: " +
                "\nTramite N: " + data[4] +
                "\nValor saldo: " + value +
                "\nFecha: " + fechaFactura
                , "Advertencia",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);

            if (result == DialogResult.OK)
            {
                UserModel write = new UserModel();

                if (write.InsertDataSaldo(data))
                {
                    MessageBox.Show("Se eliminó correctamente el saldo cliente del trámite número: " + data[4], "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el saldo cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadTablaSaldoCliente();
            }
        }


        string transferencia;
        private void dataGridTransferenciaSaldo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            transferencia = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }


        private void dataGridTransferenciaSaldo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            transferencia = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridTransferenciaSaldo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string celdaAnterior = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (transferencia != celdaAnterior)
            {

                DialogResult result = MessageBox.Show("Desea actualizar la transferencia del saldo?", "Advertencia",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    UserModel Write = new UserModel();
                    string[] data = new string[7];

                    data[0] = "Update";
                    data[1] = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data[2] = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data[3] = Convert.ToDateTime(dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                    data[4] = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[3].Value.ToString();
                    data[5] = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[4].Value.ToString();
                    data[6] = dataGridTransferenciaSaldo.Rows[e.RowIndex].Cells[5].Value.ToString();


                    if (Write.insertDataTransferencia(data))
                    {
                        MessageBox.Show("La transferencia del saldo fue editado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar la transferencia del saldo");
                    }
                }
                else if (result == DialogResult.Cancel || result == DialogResult.No)
                {
                    BeginInvoke(new MethodInvoker(() => {
                        loadTablaTransferenciaSaldo();
                    }));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridTransferenciaSaldo.CurrentCell.RowIndex;

            string[] data = new string[7];

            data[0] = "Delete";
            data[1] = dataGridTransferenciaSaldo.Rows[index].Cells[0].Value.ToString();
            data[2] = dataGridTransferenciaSaldo.Rows[index].Cells[1].Value.ToString();
            data[3] = Convert.ToDateTime(dataGridTransferenciaSaldo.Rows[index].Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
            data[4] = dataGridTransferenciaSaldo.Rows[index].Cells[3].Value.ToString();
            data[5] = dataGridTransferenciaSaldo.Rows[index].Cells[4].Value.ToString();
            data[6] = dataGridTransferenciaSaldo.Rows[index].Cells[5].Value.ToString();

            string value = string.Format("{0:C2}", data[2]);
            string fechaT = Convert.ToDateTime(dataGridTransferenciaSaldo.Rows[index].Cells[2].Value.ToString()).ToString("dd-MM-yyyy");


            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar la transferencia del saldo: " +
                "\nTramite Desde: " + data[4] +
                "\nTramite Hacia: " + data[5] +
                "\nValor: " + value +
                "\nFecha: " + fechaT
                , "Advertencia",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);

            if (result == DialogResult.OK)
            {
                UserModel write = new UserModel();

                if (write.insertDataTransferencia(data))
                {
                    MessageBox.Show("Se eliminó correctamente la transferencia saldo con Tramite Origen: " + data[4] +" y Tramite Destino: " + data[5] + ", con el valor: " + value, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la transferencia saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadTablaTransferenciaSaldo();
            }
        }
    }
}
