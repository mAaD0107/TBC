using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormCrearFactura : Form
    {
        public FormCrearFactura()
        {
            InitializeComponent();
        }

        private void FormCrearFactura_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
            btnGuardar.Left = (btnGuardar.Parent.Width / 2) - (btnGuardar.Width / 2);
        }

        private void FormCrearFactura_Load(object sender, EventArgs e)
        {
            readClientes();
            readTipoFactura();
            readIVA();

            iniciarForm();
        }


        private void iniciarForm()
        {
            panelConceptoFactura.Visible = false;
            dateFactura.Value = DateTime.Today.AddDays(0);

        }

        double subTotal, totalFactura, ivaFactura, valorACobrar, valorIVA, totalRetencion;

        private void calcularFactura()
        {
            try
            {

                string txtSubT = txtSubtotalFactura.Text;
                txtSubT = txtSubT.Replace(".", ",");
                subTotal = double.Parse(txtSubT);

                string iva = cmbIVA.Text;
                iva = iva.Replace(".", ",");
                ivaFactura = double.Parse(iva);

                valorIVA = subTotal * ivaFactura / 100;

                totalFactura = subTotal + valorIVA;

                txtTotalFactura.Text = totalFactura.ToString("N2");
                txtValIVA.Text = valorIVA.ToString("N2");

                lblErrorSubTotal.Visible = false;

            }
            catch (Exception)
            {

                lblErrorSubTotal.Visible = true; 
            }
        }

        private void calcularTotalRetención()
        {
            try
            {
                //string pRetRenta = cmbPorcentajeRetRenta.GetItemText(cmbPorcentajeRetRenta.SelectedItem);
                string pRetRenta = cmbPorcentajeRetRenta.SelectedItem == null ? cmbPorcentajeRetRenta.Text : cmbPorcentajeRetRenta.GetItemText(cmbPorcentajeRetRenta.SelectedItem);
                pRetRenta = pRetRenta.Replace(".", ",");
                double valPRetRenta = double.Parse(pRetRenta);

                double valRetRenta = subTotal * valPRetRenta / 100;


                string pRetIVA = cmbPorcentajeRetIVA.SelectedItem == null ? cmbPorcentajeRetIVA.Text : cmbPorcentajeRetIVA.GetItemText(cmbPorcentajeRetIVA.SelectedItem);
                pRetIVA = pRetIVA.Replace(".", ",");
                double valPRetIVA = double.Parse(pRetIVA);

                double valRetIVA = subTotal * ivaFactura / 100 * valPRetIVA / 100;

                totalRetencion = valRetRenta + valRetIVA;

                valorACobrar = totalFactura - totalRetencion;

                txtValorRetencioRenta.Text = valRetRenta.ToString("N2");
                txtValorRetencionIVA.Text = valRetIVA.ToString("N2");
                txtTotalRetencion.Text = totalRetencion.ToString("N2");
                txtValorCobrarFactura.Text = valorACobrar.ToString("N2");
            }
            catch
            { }
        }




        private void readClientes()
        {
            UserModel Read = new UserModel();


        }


        private void readTipoFactura()
        {
            UserModel Read = new UserModel();

            //cmbTipoFactura.DataSource = Read.readTipoFactura("");
            //cmbTipoFactura.DisplayMember = "Tipo";
            //cmbTipoFactura.ValueMember = "Tipo";

            //cmbOtros.DataSource = Read.readTipoFacturaOtros();
            //cmbOtros.DisplayMember = "Tipo";
            //cmbOtros.ValueMember = "Tipo";
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

        private float valAnterior = 0, valAntAltoMenuInf = 0;
        private void FormCrearFactura_Shown(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            valAnterior = formPrincipal.panelGlobal.ColumnStyles[0].Width;
            valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;

            mostrarAlCargar();

            InterfaceCache.idImportaciones = 3;

        }

        public string empresa;
        private void mostrarAlCargar()
        {
            panelPrincipal.Visible = true;


            txtEmpresa.Focus();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
            formPrincipal.PanelSubContenedor.RowStyles[1].Height = valAntAltoMenuInf;
            formPrincipal.panelMenuVertical.Visible = true;
            formPrincipal.panelInferior.Visible = true;
            EmpresaCache.crearEmpresa = false;
            this.Close();
        }

        private bool maximized = false;
        float anchoTitulo = 0, anchoBoton = 0;

        private void dateFactura_Leave(object sender, EventArgs e)
        {
            lineShape14.BorderColor = Color.DimGray;
            dateFactura.ForeColor = Color.LightGray;
        }

        private void dateVencimiento_Enter(object sender, EventArgs e)
        {
            lineShape20.BorderColor = Color.FromArgb(187, 42, 89);
            dateVencimiento.ForeColor = Color.White;
        }

        private void dateVencimiento_Leave(object sender, EventArgs e)
        {
            lineShape20.BorderColor = Color.DimGray;
            dateVencimiento.ForeColor = Color.LightGray;
        }

        private void FormCrearFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormOpcionesFactura formOpcionesFactura = new FormOpcionesFactura();
                    formOpcionesFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formOpcionesFactura);
                    formPrincipal.AbrirFormInPanel(formOpcionesFactura);
                }
            }
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {

        }

        string valorFacturaAnterior;
        private void listaFacturas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            FormNuevoIVA formNuevoIVA = new FormNuevoIVA();
            AddOwnedForm(formNuevoIVA);
            formNuevoIVA.FormClosed += new FormClosedEventHandler(actualizarListaIVA);
            formNuevoIVA.Show();
            btnIVA.Enabled = false; 
        }

        private void actualizarListaIVA(object sender, FormClosedEventArgs e)
        {
            readIVA();
            calcularFactura();
            calcularTotalRetención();
            try
            {
                string aux = EmpresaCache.ivaFactura.Replace('.', ',');
                cmbIVA.SelectedIndex = cmbIVA.FindString(aux);
            }
            catch { }

            btnIVA.Enabled = true; 
        }

        private string tipoFactura;
        private void listaFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tipoFactura = cmbTipoFactura.SelectedItem.ToString();

            if (tipoFactura == "Otros")
            {
                panelConceptoFactura.Visible = true;
            }
            else
            {
                panelConceptoFactura.Visible = false;
            }

            if (tipoFactura == "TBC" || tipoFactura == "Agente")
            {
                cmbPorcentajeRetIVA.Visible = true;
                cmbPorcentajeRetRenta.Visible = true;

            }
            else
            {
                cmbPorcentajeRetIVA.Visible = false;
                cmbPorcentajeRetRenta.Visible = false;

            }
        }

        private void listaFacturas_Leave(object sender, EventArgs e)
        {
            tipoFactura = cmbTipoFactura.SelectedItem.ToString();

            if (tipoFactura == "Otros")
            {
                panelConceptoFactura.Visible = true;
            }
            else
            {
                panelConceptoFactura.Visible = false;
            }
        }



        private void txtSubtotalFactura_Leave(object sender, EventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();

            if (txtSubtotalFactura.Text != "")
            {
                txtSubtotalFactura.Text = double.Parse(txtSubtotalFactura.Text).ToString("N2");
            }

        }

        private void txtSubtotalFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtNumeroRetencion.Focus();
            }
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

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                calcularFactura();
                calcularTotalRetención();
            }
        }
        private void listaIVA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();
        }

        private void txtNFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroRetencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void cmbPorcentajeRetRenta_SelectedValueChanged(object sender, EventArgs e)
        {
            calcularTotalRetención();
            calcularValorACobrar();
        }

        private void cmbPorcentajeRetIVA_SelectedValueChanged(object sender, EventArgs e)
        {
            calcularTotalRetención();
            calcularValorACobrar();
        }

        private void cmbPorcentajeRetRenta_KeyPress(object sender, KeyPressEventArgs e)
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

            calcularTotalRetención();


        }

        private void cmbPorcentajeRetIVA_KeyPress(object sender, KeyPressEventArgs e)
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


            calcularTotalRetención();
        }

        private void txtDiasCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }



        private void cmbPorcentajeRetRenta_TextUpdate(object sender, EventArgs e)
        {
            calcularTotalRetención();
        }

        private void cmbPorcentajeRetRenta_Leave(object sender, EventArgs e)
        {
            string texto = cmbPorcentajeRetRenta.Text;
            
        }

        private void cmbPorcentajeRetIVA_TextUpdate(object sender, EventArgs e)
        {
            calcularTotalRetención();
        }

        private void txtSubtotalFactura_TextChanged(object sender, EventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();

        }


        private void cmbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

            readRetenciones();
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();


        }

        int diasCredito = 0;
        public void readRetenciones()
        {
            switch (cmbTipoFactura.Text)
            {
                case "Otros":
                    cmbOtros.Visible = true;
                    panelConceptoFactura.Visible = true;

                    if (cmbOtros.Text.Contains("Honorarios"))
                    {
                        txtDiasCredito.Text = TramiteCache.diasCreditoFacturaTBC.ToString();
                    }

                    break;

                case "Agente":
                    cmbPorcentajeRetIVA.Text = TramiteCache.porcentajeRetIVAAgente.ToString();
                    cmbPorcentajeRetRenta.Text = TramiteCache.porcentajeRetRentaAgente.ToString();

                    txtDiasCredito.Text = TramiteCache.diasCreditoFacturaAgente.ToString();

                    cmbPorcentajeRetIVA.Enabled = false;
                    cmbPorcentajeRetRenta.Enabled = false;
                    break;

                case "TBC":
                    cmbPorcentajeRetIVA.Text = TramiteCache.porcentajeRetIVATBC.ToString();
                    cmbPorcentajeRetRenta.Text = TramiteCache.porcentajeRetRentaTBC.ToString();

                    txtDiasCredito.Text = TramiteCache.diasCreditoFacturaTBC.ToString();

                    cmbPorcentajeRetIVA.Enabled = false;
                    cmbPorcentajeRetRenta.Enabled = false;
                    break;

                case "Transporte":

                    txtDiasCredito.Text = TramiteCache.diasCreditoTransporte.ToString();

                    break;

                default:
                    
                    txtDiasCredito.Text = TramiteCache.diasCreditoGastos.ToString();

                    cmbPorcentajeRetIVA.Enabled = true;
                    cmbPorcentajeRetRenta.Enabled = true;
                    break;
            }

            if (cmbTipoFactura.Text == "Otros")
            {
                cmbOtros.Visible = true;
                panelConceptoFactura.Visible = true;
            }
            else
            {
                txtConceptoFactura.Text = "";
                cmbOtros.Visible = false;
                panelConceptoFactura.Visible = false;
            }

            

            if (txtDiasCredito.Text != "")
            {
                diasCredito = int.Parse(txtDiasCredito.Text);
            }
            else
            {
                diasCredito = 0;
            }

            
            dateVencimiento.Value = dateFactura.Value.AddDays(diasCredito);
        }

        private void cmbOtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelConceptoFactura.Visible = true; 
        }

        private void txtBuscarTramite_Enter(object sender, EventArgs e)
        {
            if (txtBuscarTramite.Text == "Buscar...")
            {
                txtBuscarTramite.Text = "";
                txtBuscarTramite.ForeColor = Color.White;
                txtBuscarTramite.Font = new Font(txtBuscarTramite.Font, FontStyle.Regular);
            }
        }

        private void txtBuscarTramite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                callBuscarTramite();
            }
        }


        private void Buscar_Click(object sender, EventArgs e)
        {

            txtBuscarTramite.Text = "";
            callBuscarTramite();
        }



        public bool buscarEstaAbierta = false;

        Form formAuxiliar = null;
        private void callBuscarTramite()
        {

            if (!buscarEstaAbierta)
            {
                FormBuscarTramite formBuscarTramite = new FormBuscarTramite();

                formAuxiliar = formBuscarTramite;

                AddOwnedForm(formBuscarTramite);

                formBuscarTramite.Size = new Size(Screen.PrimaryScreen.Bounds.Width * 80 / 100, Screen.PrimaryScreen.Bounds.Height * 80 / 100);
                formBuscarTramite.Opacity = 0.95;
                formBuscarTramite.StartPosition = FormStartPosition.CenterScreen;
                formBuscarTramite.txtBuscar.Text = txtBuscarTramite.Text;
                formBuscarTramite.buscarTramite = true;
                formBuscarTramite.maximizar.Visible = false;
                formBuscarTramite.panelBtnDer.Visible = false;
                formBuscarTramite.panelBtnIzq.Visible = false;
                formBuscarTramite.minimizar.Visible = true;
                formBuscarTramite.Show();

                buscarEstaAbierta = true;
            }
            else
            {
                formAuxiliar.BringToFront();
                formAuxiliar.WindowState = FormWindowState.Normal;
            }


        }

        private void cmbIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSubtotalFactura.Text != "")
            {
                calcularFactura();
                calcularTotalRetención();
                calcularValorACobrar();
            }
        }

        private void BtnEliminarIVA_Click(object sender, EventArgs e)
        {
            string IVA = cmbIVA.Text;
            DialogResult result = MessageBox.Show(
                                  "Está seguro que desea eliminar el IVA: " + IVA + "%",
                                  "Info",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                UserModel Read = new UserModel();

                if (Read.deleteIVA(double.Parse(IVA)))
                {
                    MessageBox.Show("El IVA se ha eliminado correctamente","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    readIVA();
                }
                else
                {
                    MessageBox.Show("No ha sido posible eliminar el IVA seleccionado\n" +
                                    "Por favor, intentelo en otro momento",
                                    "Info", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void txtIVANotCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtSubTotalNotCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtSubTotalNotCredito_TextChanged(object sender, EventArgs e)
        {
            calcularValorACobrar();
        }

        double totNotaCredito, ivaNotCredito, subTotalNotCredito, valorCobrar;


        private void dateFactura_onValueChanged(object sender, EventArgs e)
        {
            readRetenciones();
        }

        private void cmbTipoFactura_SelectedValueChanged(object sender, EventArgs e)
        {
            readRetenciones();
        }

        private void cmbOtros_SelectedValueChanged(object sender, EventArgs e)
        {
            readRetenciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cmbTipoFactura.Text != "" && cmbOtros.Text != "")
            {
                if (valorACobrar >= 0)
                {
                    UserModel model = new UserModel();

                    DialogResult result = MessageBox.Show(
                                          "Está seguro que desea guardar la factura",
                                          "Info",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        if (validarNumeroFactura())
                        {
                            if (model.InsertDataFactura(insertDataFactura()))
                            {
                                DialogResult resultS = MessageBox.Show("La factura: " + values[1] +
                                "\n\nSe ha guardado exitosamente" +
                                "\nDesea crear otra factura ?",
                                "Info",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                                FormPrincipal formPrincipal = Owner as FormPrincipal;

                                if (resultS == DialogResult.Yes)
                                {

                                    if (formPrincipal != null)
                                    {
                                        FormCrearFactura formCrearFactura = new FormCrearFactura();
                                        formCrearFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                        formCrearFactura.panelPrincipal.Visible = false;
                                        formPrincipal.AddOwnedForm(formCrearFactura);
                                        formPrincipal.AbrirFormInPanel(formCrearFactura);
                                    }
                                }
                                else
                                {
                                    if (formPrincipal != null)
                                    {
                                        FormOpcionesFactura formOpcionesFactura = new FormOpcionesFactura();
                                        formOpcionesFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                        formPrincipal.AddOwnedForm(formOpcionesFactura);
                                        formPrincipal.AbrirFormInPanel(formOpcionesFactura);
                                    }
                                }
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
                            MessageBox.Show("El Número de Factura ingresado no es válido\n" +
                            "Por favor, ingrese un Número de Factura válido.",
                            "Alerta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El valor a cobrar no puede ser menor a cero\n" +
                    "Por favor, revise los valores ingresados.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El tipo de factura seleccionada no es válido\n" +
                "Por favor, ingrese un tipo válido.",
                "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            
            
            

        }

        private bool validarNumeroFactura()
        {
            if (txtNFactura.Text != "")
            {
                bool existeFactura = searchNFactura();

                if (existeFactura)
                {
                    lblErrorNFactura.Text = "La factura ingresada ya se encuentra registrada en la base de datos";
                    lblErrorNFactura.Visible = true;
                    txtNFactura.ForeColor = Color.FromArgb(187, 42, 89);
                    lineShape46.BorderColor = Color.FromArgb(187, 42, 89);
                    return false;
                }
                else
                {
                    txtNFactura.ForeColor = Color.White;
                    lineShape46.BorderColor = Color.DimGray;
                    lblErrorNFactura.Visible = false;
                    return true;
                }

            }
            else
            {
                lblErrorNFactura.Text = "El número de factura no puede estar vacío";
                return false;
            }
        }


        private bool searchNFactura()
        {
            string NFactura = txtNFactura.Text;

            UserModel model = new UserModel();

            if (model.searchNFactura(NFactura))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        string[] values = new string[26];
        public bool editar = false;

        public string[] insertDataFactura()
        {
            values[1] = txtNFactura.Text;
            values[2] = txtEmpresa.Text;
            values[3] = txtBuscarTramite.Text;

            if (cmbOtros.Visible)
            {
                values[4] = cmbOtros.Text;
            }
            else
            {
                values[4] = cmbTipoFactura.Text;
            }
            


            values[5] = dateFactura.Value.ToString("yyyy-MM-dd");
            values[6] = txtConceptoFactura.Text;
            values[7] = txtSubtotalFactura.Text;
            values[8] = cmbIVA.Text;
            values[9] = txtValIVA.Text;
            values[10] = txtTotalFactura.Text;

            values[11] = txtNumeroRetencion.Text;
            values[12] = txtValorRetencioRenta.Text;
            values[13] = cmbPorcentajeRetRenta.Text;
            values[14] = txtValorRetencionIVA.Text;
            values[15] = cmbPorcentajeRetIVA.Text;
            values[16] = txtTotalRetencion.Text;
            
            values[17] = txtNNotaCredito.Text;
            values[18] = txtEmpresaNotCredito.Text;
            values[19] = txtSubTotalNotCredito.Text;
            values[20] = txtIVANotCredito.Text;
            values[21] = txtTotalNotCredito.Text;

            values[22] = txtValorCobrarFactura.Text;
            
            values[23] = txtDiasCredito.Text;
            values[24] = dateVencimiento.Value.ToString("yyyy-MM-dd");
            
            values[25] = txtComentarios.Text;


            for (int i = 1; i < values.Length; i++)
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

        private void txtNFactura_Leave(object sender, EventArgs e)
        {
            validarNumeroFactura();
        }

        private void txtBuscarTramite_Click(object sender, EventArgs e)
        {
            if (txtBuscarTramite.Text == "Buscar...")
            {
                txtBuscarTramite.Text = "";
                callBuscarTramite();
            }
        }

        private void txtBuscarTramite_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarTramite.Text == "Buscar...")
            {
                txtBuscarTramite.Text = "";
                callBuscarTramite();
            }
        }

        private void txtSubTotalNotCredito_Leave(object sender, EventArgs e)
        {
            if (txtSubTotalNotCredito.Text != "")
            {
                txtSubTotalNotCredito.Text = double.Parse(txtSubTotalNotCredito.Text).ToString("N2");
            }
        }

        private void txtIVANotCredito_TextChanged(object sender, EventArgs e)
        {
            calcularValorACobrar();
        }

        private void calcularValorACobrar()
        {

            if (txtSubTotalNotCredito.Text == "")
            {
                subTotalNotCredito = 0;
            }
            else
            {
                subTotalNotCredito = double.Parse(txtSubTotalNotCredito.Text);
            }

            if (txtIVANotCredito.Text == "")
            {
                ivaNotCredito = 0;
            }
            else
            {
                ivaNotCredito = double.Parse(txtIVANotCredito.Text);
            }
            
            

            totNotaCredito = subTotalNotCredito + subTotalNotCredito * ivaNotCredito / 100;
            txtTotalNotCredito.Text = totNotaCredito.ToString("N2");

            valorACobrar = totalFactura - totalRetencion - totNotaCredito; 
            txtValorCobrarFactura.Text = valorACobrar.ToString("N2");

        }

        private void txtBuscarTramite_Leave(object sender, EventArgs e)
        {
            if (txtBuscarTramite.Text == "")
            {
                txtBuscarTramite.Text = "Buscar...";
                txtBuscarTramite.ForeColor = Color.DimGray;
                txtBuscarTramite.Font = new Font(txtBuscarTramite.Font, FontStyle.Italic);
            }
        }

        private void listaIVA_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();
        }

        private void listaIVA_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();
        }



        private void cmbPorcentajeRetRenta_TextChanged(object sender, EventArgs e)
        {
            calcularTotalRetención();
        }

        private void cmbPorcentajeRetIVA_TextChanged(object sender, EventArgs e)
        {
            calcularTotalRetención();
        }

        private void dateFactura_Enter(object sender, EventArgs e)
        {
            lineShape14.BorderColor = Color.FromArgb(187, 42, 89);
            dateFactura.ForeColor = Color.White;
                
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (!maximized)
            {
                formPrincipal.panelMenuVertical.Visible = false;
                valAnterior = formPrincipal.panelGlobal.ColumnStyles[0].Width;
                valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;
                formPrincipal.panelInferior.Visible = false;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;

                anchoTitulo = panelNFactura.Width;
                anchoBoton = panelInferior.Width;
                

                panelInferior.Width = this.Width - 30;

                panelComentarios.Height += 200;


                lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2) + 15;
                btnGuardar.Left = (btnGuardar.Parent.Width / 2) - (btnGuardar.Width / 2);

                

            }
            else
            {
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = valAntAltoMenuInf;
                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelInferior.Visible = true;


                panelInferior.Width = (int)anchoBoton;

                panelComentarios.Height -= 200;


                lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
                btnGuardar.Left = (btnGuardar.Parent.Width / 2) - (btnGuardar.Width / 2);
            }


            maximized = !maximized;
        }
    }
}
