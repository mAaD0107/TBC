using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using Presentacion.ClasesComplementarias;

namespace Presentacion
{
    public partial class FormOpcionesSaldoCliente : Form
    {
        public FormOpcionesSaldoCliente()
        {
            InitializeComponent();

            this.panelContenedor.MouseWheel += new MouseEventHandler(panelScroll);
        }

        public void showTramites()
        {
            UserModel Read = new UserModel();

            dataGridTramites.DataSource = Read.readTramitesImport();

            for (int i = 6; i < dataGridTramites.Columns.Count; i++)
                dataGridTramites.Columns[i].Visible = false;

            dataGridTramites.Columns[3].Visible = false;
            dataGridTramites.Columns[4].Visible = false;
            dataGridTramites.Visible = true;

            lblDetalleTrans.Text = "  DETALLE TRANSFERENCIA: " + PagosCache.idTramite;
            
            var col = new DataGridViewTextBoxColumn();
            col.Name = "DESTINO";
            col.DataPropertyName = "DESTINO";   // The DataTable column name.
            col.HeaderText = "DESTINO";
            DataGridDestino.Columns.Add(col);

            var valorCol = new DataGridViewTextBoxColumn();
            valorCol.Name = "VALOR";
            valorCol.DataPropertyName = "VALOR";   // The DataTable column name.
            valorCol.HeaderText = "VALOR";
            DataGridDestino.Columns.Add(valorCol);

            DataGridDestino.Columns[0].Width = 258;
            DataGridDestino.Columns[1].Width = 100;

            DataGridDestino.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(57, 60, 67);
            DataGridDestino.Columns[1].DefaultCellStyle.Format = "N2";
            DataGridDestino.Columns[0].ReadOnly = true;

            lblTransferible.Text = "$   " + ValorSaldo.ToString("N2");

            acoplarScrolls(); 


        }

        public Decimal ValorSaldo = 0;

        private void cmbOpcionesSaldo_TextChanged(object sender, EventArgs e)
        {
            switch (cmbOpcionesSaldo.Text)
            {
                case "Transferir saldo a otro(s) trámite(s)":
                    panelTramites.Visible = true;
                    panelDevolucion.Visible = true;
                    btnGuardar.Text = "Transferir";
                    panelInferior.Visible = true;
                    panelDesde.Visible = true;
                    panelDevolucion.Visible = false;
                    lblDetalle.Text = "DETALLE TRANSFERENCIA";

                    dateTransferencia.ResetText();
                    break;

                case "Devolver Dinero ":
                    panelTramites.Visible = false;
                    panelDevolucion.Visible = true;
                    btnGuardar.Text = "Devolver";
                    panelInferior.Visible = true;
                    panelDesde.Visible = true;
                    lblDetalle.Text = "DETALLE DEVOLUCIÓN";
                    break;


                default:
                    panelDevolucion.Visible = false;
                    panelInferior.Visible = false;
                    break;
            }

            txtValorSaldo.Text = ValorSaldo.ToString("N2");

            vScrollBar.Minimum = panelContenedor.VerticalScroll.Minimum;
            vScrollBar.Maximum = panelContenedor.VerticalScroll.Maximum;

            panelContenedor.Dock = DockStyle.Fill;
        }

        private void FormOpcionesSaldoCliente_Load(object sender, EventArgs e)
        {
            showTramites();
            showDetalles();

        }

        private void showDetalles()
        {
            UserModel Read = new UserModel();
            DataTable detalles = Read.readDetallesP(PagosCache.idTramite);

            if (detalles.Rows.Count > 0)
            {
                txtDetalleTransferencia.Text = detalles.Rows[0][0].ToString();
                dateTransferencia.Value = Convert.ToDateTime(detalles.Rows[0][1].ToString());
            }
        }

        private void panelScroll(object sender, MouseEventArgs e)
        {
            panelContenedor.Focus();
            vScrollBar.Value = panelContenedor.VerticalScroll.Value;
        }

        string filtro = ""; 
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (filtro == "")
                {
                    if (txtBuscar.Text == "")
                    {
                        showTramites();
                    }
                    else
                    {
                        searchData(txtBuscar.Text);
                    }
                }
                else
                {
                    actionOnClicItem(filtro);
                }

                acoplarScrolls(); 
            }
        }

        private void actionOnClicItem(string item)
        {
            if (item == "Quitar Filtro")
            {
                lblFiltro.Text = "   FILTRAR POR:  ";
                if (txtBuscar.Text != "")
                {
                    searchData(txtBuscar.Text);
                }
                else
                {
                    showTramites();
                }

                if (fechaFiltro.Enabled)
                {
                    fechaFiltro.Visible = false;
                    fechaFiltro.Enabled = false;
                    txtBuscar.Enabled = true;
                }

                filtro = "";

            }
            else
            {
                lblFiltro.Text = "   FILTRAR POR:  " + item.ToUpper();
                if (item == "Abono")
                {
                    string texto;
                    texto = clearNumber(txtBuscar.Text);
                    texto = texto.Replace(',', '.');
                    texto = clearComa(texto);
                    txtBuscar.Text = texto;
                }

                if (item == "Fecha")
                {
                    fechaFiltro.Visible = true;
                    fechaFiltro.Enabled = true;

                    txtBuscar.Enabled = false;
                }
                else
                {
                    fechaFiltro.Visible = false;
                    fechaFiltro.Enabled = false;
                    txtBuscar.Enabled = true;
                }

                showTramitesFiltro(item.ToUpper());
                filtro = item;
            }

            txtBuscar.Focus();
        }

        public void showTramitesFiltro(string filtro)
        {
            UserModel Read = new UserModel();
            if (filtro != "FECHA")
            {
                dataGridTramites.DataSource = Read.readTramitesImportFiltroF(filtro, txtBuscar.Text);
            }
            else
            {
                dataGridTramites.DataSource = Read.readTramitesImportFiltroF(filtro, fechaFiltro.Value.ToString("yyyy-MM-dd"));
            }


            for (int i = 6; i < dataGridTramites.Columns.Count; i++)
                dataGridTramites.Columns[i].Visible = false;

            dataGridTramites.Visible = true;

            acoplarScrolls();
        }

        public void searchData(string data)
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.searchTramiteImport(data);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showTramites();
            }
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



        private void txtValorSaldo_TextChanged(object sender, EventArgs e)
        {
            if (txtValorSaldo.Text != "")
            {
                Decimal nuevoSaldo = Decimal.Parse(txtValorSaldo.Text);

                if (nuevoSaldo > ValorSaldo)
                {
                    MessageBox.Show("Este valor no puede superar el valor del saldo Cliente");
                    txtValorSaldo.Text = ValorSaldo.ToString("N2");
                    txtValorSaldo.Focus();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guarda en la base de datos 
            switch (cmbOpcionesSaldo.Text)
            {
                case "Transferir saldo a otro(s) trámite(s)":
                    guardarTransferencia();
                    break;
                case "Devolver Dinero ":
                    guardarDevolucion();
                    break;

            }

            // Regresar al panel de Pagos 
            if (permitirTransferencia)
            {
                regresarPagos();
            }
            

        }

        public void regresarPagos()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormCrearPago formCrearPago = new FormCrearPago();
                formCrearPago.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                if (PagosCache.tipoPago == "unico")
                {
                    formCrearPago.panelInfoPago.Visible = true;
                    formCrearPago.panelTipoPago.RowStyles[1].Height = 0;
                }
                else
                {
                    formCrearPago.panelPagoGeneral.Visible = true;
                    formCrearPago.panelTipoPago.RowStyles[0].Height = 0;
                    formCrearPago.cargarPagoGeneral = true;
                }

                formPrincipal.AddOwnedForm(formCrearPago);
                formPrincipal.AbrirFormInPanel(formCrearPago);
            }
        }

        string[] valuesT = new string[8];
        string[] valuesD = new string[6];

        public string tramiteOrigen;
        bool errorTransferencia = false; 
        private void guardarTransferencia()
        {
            UserModel Write = new UserModel();

            if (permitirTransferencia)
            {
                for (int i = 0; i < DataGridDestino.RowCount; i++)
                {
                    valuesT[0] = "Insert";
                    valuesT[1] = "0";
                    valuesT[2] = DataGridDestino.Rows[i].Cells[1].Value.ToString();
                    valuesT[3] = dateTransferencia.Value.ToString("yyyy-MM-dd");//DateTime.Now.Date.ToString("yyyy-MM-dd");
                    valuesT[4] = PagosCache.idTramite;
                    valuesT[5] = DataGridDestino.Rows[i].Cells[0].Value.ToString();
                    valuesT[6] = txtDetalleTransferencia.Text;
                    valuesT[7] = buscarIDSaldoCLiente();

                    if (Write.insertDataTransferencia(valuesT))
                    {
                        //MessageBox.Show("La transferencia se ha realizado exitosamente.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido guardar los datos de la transferencia: " + valuesT[5], "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorTransferencia = true; 
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede procesar la transferencia.\r\nEl valor total de la(s) transferencia(s) superan al valor transferible." , "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!errorTransferencia && permitirTransferencia)
            {
                MessageBox.Show("Las transferencias se han realizado exitosamente", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string buscarIDSaldoCLiente()
        {

            return "";
        }

        private string obtenerID(string Tramite)
        {
            string[] array = Tramite.Split('-');
            MessageBox.Show("Numero tramite: " + array[1]);
            return array[1];
        }

        private void guardarDevolucion()
        {
            UserModel Write = new UserModel();

            valuesD[0] = "Insert";
            valuesD[1] = "0";
            valuesD[2] = txtValorSaldo.Text;
            valuesD[3] = dateTransferencia.Value.ToString("yyyy-MM-dd");
            valuesD[4] = PagosCache.numeroTramite.ToString();
            valuesD[5] = txtDetalleTransferencia.Text; 

            if (Write.insertDataDevolucion(valuesD))
            {
                MessageBox.Show("La devolución se realizado exitosamente", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido realizar la devolución", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridTramites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbOpcionesSaldo.Text == "Transferir saldo a otro trámite")
            {
                if (dataGridTramites.CurrentRow != null && dataGridTramites.CurrentRow.Index < dataGridTramites.Rows.Count - 1)
                {
                    //lblDesdeHasta.Text = PagosCache.idTramite + "   -- >   " +
                    //dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
            }
        }

        private void FormOpcionesSaldoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                regresarPagos();
            }
        }

        private void dateTransferencia_onValueChanged(object sender, EventArgs e)
        {
            dateTransferencia.Refresh();
        }

        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            panelContenedor.VerticalScroll.Value = e.Value;
        }

        private void panelContenedor_Scroll(object sender, ScrollEventArgs e)
        {
            panelContenedor.Focus();
            vScrollBar.Value = panelContenedor.VerticalScroll.Value;
        }


        bool permitirTransferencia = false; 

        private void DataGridDestino_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridDestino.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (e.ColumnIndex == 1)
                {
                    string entrada = DataGridDestino.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    string texto = clearNumber(entrada);
                    texto = texto.Replace(',', '.');
                    //texto = clearDot(texto);
                    texto = Convert.ToDouble(texto).ToString("N2");
                    DataGridDestino.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = texto;

                    double total = 0;
                    for (int i = 0; i < DataGridDestino.Rows.Count; i++)
                    {
                        if (DataGridDestino.Rows[i].Cells[1].Value != null)
                        {
                            string valorString = DataGridDestino.Rows[i].Cells[1].Value.ToString();
                            // Intentar convertir usando la configuración regional invariante.
                            if (double.TryParse(valorString, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
                            {
                                total += valor;
                            }
                            else
                            {
                                // Intenta manejar el caso en que la entrada no es un número válido.
                                Console.WriteLine($"Entrada no válida: {valorString}");
                            }
                        }
                    }

                    // Para mostrar el total correctamente, asumimos que quieres usar el formato invariante (punto como separador decimal).
                    string totalFormateado = total.ToString(CultureInfo.InvariantCulture);
                    total = double.Parse(totalFormateado);

                    lblTotal.Text = "$   " + total.ToString("N2");

                    if (ValorSaldo >= (Decimal)total)
                    {
                        permitirTransferencia = true;
                    }
                    else
                    {
                        permitirTransferencia = false;
                        //MessageBox.Show("No es posible realizar la transferencia.\r\nSaldo insuficiente."); 
                    }
                }
            }
        }

        public string clearNumber(string dato)
        {
            Regex digitsOnly = new Regex(@"[^\d.,]");
            return digitsOnly.Replace(dato, "");
        }

        public string clearDot(string dato)
        {
            return Regex.Replace(
                    dato, //input string
                    @"(?<=\.).*", //match everything after 1st "."
                    m => m.Value.Replace(",", string.Empty));
        }

        public string clearComa(string dato)
        {
            return Regex.Replace(
                    dato, //input string
                    @"(?<=\.).*", //match everything after 1st "."
                    m => m.Value.Replace(".", string.Empty));
        }

        private void VScroll_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            if (VScroll.Visible)
            {
                dataGridTramites.FirstDisplayedScrollingRowIndex = e.Value;
            }
        }

        private void acoplarScrolls()
        {

            if (dataGridTramites.RowCount > 9)
            {
                if (dataGridTramites.RowCount == 1)
                {
                    VScroll.Maximum = dataGridTramites.RowCount;
                }
                else
                {
                    VScroll.Maximum = dataGridTramites.RowCount - 1;
                }

                VScroll.Visible = true;

            }
            else
            {

                VScroll.Minimum = 0;
                VScroll.Maximum = 1;

                VScroll.Visible = false;
            }
        }

        private void dataGridTramites_Scroll(object sender, ScrollEventArgs e)
        {
            VScroll.Value = e.NewValue;
        }

        private void dataGridTramites_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            string idTramite = dataGridTramites.Rows[indice].Cells[1].Value.ToString();
            DataGridDestino.Rows.Add(idTramite);
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem mi;

            // Item 1
            mi = new ToolStripMenuItem("Numero Factura", null, (s, a) => actionOnClicItem("Número Factura"));
            mi.BackColor = Color.FromArgb(200, 41, 46, 54);
            mi.ForeColor = Color.White;
            mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
            mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
            menu.Items.Add(mi);

            // Item 2
            mi = new ToolStripMenuItem("Asiento", null, (s, a) => actionOnClicItem("Asiento"));
            mi.BackColor = Color.FromArgb(200, 41, 46, 54);
            mi.ForeColor = Color.White;
            mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
            mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
            menu.Items.Add(mi);

            // Item 3
            mi = new ToolStripMenuItem("Abono", null, (s, a) => actionOnClicItem("Abono"));
            mi.BackColor = Color.FromArgb(200, 41, 46, 54);
            mi.ForeColor = Color.White;
            mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
            mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
            menu.Items.Add(mi);

            // Item 4
            mi = new ToolStripMenuItem("Fecha", null, (s, a) => actionOnClicItem("Fecha"));
            mi.BackColor = Color.FromArgb(200, 41, 46, 54);
            mi.ForeColor = Color.White;
            mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
            mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
            menu.Items.Add(mi);

            mi = new ToolStripMenuItem("Quitar Filtro", null, (s, a) => actionOnClicItem("Quitar Filtro"));
            mi.BackColor = Color.FromArgb(200, 41, 46, 54);
            mi.ForeColor = Color.White;
            mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
            mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
            menu.Items.Add(mi);

            menu.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            menu.BackColor = Color.FromArgb(100, 41, 46, 54);
            menu.Show(new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50));
        }

        ToolStripProfessionalRenderer r = new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(187, 42, 89)));
        ToolStripProfessionalRenderer normal = new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(185, 209, 234)));
        private void menuItem_MouseEnter(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (item.Text == "Quitar Filtro")
            {
                ToolStripManager.Renderer = r;
            }
            else
            {
                ToolStripManager.Renderer = normal;
                item.ForeColor = Color.FromArgb(200, 41, 46, 54);
            }
        }

        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (item.Text == "Quitar Filtro")
            {
                ToolStripManager.Renderer = r;
            }
            else
            {
                ToolStripManager.Renderer = normal;
                item.ForeColor = Color.White;
            }
        }

        private void fechaFiltro_onValueChanged(object sender, EventArgs e)
        {
            actionOnClicItem(filtro);
        }

        private void txtValorSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }
    }
}