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
    public partial class FormDevolucionTransferencia : Form
    {
        public FormDevolucionTransferencia()
        {
            InitializeComponent();
        }

        private void txtValorDevolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
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

        public double ValorSaldo;
        private void txtValorDevolucion_TextChanged(object sender, EventArgs e)
        {
            if (txtValorDevolucion.Text != "")
            {
                double nuevoSaldo = double.Parse(txtValorDevolucion.Text);

                if (nuevoSaldo > ValorSaldo)
                {
                    MessageBox.Show("Este valor no puede superar el valor del saldo transferencia");
                    txtValorDevolucion.Text = ValorSaldo.ToString("N2");
                    txtValorDevolucion.Focus();
                }
            }
        }

        private void FormDevolucionTransferencia_Shown(object sender, EventArgs e)
        {
            txtValorDevolucion.Text = ValorSaldo.ToString("N2");
            lblTitulo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UserModel Write = new UserModel();

            string[] valuesD = new string[6];

            valuesD[0] = "Insert";
            valuesD[1] = "0";
            valuesD[2] = txtValorDevolucion.Text;
            valuesD[3] = dateDevolucion.Value.ToString("yyyy-MM-dd");
            valuesD[4] = PagosCache.numeroTramite.ToString();
            valuesD[5] = txtDetalleDevolucion.Text;

            if (Write.insertDataDevolucionTransferencia(valuesD))
            {
                MessageBox.Show("La devolución se realizado exitosamente", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido realizar la devolución", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void FormDevolucionTransferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                regresarPagos();
            }
        }
    }
}
