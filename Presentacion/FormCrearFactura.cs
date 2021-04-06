using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

        public int tipoForm = 0;
        public int tipoFormulario;
        /*
         * tipoForm = 0 -> Form normal
         * tipoForm = 1 -> Form editar
         * tipoForm = 2 -> Form desplegar
         */
        private void FormCrearFactura_Load(object sender, EventArgs e)
        {
            switch (tipoForm)
            {
                case 0:
                    readIVA();
                    iniciarForm();
                    break;

                case 1:
                    readIVA();
                    cargarDatos();

                    break;

                case 2:
                    break;
                default:
                    break;
            }

            desactivarScrolls();

        }

        private void desactivarScrolls()
        {
            cmbTipoFactura.MouseWheel += new MouseEventHandler(scrollsOff);
            cmbOtros.MouseWheel += new MouseEventHandler(scrollsOff);
            cmbIVA.MouseWheel += new MouseEventHandler(scrollsOff);
            cmbIVA2.MouseWheel += new MouseEventHandler(scrollsOff);
            cmbIVA3.MouseWheel += new MouseEventHandler(scrollsOff);
            cmbPorcentajeRetRenta.MouseWheel += new MouseEventHandler(scrollsOff);
            cmbPorcentajeRetIVA.MouseWheel += new MouseEventHandler(scrollsOff);
        }

        private void scrollsOff(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }


        private void iniciarForm()
        {
            //panelConceptoFactura.Visible = false;
            dateFactura.Value = DateTime.Today.AddDays(0);

        }

        public string tipoFact, valIVA1, valIVA2, valIVA3, valRetRenta, valRetIVA;

        private void cargarDatos()
        {
            if (tipoFact != "Otros")
            {
                cmbOtros.Visible = false;
                panelConceptoFactura.Visible = false;
            }
            else
            {
                cmbOtros.Visible = true;
                panelConceptoFactura.Visible = true;
            }

            UserModel Read = new UserModel();

            List<string> tipoFactura = new List<string>();
            List<string> tipoFacturaOtros = new List<string>();

            int n = obtenerNTramite(FacturaCache.ID_Tramite);

            string[] array = Read.readTipoFactura(n).ToArray();
            int indice = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "Otros")
                {
                    indice = i;
                    break;
                }
            }

            tipoFactura.Add(tipoFact);
            for (int i = 0; i <= indice; i++)
            {
                tipoFactura.Add(array[i]);
            }

            for (int i = indice + 1; i < array.Length; i++)
            {
                tipoFacturaOtros.Add(array[i]);
            }

            cmbTipoFactura.DataSource = tipoFactura;
            cmbOtros.DataSource = tipoFacturaOtros;

            cmbIVA.SelectedIndex = cmbIVA.FindString(valIVA1);
            cmbIVA2.SelectedIndex = cmbIVA2.FindString(valIVA2);
            cmbIVA3.SelectedIndex = cmbIVA3.FindString(valIVA3);

            cmbPorcentajeRetRenta.SelectedIndex = cmbPorcentajeRetRenta.FindString(valRetRenta);
            cmbPorcentajeRetIVA.SelectedIndex = cmbPorcentajeRetIVA.FindString(valRetIVA);

            if (cmbTipoFactura.Text == "Otros")
            {
                panelConceptoFactura.Visible = true;
            }
            else
            {
                panelConceptoFactura.Visible = false;
            }

        }



        private int obtenerNTramite(string ID_Tramite)
        {
            string[] texto = ID_Tramite.Split(new string[] { "-" }, StringSplitOptions.None);
            return int.Parse(texto[1]);
        }




        Decimal subTotal, totalFactura, ivaFactura, valorACobrar, valorIVA, totalRetencion;
        Decimal subTotal2, porcentajeIVA2, valorIVA2;
        Decimal subTotal3, porcentajeIVA3, valorIVA3;

        private void calcularFactura()
        {
            try
            {

                string txtSubT = txtSubtotalFactura.Text;
                //txtSubT = txtSubT.Replace(".", ",");
                if (txtSubT == "") txtSubT = "0";
                 subTotal = Decimal.Parse(txtSubT);

                if (txtSubT2.Text == "") txtSubT2.Text = "0";
                if (cmbIVA2.Text == "") cmbIVA2.Text = "0";
                subTotal2 = Decimal.Parse(txtSubT2.Text);

                if (Decimal.TryParse(cmbIVA2.Text, out porcentajeIVA2))
                {
                    porcentajeIVA2 = Decimal.Parse(cmbIVA2.Text);
                }
                else
                {
                    porcentajeIVA2 = 0;
                }


                if (txtSubT3.Text == "") txtSubT3.Text = "0";
                if (cmbIVA3.Text == "") cmbIVA3.Text = "0";
                subTotal3 = Decimal.Parse(txtSubT3.Text);
                //porcentajeIVA3 = double.Parse(cmbIVA3.Text);

                if (Decimal.TryParse(cmbIVA3.Text, out porcentajeIVA3))
                {
                    porcentajeIVA3 = Decimal.Parse(cmbIVA3.Text);
                }
                else
                {
                    porcentajeIVA3 = 0;
                }

                string iva = cmbIVA.Text;

                if (Decimal.TryParse(cmbIVA.Text, out ivaFactura))
                {
                    ivaFactura = Decimal.Parse(iva);
                }
                else
                {
                    ivaFactura = 0;
                }
                

                valorIVA = subTotal * ivaFactura / 100m;
                //valorIVA = Math.Ceiling(valorIVA * 100) / 100;
                valorIVA = Math.Round(valorIVA, 2, MidpointRounding.AwayFromZero);
                valorIVA2 = subTotal2 * porcentajeIVA2 / 100m;
                //valorIVA2 = Math.Ceiling(valorIVA2 * 100) / 100;
                valorIVA2 = Math.Round(valorIVA2, 2, MidpointRounding.AwayFromZero);
                valorIVA3 = subTotal3 * porcentajeIVA3 / 100m;
                //valorIVA3 = Math.Ceiling(valorIVA3 * 100) / 100;
                valorIVA3 = Math.Round(valorIVA3, 2, MidpointRounding.AwayFromZero);

                totalFactura = subTotal + valorIVA + subTotal2 + valorIVA2 + subTotal3 + valorIVA3;

                txtTotalFactura.Text = totalFactura.ToString("N2");
                txtValIVA.Text = valorIVA.ToString("N2");
                txtValIVA2.Text = valorIVA2.ToString("N2");
                txtValIVA3.Text = valorIVA3.ToString("N2");



                lblErrorSubTotal.Visible = false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                lblErrorSubTotal.Visible = true; 
            }
        }

        private void calcularTotalRetención()
        {
            try
            {
                //string pRetRenta = cmbPorcentajeRetRenta.GetItemText(cmbPorcentajeRetRenta.SelectedItem);
                string pRetRenta = cmbPorcentajeRetRenta.SelectedItem == null ? cmbPorcentajeRetRenta.Text : cmbPorcentajeRetRenta.GetItemText(cmbPorcentajeRetRenta.SelectedItem);
                //pRetRenta = pRetRenta.Replace(".", ",");
                Decimal valPRetRenta = Decimal.Parse(pRetRenta);

                // MessageBox.Show(valPRetRenta.ToString());

                Decimal valRetRenta = subTotal * valPRetRenta / 100m;
                //valRetRenta = Math.Ceiling(valRetRenta * 100) / 100;
                valRetRenta = Math.Round(valRetRenta, 2, MidpointRounding.AwayFromZero);

                string pRetIVA = cmbPorcentajeRetIVA.SelectedItem == null ? cmbPorcentajeRetIVA.Text : cmbPorcentajeRetIVA.GetItemText(cmbPorcentajeRetIVA.SelectedItem);
                Decimal valPRetIVA = Decimal.Parse(pRetIVA);

                //Decimal valRetIVA = subTotal * ivaFactura / 100m * valPRetIVA / 100m;
                Decimal valRetIVA = valorIVA * valPRetIVA / 100m;

                valRetIVA = Math.Round(valRetIVA, 2, MidpointRounding.AwayFromZero);

                totalRetencion = valRetRenta + valRetIVA;
                totalRetencion = Math.Round(totalRetencion, 2, MidpointRounding.AwayFromZero);

                valorACobrar = totalFactura - totalRetencion;
                valorACobrar = Math.Round(valorACobrar, 2, MidpointRounding.AwayFromZero);

                txtValorRetencioRenta.Text = valRetRenta.ToString("N2");
                txtValorRetencionIVA.Text = valRetIVA.ToString("N2");
                txtTotalRetencion.Text = totalRetencion.ToString("N2");
                txtValorCobrarFactura.Text = valorACobrar.ToString("N2");
            }
            catch
            { }
        }





        private void readIVA()
        {
            UserModel Read = new UserModel();

            cmbIVA.DataSource = Read.readIVA();
            cmbIVA.DisplayMember = "Porcentaje";
            cmbIVA.ValueMember = "Porcentaje";

            cmbIVA2.DataSource = Read.readIVA();
            cmbIVA2.DisplayMember = "Porcentaje";
            cmbIVA2.ValueMember = "Porcentaje";

            cmbIVA3.DataSource = Read.readIVA();
            cmbIVA3.DisplayMember = "Porcentaje";
            cmbIVA3.ValueMember = "Porcentaje";


            cmbPorcentajeRetRenta.DataSource = Read.readRetencionRenta();
            cmbPorcentajeRetRenta.DisplayMember = "Porcentaje";
            cmbPorcentajeRetRenta.ValueMember = "Porcentaje";


            cmbPorcentajeRetIVA.DataSource = Read.readRetencionIVA();
            cmbPorcentajeRetIVA.DisplayMember = "Porcentaje";
            cmbPorcentajeRetIVA.ValueMember = "Porcentaje";
        }

        private float valAnterior = 0, valAntAltoMenuInf = 0;
        public bool mostrarFactura = false;
        private void FormCrearFactura_Shown(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (!mostrarFactura)
            {
                valAnterior = formPrincipal.panelGlobal.ColumnStyles[0].Width;
                valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;
            }


            mostrarAlCargar();

            InterfaceCache.idImportaciones = 3;

        }

        public string empresa;
        private void mostrarAlCargar()
        {
            panelPrincipal.Visible = true;


            //txtEmpresa.Focus();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (!mostrarFactura)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = valAntAltoMenuInf;
                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelInferior.Visible = true;
                EmpresaCache.crearEmpresa = false;
            }

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

                if (!editar)
                {
                    if (formPrincipal != null)
                    {
                        FormOpcionesFactura formOpcionesFactura = new FormOpcionesFactura();
                        formOpcionesFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formOpcionesFactura);
                        formPrincipal.AbrirFormInPanel(formOpcionesFactura);
                    }
                }
                else
                {
                    if (formPrincipal != null)
                    {
                        FormInfoFacturasTramite formInfo = new FormInfoFacturasTramite();
                        formInfo.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formInfo.txtTramite.Text = FacturaCache.ID_Tramite;
                        formInfo.txtCliente.Text = FacturaCache.Cliente;
                        formInfo.txtDAI.Text = FacturaCache.DAI;
                        formInfo.txtSecuencialCliente.Text = FacturaCache.SecuencialCliente;
                        if (tipoFormulario == 0)
                        {
                            formInfo.tipoFormulario = 0;
                        }
                        else
                        {
                            formInfo.tipoFormulario = 1;
                        }
                        formPrincipal.AddOwnedForm(formInfo);
                        formPrincipal.AbrirFormInPanel(formInfo);
                    }
                }

            }
            
        }


        private int estadoIVA;
        private void btnIVA_Click(object sender, EventArgs e)
        {
            FormNuevoIVA formNuevoIVA = new FormNuevoIVA();
            AddOwnedForm(formNuevoIVA);
            formNuevoIVA.FormClosed += new FormClosedEventHandler(actualizarListaIVA);
            formNuevoIVA.tipoIVA = 1;
            estadoIVA = 1;
            formNuevoIVA.Show();
            btnIVA.Enabled = false; 
        }

        private void btnAgregarIVARetRenta_Click(object sender, EventArgs e)
        {
            FormNuevoIVA formNuevoIVA = new FormNuevoIVA();
            AddOwnedForm(formNuevoIVA);
            formNuevoIVA.FormClosed += new FormClosedEventHandler(actualizarListaIVA);
            formNuevoIVA.tipoIVA = 2;
            estadoIVA = 2;
            formNuevoIVA.Show();
            btnAgregarIVARetRenta.Enabled = false;
        }

        private void btnAgregarIVARetIVA_Click(object sender, EventArgs e)
        {
            FormNuevoIVA formNuevoIVA = new FormNuevoIVA();
            AddOwnedForm(formNuevoIVA);
            formNuevoIVA.FormClosed += new FormClosedEventHandler(actualizarListaIVA);
            formNuevoIVA.tipoIVA = 3;
            estadoIVA = 3;
            formNuevoIVA.Show();
            btnAgregarIVARetIVA.Enabled = false;
        }

        private void actualizarListaIVA(object sender, FormClosedEventArgs e)
        {
            readIVA();
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();
            try
            {

                switch (estadoIVA)
                {
                    case 1:
                        btnIVA.Enabled = true;
                        break;
                    case 2:
                        btnAgregarIVARetRenta.Enabled = true;
                        break;
                    case 3:

                        btnAgregarIVARetIVA.Enabled = true;
                        break;
                    default:
                        break;
                }
                
                if (EmpresaCache.ivaFactura != null) cmbIVA.Text = EmpresaCache.ivaFactura;
                if (EmpresaCache.ivaRetRenta != null) cmbPorcentajeRetRenta.Text = EmpresaCache.ivaRetRenta;
                if (EmpresaCache.ivaRetIVA != null) cmbPorcentajeRetIVA.Text = EmpresaCache.ivaRetIVA;
            }
            catch { }

            
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
            formatearTexto();
        }


        private void formatearTexto()
        {
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();

            if (txtSubtotalFactura.Text != "")
            {
                txtSubtotalFactura.Text = double.Parse(txtSubtotalFactura.Text).ToString("N2");
            }

            if (txtSubT2.Text != "")
            {
                txtSubT2.Text = double.Parse(txtSubT2.Text).ToString("N2");
            }

            if (txtSubT3.Text != "")
            {
                txtSubT3.Text = double.Parse(txtSubT3.Text).ToString("N2");
            }

            if (txtSubTotalNotCredito.Text != "")
            {
                txtSubTotalNotCredito.Text = double.Parse(txtSubTotalNotCredito.Text).ToString("N2");
            }

            if (txtIVANotCredito.Text != "")
            {
                txtIVANotCredito.Text = double.Parse(txtIVANotCredito.Text).ToString("N2");
            }

            if (txtSubTotalNotCreditoII.Text != "")
            {
                txtSubTotalNotCreditoII.Text = double.Parse(txtSubTotalNotCreditoII.Text).ToString("N2");
            }

            if (txtIVANotCreditoII.Text != "")
            {
                txtIVANotCreditoII.Text = double.Parse(txtIVANotCreditoII.Text).ToString("N2");
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
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
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
            calcularValorACobrar();

        }


        private void cmbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            readRetenciones();
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();
            */

        }

        int diasCredito = 0;
        public void readRetenciones()
        {
            // UserModel Read = new UserModel();  
            // Read.searchRetenciones(TramiteCache.rucEmpresa);
            // MessageBox.Show("Leyo las retenciones");

            UserModel Read = new UserModel();
            Read.searchRetenciones(txtCliente.Text);

            switch (cmbTipoFactura.Text)
            {
                case "Otros":
                    cmbOtros.Visible = true;
                    panelConceptoFactura.Visible = true;

                    if (cmbOtros.Text.Contains("Honorarios"))
                    {
                        txtDiasCredito.Text = TramiteCache.diasCreditoFacturaTBC.ToString();
                    }else if (cmbOtros.Text.Contains("Transporte_I"))
                    {
                        txtDiasCredito.Text = TramiteCache.diasCreditoTransporte.ToString();
                    }else  if (cmbOtros.Text.Contains("Transporte_II"))
                    {
                        txtDiasCredito.Text = TramiteCache.diasCreditoTransporte.ToString();
                    }else if (cmbOtros.Text.Contains("Transporte_III"))
                    {
                        txtDiasCredito.Text = TramiteCache.diasCreditoTransporte.ToString();
                    }
                    else
                    {
                        txtDiasCredito.Text = TramiteCache.diasCreditoGastos.ToString();
                    }
                    break;

                case "Agente":
                    cmbPorcentajeRetIVA.Text = TramiteCache.porcentajeRetIVAAgente.ToString();
                    cmbPorcentajeRetRenta.Text = TramiteCache.porcentajeRetRentaAgente.ToString();

                    txtDiasCredito.Text = TramiteCache.diasCreditoFacturaAgente.ToString();

                    //cmbPorcentajeRetIVA.Enabled = true;
                    //cmbPorcentajeRetRenta.Enabled = false;
                    break;


                case "Agente_LDM":
                    cmbPorcentajeRetIVA.Text = TramiteCache.porcentajeRetIVAAgente.ToString();
                    cmbPorcentajeRetRenta.Text = TramiteCache.porcentajeRetRentaAgente.ToString();

                    txtDiasCredito.Text = TramiteCache.diasCreditoFacturaAgente.ToString();

                    //cmbPorcentajeRetIVA.Enabled = true;
                    //cmbPorcentajeRetRenta.Enabled = false;
                    break;

                case "TBC":
                    cmbPorcentajeRetIVA.Text = TramiteCache.porcentajeRetIVATBC.ToString();
                    cmbPorcentajeRetRenta.Text = TramiteCache.porcentajeRetRentaTBC.ToString();

                    txtDiasCredito.Text = TramiteCache.diasCreditoFacturaTBC.ToString();

                    //cmbPorcentajeRetIVA.Enabled = false;
                    //cmbPorcentajeRetRenta.Enabled = false;
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

        private void btnEliminarIVARetRenta_Click(object sender, EventArgs e)
        {
            string IVA = cmbPorcentajeRetRenta.Text;
            DialogResult result = MessageBox.Show(
                                  "Está seguro que desea eliminar el Porcentaje Retención Renta: " + IVA + "%",
                                  "Info",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                UserModel Read = new UserModel();

                if (Read.deleteRetRenta(double.Parse(IVA)))
                {
                    MessageBox.Show("El Porcentaje Retención Renta se ha eliminado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    readIVA();
                }
                else
                {
                    MessageBox.Show("No ha sido posible eliminar el Porcentaje Retención Renta seleccionado\n" +
                                    "Por favor, intentelo en otro momento",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminarIVARetIVA_Click(object sender, EventArgs e)
        {
            string IVA = cmbPorcentajeRetIVA.Text;
            DialogResult result = MessageBox.Show(
                                  "Está seguro que desea eliminar la Retención IVA: " + IVA + "%",
                                  "Info",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                UserModel Read = new UserModel();

                if (Read.deleteRetIVA(double.Parse(IVA)))
                {
                    MessageBox.Show("La Retención IVA se ha eliminado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    readIVA();
                }
                else
                {
                    MessageBox.Show("No ha sido posible eliminar la Retencion IVA seleccionada\n" +
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

        Decimal totNotaCredito, ivaNotCredito, subTotalNotCredito;
        Decimal totNotaCreditoII, ivaNotCreditoII, subTotalNotCreditoII;


        private void dateFactura_onValueChanged(object sender, EventArgs e)
        {
            readRetenciones();
        }

        private void cmbTipoFactura_SelectedValueChanged(object sender, EventArgs e)
        {
           // readRetenciones();
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
                    DialogResult result;

                    if (!editar)
                    {
                        result = MessageBox.Show(
                        "Está seguro que desea guardar la factura",
                        "Info",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        result = MessageBox.Show(
                        "Está seguro que desea guardar los cambios",
                        "Info",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation);
                    }

                    FormPrincipal formPrincipal = Owner as FormPrincipal;

                    if (result == DialogResult.Yes)
                    {
                        if (validarNumeroFactura() || editar)
                        {
                            if (model.InsertDataFactura(insertDataFactura()))
                            {
                                desplegarFactura();

                                if (!editar)
                                {
                                    DialogResult resultS = MessageBox.Show("La factura: " + values[1] +
                                "\n\nSe ha guardado exitosamente" +
                                "\nDesea crear otra factura del mismo trámite?",
                                "Info",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);


                                    if (resultS == DialogResult.Yes)
                                    {

                                        //desplegarFactura();

                                        if (formPrincipal != null)
                                        {
                                            FormCrearFactura formCrearFactura = new FormCrearFactura();
                                            formCrearFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                            formCrearFactura.panelPrincipal.Visible = false;

                                            formCrearFactura.txtBuscarTramite.Text = TramiteCache.idTramite;
                                            formCrearFactura.txtBuscarTramite.TextAlign = HorizontalAlignment.Center;
                                            using (Font font = new Font("Century Gothic", 14.0f)) formCrearFactura.txtBuscarTramite.Font = font;
                                            formCrearFactura.txtBuscarTramite.ForeColor = Color.White;
                                            formCrearFactura.txtBuscarTramite.Enabled = false;
                                            formCrearFactura.txtBuscarTramite.Enabled = false;

                                            formCrearFactura.txtDAI.Text = TramiteCache.DAI;
                                            formCrearFactura.txtSecuencialCliente.Text = TramiteCache.secuencialCliente;
                                            formCrearFactura.txtCliente.Text = TramiteCache.rucEmpresa;
                                            UserModel Read = new UserModel();

                                            Read.searchRetenciones(TramiteCache.rucEmpresa);


                                            List<string> tipoFactura = new List<string>();
                                            List<string> tipoFacturaOtros = new List<string>();

                                            string[] array = Read.readTipoFactura(TramiteCache.nTramite).ToArray();
                                            int indice = 0;

                                            for (int i = 0; i < array.Length; i++)
                                            {
                                                if (array[i] == "Otros")
                                                {
                                                    indice = i;
                                                    break;
                                                }
                                            }

                                            for (int i = 0; i <= indice; i++)
                                            {
                                                tipoFactura.Add(array[i]);
                                            }

                                            for (int i = indice + 1; i < array.Length; i++)
                                            {
                                                tipoFacturaOtros.Add(array[i]);
                                            }

                                            formCrearFactura.cmbTipoFactura.DataSource = tipoFactura;
                                            formCrearFactura.cmbOtros.DataSource = tipoFacturaOtros;


                                            formCrearFactura.readRetenciones();
                                            formCrearFactura.buscarEstaAbierta = false;



                                            formPrincipal.AddOwnedForm(formCrearFactura);
                                            formPrincipal.AbrirFormInPanel(formCrearFactura);


                                        }
                                    }
                                    else
                                    {
                                        DialogResult resultS2 = MessageBox.Show(
                                                                                "Desea crear una factura ?",
                                                                                "Info",
                                                                                MessageBoxButtons.YesNo,
                                                                                MessageBoxIcon.Information);
                                        if (resultS2 == DialogResult.Yes)
                                        {
                                            if (formPrincipal != null)
                                            {
                                                FormCrearFactura formCrearFactura1 = new FormCrearFactura();
                                                formCrearFactura1.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                                formPrincipal.AddOwnedForm(formCrearFactura1);
                                                formPrincipal.AbrirFormInPanel(formCrearFactura1);
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
                                }
                                else
                                {

                                    DialogResult resultS = MessageBox.Show("La factura: " + values[1] +
                                    "\n\nSe ha guardado exitosamente",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

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



        private void desplegarFactura()
        {
            FormCrearFactura formCrearFactura = new FormCrearFactura();

            formCrearFactura.txtBuscarTramite.Text = TramiteCache.idTramite;
            formCrearFactura.txtBuscarTramite.TextAlign = HorizontalAlignment.Center;
            using (Font font = new Font("Century Gothic", 14.0f)) formCrearFactura.txtBuscarTramite.Font = font;
            formCrearFactura.txtBuscarTramite.ForeColor = Color.White;
            formCrearFactura.txtBuscarTramite.Enabled = false;
            formCrearFactura.txtBuscarTramite.Enabled = false;

            formCrearFactura.txtDAI.Text = txtDAI.Text;
            formCrearFactura.txtSecuencialCliente.Text = txtSecuencialCliente.Text;
            formCrearFactura.txtCliente.Text = txtCliente.Text;

            formCrearFactura.txtNFactura.Text = txtNFactura.Text;
            formCrearFactura.txtEmpresa.Text = txtEmpresa.Text;
            formCrearFactura.txtBuscarTramite.Text = txtBuscarTramite.Text;
            //values[3] = TramiteCache.nTramite.ToString("D5");

            formCrearFactura.cmbTipoFactura.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbOtros.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbIVA.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbIVA2.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbIVA3.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbPorcentajeRetRenta.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbPorcentajeRetIVA.DropDownStyle = ComboBoxStyle.DropDown;
            formCrearFactura.cmbOtros.DropDownStyle = ComboBoxStyle.DropDown;

            if (cmbOtros.Visible)
            {
                formCrearFactura.cmbOtros.Text = cmbOtros.Text;
                formCrearFactura.cmbTipoFactura.Text = cmbTipoFactura.Text;
                formCrearFactura.panelConceptoFactura.Visible = true;
            }
            else
            {

                formCrearFactura.cmbTipoFactura.Text = cmbTipoFactura.Text;
            }



            formCrearFactura.dateFactura.Value = dateFactura.Value;
            formCrearFactura.txtConceptoFactura.Text = txtConceptoFactura.Text;
            formCrearFactura.txtSubtotalFactura.Text = txtSubtotalFactura.Text;
            formCrearFactura.cmbIVA.Text = cmbIVA.Text;
            formCrearFactura.txtValIVA.Text = txtValIVA.Text;
            formCrearFactura.txtTotalFactura.Text = txtTotalFactura.Text;

            formCrearFactura.txtNumeroRetencion.Text = txtNumeroRetencion.Text;
            formCrearFactura.txtValorRetencioRenta.Text = txtValorRetencioRenta.Text;
            formCrearFactura.cmbPorcentajeRetRenta.Text = cmbPorcentajeRetRenta.Text;
            formCrearFactura.txtValorRetencionIVA.Text = txtValorRetencionIVA.Text;
            formCrearFactura.cmbPorcentajeRetIVA.Text = cmbPorcentajeRetIVA.Text;
            formCrearFactura.txtTotalRetencion.Text = txtTotalRetencion.Text;

            formCrearFactura.txtNNotaCredito.Text = txtNNotaCredito.Text;
            formCrearFactura.txtEmpresaNotCredito.Text = txtEmpresaNotCredito.Text;
            formCrearFactura.txtSubTotalNotCredito.Text = txtSubTotalNotCredito.Text;
            formCrearFactura.txtIVANotCredito.Text = txtIVANotCredito.Text;
            formCrearFactura.txtTotalNotCredito.Text = txtTotalNotCredito.Text;

            formCrearFactura.txtValorCobrarFactura.Text = txtValorCobrarFactura.Text;

            formCrearFactura.txtDiasCredito.Text = txtDiasCredito.Text;
            formCrearFactura.dateVencimiento.Value = dateVencimiento.Value;

            formCrearFactura.txtComentarios.Text = values[25];


            formCrearFactura.txtSubT2.Text = txtSubT2.Text;
            formCrearFactura.cmbIVA2.Text = cmbIVA2.Text;
            formCrearFactura.txtValIVA2.Text = txtValIVA2.Text;
            formCrearFactura.txtSubT3.Text = txtSubT3.Text;
            formCrearFactura.cmbIVA3.Text = cmbIVA3.Text;
            formCrearFactura.txtValIVA3.Text = txtValIVA3.Text;


            formCrearFactura.txtNNotaCreditoII.Text = txtNNotaCreditoII.Text;
            formCrearFactura.txtEmpresaNotCreditoII.Text = txtEmpresaNotCreditoII.Text;
            formCrearFactura.txtSubTotalNotCreditoII.Text = txtSubTotalNotCreditoII.Text;
            formCrearFactura.txtIVANotCreditoII.Text = txtIVANotCreditoII.Text;

            formCrearFactura.mostrarFactura = true;

            formCrearFactura.btnIVA.Visible = false;
            formCrearFactura.BtnEliminarIVA.Visible = false;
            formCrearFactura.panelAgregarSubtotal.Visible = false;
            formCrearFactura.panelBotonesNotaCredito.Visible = false;
            formCrearFactura.panelInferior.Visible = false;


            if (double.TryParse(txtSubT2.Text, out double val))
            {
                if (val != 0)
                {
                    formCrearFactura.panelSubT2.Visible = true;
                    formCrearFactura.panelIVA2.Visible = true;
                }
                else
                {
                    formCrearFactura.panelSubT2.Visible = false;
                    formCrearFactura.panelIVA2.Visible = false;
                }

            }
            else
            {
                formCrearFactura.panelSubT2.Visible = false;
                formCrearFactura.panelIVA2.Visible = false;
            }

            if (double.TryParse(txtSubT3.Text, out double val2))
            {
                if (val2 != 0)
                {
                    formCrearFactura.panelSubT3.Visible = true;
                    formCrearFactura.panelIVA3.Visible = true;
                }
                else
                {
                    formCrearFactura.panelSubT3.Visible = false;
                    formCrearFactura.panelIVA3.Visible = false;
                }

            }
            else
            {
                formCrearFactura.panelSubT3.Visible = false;
                formCrearFactura.panelIVA3.Visible = false;
            }

            if (txtNNotaCredito.Text != "" || txtSubTotalNotCredito.Text != "")
            {
                formCrearFactura.panelTNC.Visible = true;
                formCrearFactura.panelNotaCredito.Visible = true;
                formCrearFactura.panelTotalNC.Visible = true;
            }

            if (txtNNotaCreditoII.Text != "" || txtSubTotalNotCreditoII.Text != "")
            {
                formCrearFactura.panelNotaCreditoII.Visible = true;
                formCrearFactura.panelTotalNCII.Visible = true;
            }


            formCrearFactura.Opacity = 0.9;
            formCrearFactura.Height = Screen.PrimaryScreen.WorkingArea.Size.Height - 30;
            formCrearFactura.Text = "Factura: " + txtNFactura.Text;
            formCrearFactura.StartPosition = FormStartPosition.CenterScreen;
            formCrearFactura.Show();
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


        string[] values = new string[37];
        public bool editar = false;
        // Nuevos valores
        public double iva2;
        public double iva3;

        public string[] insertDataFactura()
        {
            values[1] = txtNFactura.Text;
            values[2] = txtEmpresa.Text;
            //values[3] = txtBuscarTramite.Text;
            values[3] = TramiteCache.nTramite.ToString("D5");
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

            //values[25] = txtComentarios.Text;
            String date = DateTime.Now.ToString();

            if (txtComentarios.Text != "")
            {
                values[25] = "[" + UserCache.FirstName + " " + UserCache.LastName + "  " + date + "]: \n" + txtComentarios.Text;
            }
            else
            {
                values[25] = "";
            }


  
            values[26] = txtSubT2.Text;
            if (double.TryParse(cmbIVA2.Text, out iva2))
            {
                values[27] = iva2.ToString("N2");
            }
            else
            {
                values[27] = "0";
            }

            values[28] = txtValIVA2.Text;
            values[29] = txtSubT3.Text;
            if (double.TryParse(cmbIVA3.Text, out iva3))
            {
                values[30] = iva3.ToString("N2");
            }
            else
            {
                values[30] = "0";
            }

            values[31] = txtValIVA3.Text;

            values[32] = txtNNotaCreditoII.Text;
            values[33] = txtEmpresaNotCreditoII.Text;
            values[34] = txtSubTotalNotCreditoII.Text;
            values[35] = txtIVANotCreditoII.Text;

            values[36] = txtTotalNotCreditoII.Text;

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


        int contSubtotales = 0;
        private void btnNuevoSubT_Click(object sender, EventArgs e)
        {
            contSubtotales++;
            if (contSubtotales >= 3) contSubtotales = 2;
            subtotalFacturas();

        }

        private void btnQuitarSubT_Click(object sender, EventArgs e)
        {
            contSubtotales--;
            if (contSubtotales < 0) contSubtotales = 0;
            subtotalFacturas();
        }


        private void subtotalFacturas()
        {
            switch (contSubtotales)
            {
                case 0:
                    panelSubT2.Visible = false;
                    panelIVA2.Visible = false;
                    panelSubT3.Visible = false;
                    panelIVA3.Visible = false;

                    txtSubT2.Text = "0,00";
                    txtSubT3.Text = "0,00";
                    break;

                case 1:
                    panelSubT2.Visible = true;
                    panelIVA2.Visible = true;
                    panelSubT3.Visible = false;
                    panelIVA3.Visible = false;

                    txtSubT3.Text = "0,00";
                    break;

                case 2:
                    panelSubT2.Visible = true;
                    panelIVA2.Visible = true;
                    panelSubT3.Visible = true;
                    panelIVA3.Visible = true;
                    break;
                
                default:
                    break;
            }

        }

        private void txtSubtotalFactura_MouseClick(object sender, MouseEventArgs e)
        {
            formatearTexto();
        }

        int cntNotaCredito = 0;
        private void btnAgregarNC_Click(object sender, EventArgs e)
        {
            cntNotaCredito++;
            if (cntNotaCredito >= 2) cntNotaCredito = 2;
            mostrarNotaCredito();

        }

        private void btnQuitarNC_Click(object sender, EventArgs e)
        {
            cntNotaCredito--;
            if (cntNotaCredito < 0) cntNotaCredito = 0;
            mostrarNotaCredito();
        }

        private void mostrarNotaCredito()
        {
            switch (cntNotaCredito)
            {
                case 0:
                    
                    txtNNotaCredito.Text = "";
                    txtEmpresaNotCredito.Text = "";
                    txtSubTotalNotCredito.Text = "";
                    txtIVANotCredito.Text = "";

                    panelNotaCredito.Visible = false;
                    panelTotalNC.Visible = false;
                    btnQuitarNC.Visible = false;
                    btnAgregarNC.Visible = true;

                    panelBtnAgregarNC.Width = 676;
                    panelQuitarNC.Width = 317;

                    btnAgregarNC.Focus();

                    break;

                case 1:

                    txtNNotaCreditoII.Text = "";
                    txtEmpresaNotCreditoII.Text = "";
                    txtSubTotalNotCreditoII.Text = "";
                    txtIVANotCreditoII.Text = "";

                    panelNotaCredito.Visible = true;
                    panelTotalNC.Visible = true;
                    //panelNCII.Visible = false;
                    panelNotaCreditoII.Visible = false;
                    panelTotalNCII.Visible = false;
                    btnQuitarNC.Visible = true;

                    panelBtnAgregarNC.Width = 344;
                    panelQuitarNC.Width = 650;

                    panelTNC.Focus();

                    break;

                case 2:

                    //panelNCII.Visible = true;
                    panelNotaCreditoII.Visible = true;
                    panelTotalNCII.Visible = true; 
                    btnQuitarNC.Visible = true;
                    btnAgregarNC.Visible = false;

                    panelBtnAgregarNC.Width = 344;
                    panelQuitarNC.Width = 650;

                    panelTNC.Focus();
                    break;
                default:
                    break;
            }
        }

        private void cmbTipoFactura_TextChanged(object sender, EventArgs e)
        {
            readRetenciones();
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();
        }

        private void txtSubTotalNotCreditoII_Leave(object sender, EventArgs e)
        {
            if (txtSubTotalNotCreditoII.Text != "")
            {
                txtSubTotalNotCreditoII.Text = double.Parse(txtSubTotalNotCreditoII.Text).ToString("N2");
            }
        }

        private void txtSubTotalNotCreditoII_MouseClick(object sender, MouseEventArgs e)
        {
            formatearTexto();
        }

        private void txtSubTotalNotCreditoII_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtSubTotalNotCreditoII_TextChanged(object sender, EventArgs e)
        {
            calcularValorACobrar();
        }

        private void txtIVANotCreditoII_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }



        private void txtIVANotCreditoII_MouseClick(object sender, MouseEventArgs e)
        {
            formatearTexto();
        }

        private void txtIVANotCreditoII_TextChanged(object sender, EventArgs e)
        {
            calcularValorACobrar();
        }

        private void txtSubT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtSubT3_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtSubT2_TextChanged(object sender, EventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();
        }

        private void txtSubT3_TextChanged(object sender, EventArgs e)
        {
            calcularFactura();
            calcularTotalRetención();
            calcularValorACobrar();
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
                subTotalNotCredito = Decimal.Parse(txtSubTotalNotCredito.Text);
            }

            if (txtIVANotCredito.Text == "")
            {
                ivaNotCredito = 0;
            }
            else
            {
                ivaNotCredito = Decimal.Parse(txtIVANotCredito.Text);
            }


            if (txtSubTotalNotCreditoII.Text == "")
            {
                subTotalNotCreditoII = 0;
            }
            else
            {
                subTotalNotCreditoII = Decimal.Parse(txtSubTotalNotCreditoII.Text);
            }


            if (txtIVANotCreditoII.Text == "")
            {
                ivaNotCreditoII = 0;
            }
            else
            {
                ivaNotCreditoII = Decimal.Parse(txtIVANotCreditoII.Text);
            }


            totNotaCredito = subTotalNotCredito  + subTotalNotCredito * ivaNotCredito / 100m;
            totNotaCredito = Math.Round(totNotaCredito, 2, MidpointRounding.AwayFromZero);
            txtTotalNotCredito.Text = totNotaCredito.ToString("N2");

            totNotaCreditoII = subTotalNotCreditoII + subTotalNotCreditoII * ivaNotCreditoII / 100m;
            totNotaCreditoII = Math.Round(totNotaCreditoII, 2, MidpointRounding.AwayFromZero);
            txtTotalNotCreditoII.Text = totNotaCreditoII.ToString("N2");

            valorACobrar = totalFactura - totalRetencion - totNotaCredito - totNotaCreditoII; 
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
            if (!mostrarFactura)
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
            else
            {
                if (WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else this.WindowState = FormWindowState.Normal;
            }

        }
    }
}
