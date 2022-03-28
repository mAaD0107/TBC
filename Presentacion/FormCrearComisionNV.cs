using Common.Cache;
using Domain;
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
    public partial class FormCrearComisionNV : Form
    {
        public FormCrearComisionNV()
        {
            InitializeComponent();
            this.panelGeneral.MouseWheel += new MouseEventHandler(panelScroll);
        }

        private void FormCrearComisionNV_Load(object sender, EventArgs e)
        {
            cargarComision();
            cmbNombres.SelectedIndex = 0;
            dateInicio.Value = DateTime.Today;
            ComisionesNVCache.fecha = dateInicio.Value.ToString("dd-MMMM-yyyy");
        }

        double subTotalFacturaTBC = 0, subTotalAereo = 0, subTotalMaritimo = 0;

        private void panelGeneral_Resize(object sender, EventArgs e)
        {
            panelTitulo.Width = this.Width - 45;
            panelFiltros.Width = this.Width - 45;
            panelSubtotalLDM.Width = this.Width - 45;            

        }

        private void panelTitulo_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        double subTotalLDM = 0;
        string  comision = "";
        string[] values1 = new string[6];
        
        string NNotadeVenta="";
        private void cargarComision()
        {

            string ID_Tramite = "";
            UserModel Read = new UserModel();
            DataTable clientes = Read.getDatosComision(ComisionesCache.CI);
            DataTable comisiones = Read.searchComisionCliente(ComisionesCache.CI);
            DataTable Id_Tramite = Read.getIDTramite(ComisionesCache.nTramite);
            txtMesFacturacion.Text = Convert.ToDateTime(ComisionesCache.fechaInicio).ToString("MMM").ToUpper();
            ComisionesNVCache.Mes = txtMesFacturacion.Text;
            subTotalFacturaTBC = double.Parse(comisiones.Rows[0]["Comisiones"].ToString());
            subTotalAereo = double.Parse(comisiones.Rows[0]["Comision_Factura_Agente_Aerea"].ToString());
            subTotalMaritimo = double.Parse(comisiones.Rows[0]["Comision_Factura_Agente_Maritimo"].ToString());
            if (Id_Tramite.Rows.Count > 0) { ID_Tramite = Id_Tramite.Rows[0][0].ToString(); }
            subTotalLDM = Read.searchValorFacturaLDM(ComisionesCache.nTramite);
            txtIDTramite.Text = ID_Tramite;
            ComisionesNVCache.Id_Tamite = ID_Tramite;
            DataTable ComisionN = Read.verifyComision(ID_Tramite);          

            txtSecuencialCliente.Text = ComisionesCache.Secuencial;
            ComisionesNVCache.Secuencial = txtSecuencialCliente.Text;
            txtCliente.Text = ComisionesCache.CI;
            txtDAI.Text = ComisionesCache.DAI;
            ComisionesNVCache.DAI = txtDAI.Text;

            //txtComisionTBC.Text = subTotalFacturaTBC.ToString("N2");
            if (clientes.Rows.Count > 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    values1[i] = clientes.Rows[0][i].ToString();
                }
            }


            if (subTotalFacturaTBC != subTotalLDM)
            {
                switch (ComisionesCache.tipoTramite)
                {
                    case "Marítimo":
                        subTotalLDM = subTotalMaritimo;
                        
                        break;

                    case "Aéreo":
                        subTotalLDM = subTotalAereo;
                        
                        break;

                    default:
                        subTotalLDM = 0;
                        break;
                }
            }
            
            if (clientes.Rows.Count > 0)
            {
                if (ComisionesCache.tipoTramite == "Marítimo") { comision = values1[1]; }
                if (ComisionesCache.tipoTramite == "Terrestre") { comision = values1[2]; }
                if (ComisionesCache.tipoTramite == "Aéreo") { comision = values1[0]; }
            }
            if (ComisionN.Rows.Count > 0 && ComisionN.Rows[0][2].ToString() != "NULL") {
                txtComisionTBC.Text = ComisionN.Rows[0][2].ToString();
            }
            else { txtComisionTBC.Text = subTotalLDM.ToString(); }
            
            txtSubtotalLDM.Text = comision;
            ComisionesNVCache.valorComision = subTotalLDM.ToString();
        }

        string[] values = new string[6];
        public bool editar = false;
        public string[] dataNotaVenta()
        {
            values[1] = cmbNombres.Text;
            values[2] = txtNumeroNotaVenta.Text;
            values[3] = txtComisionTBC.Text;
            
            values[4] = txtSubtotalLDM.Text;
            values[5] = ComisionesCache.nTramite.ToString();


            for (int i = 3; i < 5; i++)
            {
                if (values[i] == "")
                {
                    values[i] = "0";
                }
            }

            if (!editar)
            {
                values[0] = "Insert";
            }
            else
            {
                values[0] = "Update";
            }
            return values;
        }

        private void FormCrearComisionNV_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idCliente = 7;
        }

        private void panelFiltros_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool hayFactura()
        {
            UserModel Read = new UserModel();
            if (txtNumeroNotaVenta.Text != "")
            {
                return Read.searchNotaVentaComision(txtNumeroNotaVenta.Text);
            }
            else
            {
                return true;
            }

        }

        private void panelScroll(object sender, MouseEventArgs e)
        {
            panelGeneral.Focus();
            vScrollBar.Value = panelGeneral.VerticalScroll.Value;
        }
        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            panelGeneral.VerticalScroll.Value = e.Value;
        }
        private void panelContenedor_Scroll(object sender, ScrollEventArgs e)
        {
            // MessageBox.Show("scroll");
            //vScrollBar.Value = e.NewValue;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(ComisionesNVCache.DAI + ComisionesNVCache.fecha + ComisionesNVCache.Id_Tamite + ComisionesNVCache.Mes + ComisionesNVCache.Secuencial + ComisionesNVCache.valorComision);
           
            FormInformeNV prueba = new FormInformeNV();
            prueba.Show();
        }

        private void txtNumeroNotaVenta_Leave(object sender, EventArgs e)
        {
            if (hayFactura())
            {
                txtNumeroNotaVenta.ForeColor = Color.FromArgb(187, 42, 89);
                lblNotaVentaNoValida.Visible = true;
            }
            else
            {
                txtNumeroNotaVenta.ForeColor = Color.White;
                NNotadeVenta = txtNumeroNotaVenta.Text;
                lblNotaVentaNoValida.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UserModel Write = new UserModel();

            DialogResult result = MessageBox.Show(
                                  "Seuro desea guardar la nota de venta ?",
                                  "Info.",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (!hayFactura())
                {
                    if (Write.InsertDataNotaVentaComision(dataNotaVenta()))
                    {
                        DialogResult resultS = MessageBox.Show("La nota de venta: " + values[2] +
                                                                "\n\nSe ha guardado exitosamente",
                                                                "Info",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information);

                        FormPrincipal formPrincipal = Owner as FormPrincipal;

                        FormOpcionesComisiones formOpcionesComisiones = new FormOpcionesComisiones();
                        formOpcionesComisiones.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formOpcionesComisiones);
                        formPrincipal.AbrirFormInPanel(formOpcionesComisiones);
                    }
                    else
                    {
                        MessageBox.Show("No ha sido posible guardar la nota de venta\n" +
                                        "Por favor, inténtelo mas tarde.",
                                        "Alerta",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (txtNumeroNotaVenta.Text != "")
                    {
                        MessageBox.Show("El número de nota de venta ingresada ya existe." +
                                        "\nPor favor, ingrese una nota de venta nueva.",
                                        "Info.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);

                        txtNumeroNotaVenta.ForeColor = Color.FromArgb(187, 42, 89);
                    }
                    else
                    {
                        MessageBox.Show("El número de nota de venta no puede ser nulo.",
                                        "Info.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }

                    txtNumeroNotaVenta.Focus();

                }
            }
        }
    }
}
