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
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormOpcionesSaldoCliente : Form
    {
        public FormOpcionesSaldoCliente()
        {
            InitializeComponent();
        }

        public void showTramites()
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.readTramitesImport();
        }

        public double ValorSaldo;

        private void cmbOpcionesSaldo_TextChanged(object sender, EventArgs e)
        {
            switch (cmbOpcionesSaldo.Text)
            {
                case "Transferir saldo a otro trámite":
                    panelTramites.Visible = true;
                    panelDevolucion.Visible = true;
                    lblVal.Text = "Valor a transferir: $";
                    btnGuardar.Text = "Transferir";
                    panelInferior.Visible = true;
                    panelDesde.Visible = true;

                    lblDetalle.Text = "DETALLE TRANSFERENCIA";

                    dateTransferencia.ResetText();


                    lblDesdeHasta.Text = PagosCache.idTramite + " - > " +
                                         dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    break;

                case "Devolver Dinero ":
                    panelTramites.Visible = false;
                    panelDevolucion.Visible = true;
                    lblVal.Text = "Valor a devolver: $";
                    btnGuardar.Text = "Devolver";
                    panelInferior.Visible = true;
                    panelDesde.Visible = true;

                    lblDesdeHasta.Visible = false;
                    lblDetalle.Text = "DETALLE DEVOLUCIÓN";
                    break;


                default:
                    panelDevolucion.Visible = false;
                    panelInferior.Visible = false;
                    break;
            }

            txtValorSaldo.Text = ValorSaldo.ToString("N2");
        }

        private void FormOpcionesSaldoCliente_Load(object sender, EventArgs e)
        {
            showTramites();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void txtTotalNotCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtValorSaldo_TextChanged(object sender, EventArgs e)
        {
            if (txtValorSaldo.Text != "")
            {
                double nuevoSaldo = double.Parse(txtValorSaldo.Text);

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
                case "Transferir saldo a otro trámite":
                    guardarTransferencia();
                    break;
                case "Devolver Dinero ":
                    guardarDevolucion();
                    break;

            }

            // Regresar al panel de Pagos 
            regresarPagos();

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
        private void guardarTransferencia()
        {
            UserModel Write = new UserModel();

            valuesT[0] = "Insert";
            valuesT[1] = "0";
            valuesT[2] = txtValorSaldo.Text;
            valuesT[3] = dateTransferencia.Value.ToString("yyyy-MM-dd");//DateTime.Now.Date.ToString("yyyy-MM-dd");
            valuesT[4] = PagosCache.idTramite;
            valuesT[5] = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();
            valuesT[6] = txtDetalleTransferencia.Text; 
            valuesT[7] = buscarIDSaldoCLiente(); 

            if (Write.insertDataTransferencia(valuesT))
            {
                MessageBox.Show("La transferencia se ha realizado exitosamente.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido guardar los datos de la transferencia.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    lblDesdeHasta.Text = PagosCache.idTramite + "   -- >   " +
                    dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();
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
    }
}
