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
using Microsoft.VisualBasic;

namespace Presentacion
{
    public partial class FormCrearComisionFactura : Form
    {
        public FormCrearComisionFactura()
        {
            InitializeComponent();
        }


        private void FormCrearComisionFactura_Load(object sender, EventArgs e)
        {
            cmbTipoAgente.SelectedIndex = 0;
            readIVA();
            cargarComisiones();
            compararValores();
            calcularTotalFactura();
        }

        private void readIVA()
        {
            UserModel Read = new UserModel();

            cmbIVA.DataSource = Read.readIVA();
            cmbIVA.DisplayMember = "Porcentaje";
            cmbIVA.ValueMember = "Porcentaje";

            cmbPorcentajeRetRenta.DataSource = Read.readIVA();
            cmbPorcentajeRetRenta.DisplayMember = "Porcentaje";
            cmbPorcentajeRetRenta.ValueMember = "Porcentaje";


            cmbPorcentajeRetIVA.DataSource = Read.readIVA();
            cmbPorcentajeRetIVA.DisplayMember = "Porcentaje";
            cmbPorcentajeRetIVA.ValueMember = "Porcentaje";

        }

        private void compararValores()
        {
            if (subTotalFacturaTBC == subtotalFacturaLDM)
            {
                switch (ComisionesCache.tipoTramite)
                {
                    case "Marítimo":
                        comision = comisionMaritima;
                        break;

                    case "Aéreo":
                        comision = comisionAerea;
                        break;

                    default:
                        comision = 0;
                        break;
                }

                txtComision.Text = comision.ToString("N2");
            }
            else
            {

                string valor = Interaction.InputBox(
                                     "El subtotal de la factura LDM es inusual." +
                                    "\n\nPor favor, ingrese un nuevo valor de comisión",
                                    "Info.",
                                    "");

                txtComision.Text = valor;
            }

        }

        double subTotalFacturaTBC = 0;
        double comisionMaritima = 0, comisionAerea = 0;
        double subtotalFacturaLDM = 0;
        double comision = 0;
        private void cargarComisiones()
        {
            UserModel Read = new UserModel();
            DataTable comisiones = Read.searchComisionCliente(ComisionesCache.CI);

            subTotalFacturaTBC = double.Parse(comisiones.Rows[0]["Comisiones"].ToString());
            comisionAerea = double.Parse(comisiones.Rows[0]["Comision_Factura_Agente_Aerea"].ToString());
            comisionMaritima = double.Parse(comisiones.Rows[0]["Comision_Factura_Agente_Maritimo"].ToString());

            subtotalFacturaLDM = Read.searchValorFacturaLDM(ComisionesCache.nTramite);


            lblValLDM.Text = "Subtotal Factura LDM:   " + subtotalFacturaLDM.ToString("N2") + " $";
            lblSubtotalBD.Text = "Subtotal Base de Datos:   " + subTotalFacturaTBC.ToString("N2") + " $";

            DataTable datosBDCliente = Read.searchComisionCliente(ComisionesCache.CI);

            double porcentajeRetRenta = double.Parse(datosBDCliente.Rows[0]["Retencion_Renta_Factura_Agente"].ToString());
            double porcentajeRetIVA = double.Parse(datosBDCliente.Rows[0]["Retencion_IVA_Factura_Agente"].ToString());

            //cmbPorcentajeRetRenta.Text = porcentajeRetRenta.ToString("N2");
            //cmbPorcentajeRetIVA.Text = porcentajeRetIVA.ToString("N2");

        }


        private void calcularTotalFactura()
        {

            string iva = cmbIVA.Text;
            iva = iva.Replace(".", ",");
            double totalFactura = 0;
            double ivaComision = 0;

            if (Double.TryParse(txtComision.Text, out double nuevaComision))
            {

                ivaComision = nuevaComision * double.Parse(iva) / 100;
                totalFactura = nuevaComision + ivaComision;

                txtTotalFactura.Text = totalFactura.ToString("N2");
                txtValIVA.Text = ivaComision.ToString("N2");
                txtComision.ForeColor = Color.FromArgb(170, 170, 170);
                lblValnoValido.Visible = false;
            }
            else
            {
                nuevaComision = 0;
                totalFactura = 0;
                txtComision.ForeColor = Color.FromArgb(187, 42, 89);
                lblValnoValido.Visible = true;
            }

            try
            {
                string pRetRenta = cmbPorcentajeRetRenta.SelectedItem == null ? cmbPorcentajeRetRenta.Text : cmbPorcentajeRetRenta.GetItemText(cmbPorcentajeRetRenta.SelectedItem);
                pRetRenta = pRetRenta.Replace(".", ",");
                double valPRetRenta = double.Parse(pRetRenta);

                double valRetRenta = totalFactura * valPRetRenta / 100;


                string pRetIVA = cmbPorcentajeRetIVA.SelectedItem == null ? cmbPorcentajeRetIVA.Text : cmbPorcentajeRetIVA.GetItemText(cmbPorcentajeRetIVA.SelectedItem);
                pRetIVA = pRetIVA.Replace(".", ",");
                double valPRetIVA = double.Parse(pRetIVA);

                double valRetIVA =  ivaComision  * valPRetIVA / 100;

                txtValorRetencionIVA.Text = valRetIVA.ToString("N2");
                txtValorRetencioRenta.Text = valRetRenta.ToString("N2");

                double totalRetencion = valRetIVA + valRetRenta;

                txtTotalRetencion.Text = totalRetencion.ToString("N2");

                double totalACobrar = totalFactura - totalRetencion;

                txtValorCobrarFactura.Text = totalACobrar.ToString("N2");
            }
            catch (Exception)
            { }
        }



        private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }


        private void txtComision_TextChanged(object sender, EventArgs e)
        {
            calcularTotalFactura();

        }

        private void cmbTipoFactura_TextChanged(object sender, EventArgs e)
        {
            switch (cmbTipoAgente.Text)
            {
                case "OTRO":
                    txtOtro.Visible = true;
                    lineaOtro.Visible = true; 
                    break;
                default:
                    txtOtro.Visible = false;
                    lineaOtro.Visible = false;
                    break;
            }
        }

        private void txtOtro_Enter(object sender, EventArgs e)
        {
            if (txtOtro.Text == "Otro...")
            {
                txtOtro.Text = "";
                txtOtro.ForeColor = Color.LightGray;
            }
        }

        private void txtOtro_Leave(object sender, EventArgs e)
        {
            if (txtOtro.Text == "")
            {
                txtOtro.Text = "Otro...";
                txtOtro.ForeColor = Color.DimGray;
            }
        }

        private void panelGeneral_Resize(object sender, EventArgs e)
        {
            /*
            panelTitulo.Width = this.Width - 30;
            panelSubitulo.Width = this.Width - 30;
            panelDatos.Width = this.Width - 30;

            panelTotal.Width = (this.Width - 34) * 4/7;
            panelIVA.Width = (this.Width - 34) * 3/7;

            panelRetencion.Width = panelGeneral.Width - 30;

            panelValRetencion.Width = this.Width / 2 - SystemInformation.VerticalScrollBarWidth;
            panelPorcentajeRetencion.Width = panelTitulo.Width - panelValRetencion.Width;
            panelValIVA.Width = (this.Width - 36) / 2;
            panelPorcentajeIVA.Width = panelTitulo.Width - panelValIVA.Width;
            */
        }

        private void cmbPorcentajeRetIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumeroCMB(sender, e);
        }

        private void cmbPorcentajeRetRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumeroCMB(sender, e);
        }

        private void cmbIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumeroCMB(sender, e);
        }

        private void cmbPorcentajeRetRenta_TextChanged(object sender, EventArgs e)
        {
            calcularTotalFactura();

        }

        private void cmbPorcentajeRetIVA_TextChanged(object sender, EventArgs e)
        {
            calcularTotalFactura();
        }

        private void cmbIVA_TextChanged(object sender, EventArgs e)
        {
            calcularTotalFactura();
        }

        private void comprobarNumero(object sender, KeyPressEventArgs e)
        {
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

        private void comprobarNumeroCMB(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if ((e.KeyChar == ',') && ((sender as ComboBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }



        string[] values = new string[16];
        public bool editar = false;

        public string[] dataFactura()
        {
            values[1] = txtEmpresa.Text;
            values[2] = txtNFactura.Text;

            if (cmbTipoAgente.Text == "LDM")
            {
                values[3] = cmbTipoAgente.Text;
            }
            else
            {
                values[3] = txtOtro.Text;
            }

            values[4] = txtComision.Text;
            values[5] = txtTotalFactura.Text;
            values[6] = cmbIVA.Text;
            values[7] = txtValIVA.Text;

            values[8] = txtNumeroRetencion.Text;
            values[9] = cmbPorcentajeRetRenta.Text;
            values[10] = txtValorRetencioRenta.Text;
            values[11] = cmbPorcentajeRetIVA.Text;
            values[12] = txtValorRetencionIVA.Text;
            values[13] = txtTotalRetencion.Text;

            values[14] = txtValorCobrarFactura.Text;
            values[15] = ComisionesCache.nTramite.ToString();


            for (int i = 4; i < values.Length; i++)
            {
                if (i == 8) continue; 
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


        private bool hayFactura()
        {
            UserModel Read = new UserModel();
            if (txtNFactura.Text != "")
            {
                return Read.searchFacturaComision(txtNFactura.Text);
            }
            else
            {
                return true; 
            }

        }

        private void txtNFactura_Leave(object sender, EventArgs e)
        {
            if (hayFactura())
            {
                txtNFactura.ForeColor = Color.FromArgb(187, 42, 89);
                lblFacturaNoValida.Visible = true;
            }
            else
            {
                txtNFactura.ForeColor = Color.White;
                lblFacturaNoValida.Visible = false;
            }
            
        }

        private void FormCrearComisionFactura_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 6;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UserModel Write = new UserModel();

            DialogResult result = MessageBox.Show(
                                  "Seuro desea guardar la factura ?",
                                  "Info.",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Information);
            
            if (result == DialogResult.Yes)
            {
                if (!hayFactura())
                {
                    if (Write.InsertDataFacturaComision(dataFactura()))
                    {
                        DialogResult resultS = MessageBox.Show("La factura: " + values[2] +
                                                                "\n\nSe ha guardado exitosamente" ,
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
                        MessageBox.Show("No ha sido posible guardar la factura\n" +
                                        "Por favor, inténtelo mas tarde.",
                                        "Alerta",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (txtNFactura.Text != "")
                    {
                        MessageBox.Show("El número de factura ingresado ya existe."+
                                        "\nPor favor, ingrese una factura nueva.",
                                        "Info.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);

                        txtNFactura.ForeColor = Color.FromArgb(187, 42, 89);
                    }
                    else
                    {
                        MessageBox.Show("El número de factura no puede ser nulo.",
                                        "Info.",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }

                    txtNFactura.Focus();

                }
            }
        }

    }
}
