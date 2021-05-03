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

            if (UserCache.Position == Positions.Clientes)
            {
                btnGenerar.Visible = false; 
            }

            this.panelContenedor.MouseWheel += new MouseEventHandler(panelScroll);
            this.txtComentarios.MouseWheel += new MouseEventHandler(deshabilitarTexto);
            this.checkListFacturas.MouseWheel += new MouseEventHandler(deshabilitarCheckList);

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

            vScrollBar.Minimum = panelContenedor.VerticalScroll.Minimum;
            vScrollBar.Maximum = panelContenedor.VerticalScroll.Maximum;
            hScrollBar.Maximum = dataFacturas.ColumnCount - 1;

            ActiveControl = null;
            panelContenedor.Dock = DockStyle.Fill;
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
                if (btnG)
                {
                      MessageBox.Show("No es posible guardar la Carta.\n" +
                    "Por favor, selecione las facturas que desea agregar.",
                    "Alerta.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No es posible generar la Carta.\n" +
                "Por favor, selecione las facturas que desea agregar.",
                "Alerta.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                }


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

        private void panelContenedor_Scroll(object sender, ScrollEventArgs e)
        {
           // MessageBox.Show("scroll");
            //vScrollBar.Value = e.NewValue;
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

        private void hScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            dataFacturas.FirstDisplayedScrollingColumnIndex = e.Value;
        }

        private void deshabilitarTexto(object sender, MouseEventArgs e)
        {
            txtComentarios.Enabled = false;
            panelContenedor.Focus();
        }

        private void deshabilitarCheckList(object sender, MouseEventArgs e)
        {
            checkListFacturas.Enabled = false;
            checkListFacturas.SelectedIndex = -1; 
            panelContenedor.Focus();
        }

        private void habilitarTexto(object sender, MouseEventArgs e)
        {
            if (txtComentarios.Enabled == false)
            {
                if ((e.X >= txtComentarios.Location.X && e.X <= (txtComentarios.Location.X + txtComentarios.Width)) 
                    && 
                    (e.Y >= txtComentarios.Location.Y && e.Y <= (txtComentarios.Location.Y + txtComentarios.Height)))
                {
                    txtComentarios.Enabled = true;
                    txtComentarios.Focus();
                }
            }

        }


        private void panelComentarios_MouseClick(object sender, MouseEventArgs e)
        {
            habilitarTexto(sender, e);
        }

 
        private void panelFacturas_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkListFacturas.Enabled == false)
            {
                if ((e.X >= checkListFacturas.Location.X && e.X <= (checkListFacturas.Location.X + checkListFacturas.Width))
                    &&
                    (e.Y >= checkListFacturas.Location.Y && e.Y <= (checkListFacturas.Location.Y + checkListFacturas.Height)))
                {
                    checkListFacturas.Enabled = true;
                    checkListFacturas.Focus();
                }
            }
        }


        bool btnG = false; 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            btnG = true; 
            if (agregarFacturas())
            {
                if (model.InsertDataCarta(dataCarta()))
                {
                    MessageBox.Show("La Carta se ha guardado exitosamente", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No ha sido posible guardar los datos de la Carta", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnG = false;
        }

        private string[] dataCarta()
        {
            string[] data = new string[40];
            List<string> facturas = new List<string>(); 

            foreach (var item in checkListFacturas.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                string tipoFactura = row.Field<string>("Tipo_Factura");
                facturas.Add(tipoFactura);
            }

            data[0] = "Insert"; 
            data[1] = "0"; 
            data[2] = txtTramite.Text;
            data[3] = txtCliente.Text;
            data[4] = txtDAI.Text;
            data[5] = txtSecuencialCliente.Text;
            data[6] = valorAPagar.ToString("N2");
            data[7] = totalGastos.ToString("N2");
            data[8] = valorMayorContable.ToString("N2");
            data[9] = (totalGastos - Math.Round(valorMayorContable, 2)).ToString("N2");
            data[10] = DateTime.Now.ToString("yyyy-MM-dd");
            data[11] = estaEnLista("Agente_LDM", facturas) ? "true" : "false";
            data[12] = estaEnLista("Agente", facturas) ? "true" : "false";
            data[13] = estaEnLista("TBC", facturas) ? "true" : "false";
            data[14] = estaEnLista("Transporte", facturas) ? "true" : "false";
            data[15] = estaEnLista("Gastos_Locales", facturas) ? "true" : "false";
            data[16] = estaEnLista("Visto_THC", facturas) ? "true" : "false";
            data[17] = estaEnLista("Retiro_BL", facturas) ? "true" : "false";
            data[18] = estaEnLista("Liquidación_Aduana", facturas) ? "true" : "false";
            data[19] = estaEnLista("Retiro_Guía", facturas) ? "true" : "false";
            data[20] = estaEnLista("Demoraje", facturas) ? "true" : "false";
            data[21] = estaEnLista("Actualización_Carta", facturas) ? "true" : "false";
            data[22] = estaEnLista("Almacenaje", facturas) ? "true" : "false";
            data[23] = estaEnLista("Devolución_Contenedor", facturas) ? "true" : "false";
            data[24] = estaEnLista("Manipulación_Contenedor", facturas) ? "true" : "false";
            data[25] = estaEnLista("Gastos_I", facturas) ? "true" : "false";
            data[26] = estaEnLista("Gastos_II", facturas) ? "true" : "false";
            data[27] = estaEnLista("Gastos_III", facturas) ? "true" : "false";
            data[28] = estaEnLista("Gastos_IV", facturas) ? "true" : "false";
            data[29] = estaEnLista("Gastos_V", facturas) ? "true" : "false";
            data[30] = estaEnLista("Honorarios_I", facturas) ? "true" : "false";
            data[31] = estaEnLista("Honorarios_II", facturas) ? "true" : "false";
            data[32] = estaEnLista("Honorarios_III", facturas) ? "true" : "false";
            data[33] = estaEnLista("Transporte_I", facturas) ? "true" : "false";
            data[34] = estaEnLista("Transporte_II", facturas) ? "true" : "false";
            data[35] = estaEnLista("Transporte_III", facturas) ? "true" : "false";
            data[36] = txtComentarios.Text;
            data[37] = cmbTipoCarta.Text == "SIN LOGO" ? "false" : "true";
            data[38] = UserCache.FirstName +" "+ UserCache.LastName; 




            return data; 
        }


        private bool estaEnLista(string campo, List<string> lista)
        {
            return lista.ToList().Any(x => x == campo); 
        }
    }
}
