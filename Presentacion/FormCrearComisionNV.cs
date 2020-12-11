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
        }

        private void FormCrearComisionNV_Load(object sender, EventArgs e)
        {
            cargarComision();
            cmbNombres.SelectedIndex = 0;
        }

        double subTotalFacturaTBC = 0, subTotalAereo = 0, subTotalMaritimo = 0;

        private void panelGeneral_Resize(object sender, EventArgs e)
        {
            panelTitulo.Width = this.Width - 30;
            panelFiltros.Width = this.Width - 30;
            panelSubtotalLDM.Width = this.Width - 30;

        }

        private void panelTitulo_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        double subTotalLDM = 0, comision = 0;
        private void cargarComision()
        {
            DataTable comisiones = new DataTable();
            
            UserModel Read = new UserModel();
            comisiones = Read.searchComisionCliente(ComisionesCache.CI);

            subTotalFacturaTBC = double.Parse(comisiones.Rows[0]["Comisiones"].ToString());
            subTotalAereo = double.Parse(comisiones.Rows[0]["Comision_Factura_Agente_Aerea"].ToString());
            subTotalMaritimo = double.Parse(comisiones.Rows[0]["Comision_Factura_Agente_Maritimo"].ToString());

            subTotalLDM = Read.searchValorFacturaLDM(ComisionesCache.nTramite);
            
            txtComisionTBC.Text = subTotalFacturaTBC.ToString("N2");

            if (subTotalFacturaTBC != subTotalLDM)
            {
                switch (ComisionesCache.tipoTramite)
                {
                    case "Marítimo":
                        comision = subTotalMaritimo;
                        break;

                    case "Aéreo":
                        comision = subTotalAereo;
                        break;

                    default:
                        comision = 0;
                        break;
                }
            }

            txtSubtotalLDM.Text = comision.ToString("N2");
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
