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
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System.Threading;
using System.Globalization;

namespace Presentacion
{
    public partial class FormInfoFacturasCarta : Form
    {

        double valorAPagar = 0;
        double totalGastos = 0;
        double valorMayorContable = 0;

        public ReadOnlyCollection<string> tipoFactura { get; } = new ReadOnlyCollection<string>
        (
            new string[] 
            {
                "Agente",
                "Agente_LDM",
                "TBC",
                "Transporte",
                "Transporte_I",
                "Transporte_II",
                "Transporte_III",
                "Honorarios_I",
                "Honorarios_II",
                "Honorarios_III"
            }
        );

        public FormInfoFacturasCarta()
        {
            InitializeComponent();
        }

        private void FormInfoFacturasCarta_Load(object sender, EventArgs e)
        {
            UserModel Read = new UserModel();
            DataTable Facturas = Read.readInfoFacturas(FacturaCache.ID_Tramite);
            dataFacturas.DataSource = Facturas;
            

            int n = obtenerNTramite(FacturaCache.ID_Tramite);

            DataTable TipoFactura = Read.readPagos(n);
            checkListFacturas.DataSource = TipoFactura;
            checkListFacturas.DisplayMember = "Tipo_Factura";
            checkListFacturas.ValueMember = "Tipo_Factura";


            foreach (DataRow row in Facturas.Rows)
            {
                if (!existeFactura(Convert.ToString(row[0] is DBNull ? "" : row[0])))
                {
                    totalGastos += Convert.ToDouble(row[10] is DBNull ? 0 : row[10]);
                }
                valorAPagar += Convert.ToDouble(row[10] is DBNull ? 0 : row[10]);
            }




            txtTotalTramite.Text = "$ " + valorAPagar.ToString("N2");
            txtTotalGastos.Text = "$ " + totalGastos.ToString("N2");



            ActiveControl = null;
            panelContenedor.Focus();


        }




        private int obtenerNTramite(string ID_Tramite)
        {
            string[] texto = ID_Tramite.Split(new string[] { "-" }, StringSplitOptions.None);
            return int.Parse(texto[1]);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkListFacturas.Items.Count; i++)
            {
                checkListFacturas.SetItemChecked(i, true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkListFacturas.Items.Count; i++)
            {
                checkListFacturas.SetItemChecked(i, false);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea generar la carta ?",
                                                    "Info.",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                CartaCache.Observaciones = txtComentarios.Text;
                CartaCache.TipoCarta = cmbTipoCarta.Text;
                if (agregarFacturas())
                {
                    FormInformeCarta formInformeCarta = new FormInformeCarta();
                    formInformeCarta.Show();
                }


            }
        }


        private string[] InsertData()
        {
            string[] dato = new string[13];

            UserModel Read = new UserModel();
            DataTable datosCarta = Read.readDatosCarta(TramiteCache.idTramite);

            /*
            dato[1] = readIDInforme();
            dato[2] = txtNumInforme.Text;
            dato[3] = txtClienteTramite.Text;
            dato[4] = txtDAI.Text;
            dato[5] = txtSecuencialCliente.Text;
            dato[6] = txtNFacturaLDM.Text;
            dato[7] = txtSubTotalLDM.Text;
            dato[8] = txtPersonaComision.Text;
            dato[9] = txtValorComision.Text;
            dato[10] = txtPersonaComisionExtra.Text;
            dato[11] = txtValComisionExtra.Text;
            dato[12] = idTramite.ToString();
            */
            dato[0] = "Insert";

            return dato;
        }

        private bool agregarFacturas()
        {
            if (checkListFacturas.CheckedItems.Count > 0)
            {
                
                if (CartaCache.Facturas != null) CartaCache.Facturas.Clear();
                CartaCache.Facturas = new List<string>();

                foreach (var item in checkListFacturas.CheckedItems)
                {
                    var row = (item as DataRowView).Row;
                    string tipoFactura = row.Field<string>("Tipo_Factura");
                    CartaCache.Facturas.Add(tipoFactura);
                }

                return true;
            }
            else
            {
                MessageBox.Show("No es posible generar la Carta.\n"+
                                "Por favor, selecione las facturas que desea agregar.",
                                "Alerta.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                checkListFacturas.Focus();

                return false; 
            }

        }

        private bool existeFactura(string factura)
        {
            return tipoFactura.Any(x => x == factura);
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
        private void txtMayorContable_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtMayorContable_TextChanged(object sender, EventArgs e)
        {
            if (txtMayorContable.Text != "")
            {
                lblDolar.Visible = true;
                valorMayorContable = double.Parse(txtMayorContable.Text);
            }
            else
            {
                lblDolar.Visible = false;
                valorMayorContable = 0;
            }
            
            txtDiferencia.Text = "$ "+(totalGastos - Math.Round(valorMayorContable, 2)).ToString("N2");
        }
    }
}
