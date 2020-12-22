using Common.Cache;
using Domain;
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCrearCliente : Form
    {
        public FormCrearCliente()
        {
            InitializeComponent();
        }

        public bool desplegar = false;
        private void cerrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (!desplegar)
            {
                tipeExit = true;
                exit();
            }
            else
            {
                this.Close();
            }

        }
        
        private void Clientes_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width /2) - (lblTitulo.Width/2);

            acoplarPaneles();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            if (!desplegar)
            {
                txtRUC.LostFocus += new EventHandler(ValidarRUC);
            }
        }








        bool validatedRUC = false;
        private void ValidarRUC(object sender, EventArgs e)
        {
            string RUC = txtRUC.Text;

            Regex regex = new Regex("^[0-9]+$");

            if (regex.IsMatch(RUC)) 
            {
                if (RUC.Length == 10 || RUC.Length == 13)
                {
                    bool existeRUC = searchRUC();

                    if (existeRUC)
                    {
                        lblRUCExistente.Text = "Este RUC ya se encuentra registrado en la base de datos";
                        lblRUCExistente.Visible = true;
                        txtRUC.ForeColor = Color.FromArgb(187, 42, 89);
                        lineShape1.BorderColor = Color.FromArgb(187, 42, 89);
                        validatedRUC = false;
                    }
                    else
                    {
                        lblRUCExistente.Visible = false;
                        txtRUC.ForeColor = Color.White;
                        lineShape1.BorderColor = Color.DimGray;
                        validatedRUC = true;

                    }
                }
                else
                {
                    lblRUCExistente.Text = "El RUC ingresado contiene " + RUC.Length.ToString() + " dígitos y debería contener 10 o 13 dígitos";
                    lblRUCExistente.Visible = true;
                    txtRUC.ForeColor = Color.FromArgb(187, 42, 89);
                    lineShape1.BorderColor = Color.FromArgb(187, 42, 89);
                    validatedRUC = false;
                }
            }
            else
            {
                if (RUC == "")
                {
                    lblRUCExistente.Text = "El RUC no puede estar vacío";
                    lblRUCExistente.Visible = true;
                    txtRUC.ForeColor = Color.FromArgb(187, 42, 89);
                    lineShape1.BorderColor = Color.FromArgb(187, 42, 89);
                    validatedRUC = false;
                }
                else
                {
                    lblRUCExistente.Text = "El RUC no puede contener caracteres";
                    lblRUCExistente.Visible = true;
                    txtRUC.ForeColor = Color.FromArgb(187, 42, 89);
                    lineShape1.BorderColor = Color.FromArgb(187, 42, 89);
                    validatedRUC = false;
                }

            } 
        }


        private bool searchRUC()
        {
            //Consulta si el ruc existe 
            string RUC = txtRUC.Text;

            UserModel model = new UserModel();

            if (model.searchRUC(RUC))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }




        private void readClientes()
        {
            UserModel Read = new UserModel();
            //cmbEmpresa.DataSource = Read.readClients();
            //cmbEmpresa.DisplayMember = "Nombre_Empresa";
            //cmbEmpresa.ValueMember = "RUC";

        }




        private bool maximized = false;
        private int valAnterior = 0;

        int LX, LY;
        int ancho, alto;

        bool maximizarAlDesplegar = false;


        //maximizar
        bool condicioneInit = false; 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!desplegar)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (editar && !condicioneInit) { maximized = true; valAnterior = 19; condicioneInit = true; }

                if (!maximized)
                {
                    formPrincipal.panelMenuVertical.Visible = false;
                    valAnterior = (int)formPrincipal.panelGlobal.ColumnStyles[0].Width;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;

                    acoplarPaneles();

                }
                else
                {
                    formPrincipal.panelMenuVertical.Visible = true;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;

                    acoplarPaneles();

                }

                maximized = !maximized;
            }
            else
            {
                if (!maximizarAlDesplegar)
                {
                    LX = this.Location.X;
                    LY = this.Location.Y;
                    ancho = this.Width;
                    alto = this.Height;
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                }
                else
                {
                    this.Location = new Point(LX, LY);
                    this.Size = new Size(ancho, alto);
                }
                acoplarPaneles();
                maximizarAlDesplegar = !maximizarAlDesplegar;
            }

        }

        private void acoplarPaneles()
        {
            pnlInfoCliente.Width = this.Width - 30;
            panelPC1.Width = this.Width - 30;
            panelPC2.Width = this.Width - 30;
            panelPC3.Width = this.Width - 30;
            panelPC4.Width = this.Width - 30;
            panelPC5.Width = this.Width - 30;

            panelPCob1.Width = this.Width - 30;
            panelPCob2.Width = this.Width - 30;
            panelPCob3.Width = this.Width - 30;

            panelBtnNPC.Width = this.Width - 30;
            panelBtnPCob.Width = this.Width - 30;

            panelFacturaTBC.Width = (this.Width - 36) / 2;
            panelFacturaAgente.Width = (this.Width - 36) / 2;
            panelDatosBancarios.Width = this.Width - 30;
            panelDatosBancarios2.Width = this.Width - 30;
            panelDireccion.Width = this.Width - 30;
            panelBtn.Width = this.Width - 30;

        }


        private void pnlPrincipal_Scroll(object sender, ScrollEventArgs e)
        {
          
        }


        public bool editar = false;
        public bool regresar = false;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            

            if (!editar)
            {
                if (txtRUC.Text != "")
                {
                    if (validatedRUC)
                    {
                        DialogResult respuesta = MessageBox.Show("Está seguro que desea guardar al cliente ?",
                        "Info",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            if (model.InsertDataClient(insertDataClient()))
                            {
                                if (regresar)
                                {
                                    FormPrincipal formPrincipal = Owner as FormPrincipal;

                                    if (formPrincipal != null)
                                    {
                                        FormCrearTramite formCrearTramite = new FormCrearTramite();
                                        TramiteCache.empresa = txtEmpresa.Text;
                                        formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                        formPrincipal.AddOwnedForm(formCrearTramite);
                                        formPrincipal.AbrirFormInPanel(formCrearTramite);
                                    }

                                    this.Close();
                                }
                                else
                                {
                                    DialogResult result = MessageBox.Show("El cliente: " + values[2] +
                                   "\n\nSe ha guardado exitosamente" +
                                   "\n¿Desea agregar otro Cliente?",
                                   "Correcto",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Information);

                                    if (result == DialogResult.Yes)
                                    {

                                        FormPrincipal formPrincipal = Owner as FormPrincipal;

                                        if (formPrincipal != null)
                                        {
                                            FormCrearCliente formCrearCliente = new FormCrearCliente();
                                            formCrearCliente.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                            formPrincipal.AddOwnedForm(formCrearCliente);
                                            formPrincipal.AbrirFormInPanel(formCrearCliente);
                                        }

                                    }
                                    else
                                    {


                                        agregarCampos();
                                        
                                        /*
                                        FormPrincipal formPrincipal = Owner as FormPrincipal;
                                        formPrincipal.panelMenuVertical.Visible = true;
                                        formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

                                        this.Close();
                                        */
                                    }
                                }

                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("No se han guardardado los datos del cliente\n" +
                                    "Por favor, intente una vez más.",
                                    "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                       
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("El RUC ingresado no es válido\n" +
                        "Por favor, ingrese un RUC válido.",
                        "Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("El RUC no puede estar vacío\n" +
                    "Por favor, ingrese un RUC válido.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("Está seguro que desea guardar los cambios ?",
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (model.InsertDataClient(insertDataClient()))
                    {
                        MessageBox.Show("El cliente se ha actualizado exitosamente\n",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        FormPrincipal formPrincipal = Owner as FormPrincipal;

                        if (formPrincipal != null)
                        {
                            FormBuscarClientes formBuscarClientes = new FormBuscarClientes();
                            formBuscarClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                            formPrincipal.AddOwnedForm(formBuscarClientes);
                            formPrincipal.AbrirFormInPanel(formBuscarClientes);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No ha sido posible guardar los cambios realizados\n"+
                    "Por favor, inténtelo mas tarde",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
         
        }

        private void agregarCampos()
        {
            FormCrearCliente formClientes = new FormCrearCliente();

            formClientes.txtRUC.Text = txtRUC.Text;
            formClientes.txtEmpresa.Text = txtEmpresa.Text;
            formClientes.txtPC.Text = txtPC.Text;
            formClientes.txtPCTelf.Text = txtPCTelf.Text;
            formClientes.txtPCCell.Text = txtPCCell.Text;
            formClientes.txtPCEmail.Text = txtPCEmail.Text;
            formClientes.txtTPC.Text = txtTPC.Text;
            formClientes.txtPCCargo.Text = txtPCCargo.Text;
            formClientes.txtPC2.Text = txtPC2.Text;
            formClientes.txtPCTelf2.Text = txtPCTelf2.Text;
            formClientes.txtPCCell2.Text = txtPCCell2.Text;
            formClientes.txtPCEmail2.Text = txtPCEmail2.Text;
            formClientes.txtTPC2.Text = txtTPC2.Text;
            formClientes.txtPCCargo2.Text = txtPCCargo2.Text;
            formClientes.txtPC3.Text = txtPC3.Text;
            formClientes.txtPCTelf3.Text = txtPCTelf3.Text;
            formClientes.txtPCCell3.Text = txtPCCell3.Text;
            formClientes.txtPCEmail3.Text = txtPCEmail3.Text;
            formClientes.txtTPC3.Text = txtTPC3.Text;
            formClientes.txtPCCargo3.Text = txtPCCargo3.Text;
            formClientes.txtPC4.Text = txtPC4.Text;
            formClientes.txtPCTelf4.Text = txtPCTelf4.Text;
            formClientes.txtPCCell4.Text = txtPCCell4.Text;
            formClientes.txtPCEmail4.Text = txtPCEmail4.Text;
            formClientes.txtTPC4.Text = txtTPC4.Text;
            formClientes.txtPCCargo4.Text = txtPCCargo4.Text;
            formClientes.txtPC5.Text = txtPC5.Text;
            formClientes.txtPCTelf5.Text = txtPCTelf5.Text;
            formClientes.txtPCCell5.Text = txtPCCell5.Text;
            formClientes.txtPCEmail5.Text = txtPCEmail5.Text;
            formClientes.txtTPC5.Text = txtTPC5.Text;
            formClientes.txtPCCargo5.Text = txtPCCargo5.Text;
            formClientes.txtPCob.Text = txtPCob.Text;
            formClientes.txtPCobEmail.Text = txtPCobEmail.Text;
            formClientes.txtPCobTel.Text = txtPCobTel.Text;
            formClientes.txtPCobCell.Text = txtPCobCell.Text;
            formClientes.txtPCob2.Text = txtPCob2.Text;
            formClientes.txtPCobEmail2.Text = txtPCobEmail2.Text;
            formClientes.txtPCobTel2.Text = txtPCobTel2.Text;
            formClientes.txtPCobCell2.Text = txtPCobCell2.Text;
            formClientes.txtPCob3.Text = txtPCob3.Text;
            formClientes.txtPCobEmail3.Text = txtPCobEmail3.Text;
            formClientes.txtPCobTel3.Text = txtPCobTel3.Text;
            formClientes.txtPCobCell3.Text = txtPCobCell3.Text;
            formClientes.txtSubtotalFAM.Text = txtSubtotalFAM.Text;
            formClientes.txtSubtotalFAA.Text = txtSubtotalFAA.Text;
            formClientes.txtRetRentaFA.Text = txtRetRentaFA.Text;
            formClientes.txtRetIVAFA.Text = txtRetIVAFA.Text;
            formClientes.txtDiasCreditoFA.Text = txtDiasCreditoFA.Text;
            formClientes.txtComisionFAM.Text = txtComisionFAM.Text;
            formClientes.txtComisionFAA.Text = txtComisionFAA.Text;
            formClientes.txtSubtotalFTBC.Text = txtSubtotalFTBC.Text;
            formClientes.txtRetRentaFTBC.Text = txtRetRentaFTBC.Text;
            formClientes.txtIVAFTBC.Text = txtIVAFTBC.Text;
            formClientes.txtDiasCreditoFTBC.Text = txtDiasCreditoFTBC.Text;
            formClientes.cmbComisionesBancarias.Text = cmbComisionesBancarias.Text;
            formClientes.txtPersonasComisionesExtra.Text = txtPersonasComisionesExtra.Text;
            formClientes.txtValorComisionesExtra.Text = txtValorComisionesExtra.Text;
            formClientes.txtDiasCreditoTransporte.Text = txtDiasCreditoTransporte.Text;
            formClientes.txtDiasCreditoGastos.Text = txtDiasCreditoGastos.Text;
            formClientes.txtBeneficiario.Text = txtBeneficiario.Text;
            formClientes.cmbNomBanco.Text = cmbNomBanco.Text;
            formClientes.cmbTipoCuenta.Text = cmbTipoCuenta.Text;
            formClientes.txtNumeroCuenta.Text = txtNumeroCuenta.Text;
            formClientes.txtBeneficiario2.Text = txtBeneficiario2.Text;
            formClientes.cmbNomBanco2.Text = cmbNomBanco2.Text;
            formClientes.cmbTipoCuenta2.Text = cmbTipoCuenta2.Text;
            formClientes.txtNumeroCuenta2.Text = txtNumeroCuenta2.Text;
            formClientes.txtCallePrincipal.Text = txtCallePrincipal.Text;
            formClientes.txtNumeracion.Text = txtNumeracion.Text;
            formClientes.txtCalleSecundaria.Text = txtCalleSecundaria.Text;
            formClientes.txtNombreEdificio.Text = txtNombreEdificio.Text;
            formClientes.txtReferencia.Text = txtReferencia.Text;

            //Nuevos valores
            formClientes.txtSubtotalFAT.Text = txtSubtotalFAT.Text;
            formClientes.txtComisionFT.Text = txtComisionFT.Text;
            formClientes.txtSubtotalTBCFA.Text = txtSubtotalTBCFA.Text;
            formClientes.txtSubtotalTBCFT.Text = txtSubtotalTBCFT.Text;
            formClientes.PC1Ext.Text = PC1Ext.Text;
            formClientes.PC2Ext.Text = PC2Ext.Text;
            formClientes.PC3Ext.Text = PC3Ext.Text;
            formClientes.PC4Ext.Text = PC4Ext.Text;
            formClientes.PC5Ext.Text = PC5Ext.Text;
            formClientes.txtCiudad.Text = txtCiudad.Text;
            formClientes.txtCodPostal.Text = txtCodPostal.Text;
            formClientes.txtCallePrincipal2.Text = txtCallePrincipal2.Text;
            formClientes.txtNumeracion2.Text = txtNumeracion2.Text;
            formClientes.txtCiudad2.Text = txtCiudad2.Text;
            formClientes.txtCalleSecundaria2.Text = txtCalleSecundaria2.Text;
            formClientes.txtEdificio2.Text = txtEdificio2.Text;
            formClientes.txtCodPostal2.Text = txtCodPostal2.Text;
            formClientes.txtReferencia2.Text = txtReferencia2.Text;

            if (formClientes.txtPC2.Text != "" || formClientes.txtPCTelf2.Text != "") { formClientes.panelPC2.Visible = true; formClientes.contPC = 1; }
            if (formClientes.txtPC3.Text != "" || formClientes.txtPCTelf3.Text != "") { formClientes.panelPC3.Visible = true; formClientes.contPC = 2; }
            if (formClientes.txtPC4.Text != "" || formClientes.txtPCTelf4.Text != "") { formClientes.panelPC4.Visible = true; formClientes.contPC = 3; }
            if (formClientes.txtPC5.Text != "" || formClientes.txtPCTelf5.Text != "") { formClientes.panelPC5.Visible = true; formClientes.contPC = 4; }

            if (formClientes.txtPCob2.Text != "" || formClientes.txtPCobTel2.Text != "") { formClientes.panelPCob2.Visible = true; formClientes.contPCob = 1; }
            if (formClientes.txtPCob3.Text != "" || formClientes.txtPCobTel3.Text != "") { formClientes.panelPCob3.Visible = true; formClientes.contPCob = 2; }

            formClientes.panelBtn.Visible = false;
            formClientes.panelBtnPCob.Visible = false;
            formClientes.panelBtnNPC.Visible = false;

            formClientes.cmbComisionesBancarias.Enabled = false;
            formClientes.cmbNomBanco.Enabled = false;
            formClientes.cmbTipoCuenta.Enabled = false;
            formClientes.cmbNomBanco2.Enabled = false;
            formClientes.cmbTipoCuenta2.Enabled = false;

            formClientes.minimizar.Visible = true;
            formClientes.desplegar = true;

            formClientes.lblTitulo.Text = txtEmpresa.Text;
            formClientes.Text = txtEmpresa.Text;
            formClientes.Opacity = 0.9;
            formClientes.Height = Screen.PrimaryScreen.WorkingArea.Size.Height;
            formClientes.Show();
        }


        string[] values = new string[92]; 
        public string[] insertDataClient()
        {
            values[0] = "Insert";


            values[1] = txtRUC.Text;
            values[2] = txtEmpresa.Text;

            /*
             *Persona_Contacto_1 varchar(50),
             *Telefono_Persona_De_Contacto_1 varchar(50),
             *Celular_Persona_De_Contacto_1 varchar(50),
             *Correo_Personas_Contacto_1 varchar(50),
             *Titulo_Persona_Contacto_1 varchar(50),
             *Cargo_Persona_Contacto_1 varchar(50),
            */ 
           

            values[3] = txtPC.Text;
            values[4] = txtPCTelf.Text;
            values[5] = txtPCCell.Text;
            values[6] = txtPCEmail.Text;
            values[7] = txtTPC.Text;
            values[8] = txtPCCargo.Text;

            values[9] = txtPC2.Text;
            values[10] = txtPCTelf2.Text;
            values[11] = txtPCCell2.Text;
            values[12] = txtPCEmail2.Text;
            values[13] = txtTPC2.Text;
            values[14] = txtPCCargo2.Text;

            values[15] = txtPC3.Text;
            values[16] = txtPCTelf3.Text;
            values[17] = txtPCCell3.Text;
            values[18] = txtPCEmail3.Text;
            values[19] = txtTPC3.Text;
            values[20] = txtPCCargo3.Text;

            values[21] = txtPC4.Text;
            values[22] = txtPCTelf4.Text;
            values[23] = txtPCCell4.Text;
            values[24] = txtPCEmail4.Text;
            values[25] = txtTPC4.Text;
            values[26] = txtPCCargo4.Text;

            values[27] = txtPC5.Text;
            values[28] = txtPCTelf5.Text;
            values[29] = txtPCCell5.Text;
            values[30] = txtPCEmail5.Text;
            values[31] = txtTPC5.Text;
            values[32] = txtPCCargo5.Text;

            /*
             *Persona_Cobranzas_1 varchar(50),
             *Correo_Persona_Cobranzas_1 varchar(50),
             *Telefono_Persona_Cobranzas_1 varchar(50),
             *Celular_Persona_Cobranzas_1 varchar(50),
             */

            values[33] = txtPCob.Text;
            values[34] = txtPCobEmail.Text;
            values[35] = txtPCobTel.Text;
            values[36] = txtPCobCell.Text;

            values[37] = txtPCob2.Text;
            values[38] = txtPCobEmail2.Text;
            values[39] = txtPCobTel2.Text;
            values[40] = txtPCobCell2.Text;

            values[41] = txtPCob3.Text;
            values[42] = txtPCobEmail3.Text;
            values[43] = txtPCobTel3.Text;
            values[44] = txtPCobCell3.Text;

            /*
             --Factura Agente
                Subtotal_Factura_Agente_Maritima float,
                Subtotal_Factura_Agente_Aerea float,
                Retencion_Renta_Factura_Agente float,
                Retencion_IVA_Factura_Agente float,
                Dias_Credito_Factura_Agente int,
                Comision_Factura_Agente_Maritimo float,
                Comision_Factura_Agente_Aerea float,
             */

            values[45] = txtSubtotalFAM.Text;
            values[46] = txtSubtotalFAA.Text;
            values[47] = txtRetRentaFA.Text;
            values[48] = txtRetIVAFA.Text;
            values[49] = txtDiasCreditoFA.Text;
            values[50] = txtComisionFAM.Text;
            values[51] = txtComisionFAA.Text;


            for (int i = 45; i < 52; i++)
            {
                if (values[i] == "")
                {
                    values[i] = "0";
                }
            }


            values[52] = txtSubtotalFTBC.Text;
            values[53] = txtRetRentaFTBC.Text;
            values[54] = txtIVAFTBC.Text;
            values[55] = txtDiasCreditoFTBC.Text;
            values[56] = cmbComisionesBancarias.Text;
            values[57] = txtPersonasComisionesExtra.Text;
            values[58] = txtValorComisionesExtra.Text;
            values[59] = txtDiasCreditoTransporte.Text;
            values[60] = txtDiasCreditoGastos.Text;
            
           

            for (int i = 52; i < 62; i++)
            {
                if (values[i] == "")
                {
                    values[i] = "0";
                }
            }

            if (cmbComisionesBancarias.Text == "-- Seleccionar --") values[56] = "";


            /*
             --Datos Bancarios
                Beneficiario_1 varchar(50),
                Nombre_Banco_1 varchar(50),
                Tipo_Cuenta_1 varchar(50),
                Numero_Cuenta_1 varchar(50),
             */

            values[61] = txtBeneficiario.Text;
            values[62] = cmbNomBanco.Text;
            values[63] = cmbTipoCuenta.Text;
            values[64] = txtNumeroCuenta.Text;

            if (cmbNomBanco.Text == "-- Seleccionar --") cmbNomBanco.Text = "";
            if (cmbTipoCuenta.Text == "-- Seleccionar --") cmbTipoCuenta.Text = "";

            values[65] = txtBeneficiario2.Text;
            values[66] = cmbNomBanco2.Text;
            values[67] = cmbTipoCuenta2.Text;
            values[68] = txtNumeroCuenta2.Text;

            if (cmbNomBanco2.Text == "-- Seleccionar --") cmbNomBanco2.Text = "";
            if (cmbTipoCuenta2.Text == "-- Seleccionar --") cmbTipoCuenta2.Text = "";

            /*
             --Direccion
                Calle_Principal varchar(50),
                Numeracion varchar(50),
                Calle_Secundaria varchar(50),
                Nombre_Edificio varchar(50),
                Referencia varchar(250),
             */

            values[69] = txtCallePrincipal.Text;
            values[70] = txtNumeracion.Text;
            values[71] = txtCalleSecundaria.Text;
            values[72] = txtNombreEdificio.Text;
            values[73] = txtReferencia.Text;


            //Nuevos valores
            values[74] = txtSubtotalFAT.Text;
            values[75] = txtComisionFT.Text;
            values[76] = txtSubtotalTBCFA.Text;
            values[77] = txtSubtotalTBCFT.Text;

            for (int i = 74; i < 78; i++)
            {
                if (values[i] == "")
                {
                    values[i] = "0";
                }
            }


            values[78] = PC1Ext.Text;
            values[79] = PC2Ext.Text;
            values[80] = PC3Ext.Text;
            values[81] = PC4Ext.Text;
            values[82] = PC5Ext.Text;
            values[83] = txtCiudad.Text;
            values[84] = txtCodPostal.Text;
            values[85] = txtCallePrincipal2.Text;
            values[86] = txtNumeracion2.Text;
            values[87] = txtCiudad2.Text;
            values[88] = txtCalleSecundaria2.Text;
            values[89] = txtEdificio2.Text;
            values[90] = txtCodPostal2.Text;
            values[91] = txtReferencia2.Text;

          

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



        bool tipeExit = false;
        private void FormCrearCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tipeExit = false;
                exit();
            } 
        }

        private void exit()
        {
            if (regresar)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (formPrincipal != null)
                {
                    FormCrearTramite formCrearTramite = new FormCrearTramite();
                    TramiteCache.empresa = txtEmpresa.Text;
                    formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formCrearTramite);
                    formPrincipal.AbrirFormInPanel(formCrearTramite);
                }

                this.Close();
            }
            else
            {
                if (txtRUC.Text == "" || !validatedRUC)
                {
                    FormPrincipal formPrincipal = Owner as FormPrincipal;
                    formPrincipal.panelMenuVertical.Visible = true;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

                    if (tipeExit)
                    {
                        this.Close();
                    }
                    else
                    {
                        if (formPrincipal != null)
                        {
                            FormOpcionesClientes formOpcionesClientes = new FormOpcionesClientes();
                            formOpcionesClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                            formPrincipal.AddOwnedForm(formOpcionesClientes);
                            formPrincipal.AbrirFormInPanel(formOpcionesClientes);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Al salir de esta ventana los datos ingresados no se guardarán\n" +
                    "¿Desea salir?",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        FormPrincipal formPrincipal = Owner as FormPrincipal;
                        formPrincipal.panelMenuVertical.Visible = true;
                        formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

                        if (tipeExit)
                        {
                            this.Close();
                        }
                        else
                        {
                            if (formPrincipal != null)
                            {
                                FormOpcionesClientes formOpcionesClientes = new FormOpcionesClientes();
                                formOpcionesClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                formPrincipal.AddOwnedForm(formOpcionesClientes);
                                formPrincipal.AbrirFormInPanel(formOpcionesClientes);
                            }
                        }

                    }

                }
            }
        }

        private void txtTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtTelf1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtPCobTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void txtPCobTelf1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumero(sender, e);
        }

        private void comprobarNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        

        private void comprobarDecimal(object sender, KeyPressEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-EC");
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

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


        private void comprobarEntero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSubtotalFAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtSubtotalFAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtRetRentaFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtRetIVAFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtComisionFAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtComisionFAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtSubtotalFTBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtRetRentaFTBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtIVAFTBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtComisionesBancarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);;
        }

        private void txtValorComisionesExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtDiasCreditoFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarEntero(sender, e);
        }

        private void txtDiasCreditoFTBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarEntero(sender, e);
        }

        private void txtDiasCreditoTransporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarEntero(sender, e);
        }

        private void txtDiasCreditoGastos_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarEntero(sender, e);
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambiarFoco(sender, e);
        }

        private void txtSubtotalFAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtComisionFT_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtSubtotalTBCFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void txtSubtotalTBCFT_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);
        }

        private void cambiarFoco(object sender, KeyPressEventArgs e)
        {
            if (!txtReferencia.Focused && !txtPersonasComisionesExtra.Focused)
            {
                if (((int)e.KeyChar == (int)Keys.Enter) || ((int)e.KeyChar == (int)Keys.Return))
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    e.Handled = true;
                }

                if ((int)e.KeyChar == (int)Keys.Up)
                {

                    this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    e.Handled = true;

                }
                else if ((int)e.KeyChar == (int)Keys.Down)
                {

                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    e.Handled = true;

                }
            }
        }

        private void FormCrearCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambiarFoco(sender, e);
        }

        public int contPC = 0;

        private void btnNuevoPC_Click(object sender, EventArgs e)
        {
            contPC++;
            personaContacto(contPC);
        }

        private void btnEliminiarPC_Click(object sender, EventArgs e)
        {
            contPC--;
            personaContacto(contPC);
        }

        private void personaContacto(int contPC1)
        {
            switch (contPC1)
            {
                case -1:
                    contPC = 0;
                    break;

                case 0:
                    panelPC2.Visible = false;
                    panelPC3.Visible = false;
                    panelPC4.Visible = false;
                    panelPC5.Visible = false;
                    break;

                case 1:
                    panelPC2.Visible = true;
                    panelPC3.Visible = false;
                    panelPC4.Visible = false;
                    panelPC5.Visible = false;
                    break;
                case 2:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = false;
                    panelPC5.Visible = false;
                    break;
                case 3:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = false;
                    break;
                case 4:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    break;

                case 5:
                    contPC = 4;
                    break;
            }
        }

        public int contPCob = 0;
        private void btnAgregarPersonaCobranzas_Click(object sender, EventArgs e)
        {
            contPCob++;
            personaCobranzas(contPCob);
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSubtotalFAM_Leave(object sender, EventArgs e)
        {
            if (txtSubtotalFAM.Text == "")
            {
                txtSubtotalFAM.Text = "0";
            }
                double n = double.Parse(txtSubtotalFAM.Text);
                txtSubtotalFAM.Text = n.ToString("N2");

        }

        private void txtSubtotalFAA_Leave(object sender, EventArgs e)
        {
            if (txtSubtotalFAA.Text == "")
            {
                txtSubtotalFAA.Text = "0,00";
            }
            double n = double.Parse(txtSubtotalFAA.Text);
            txtSubtotalFAA.Text = n.ToString("N2");
        }

        private void txtRetRentaFA_Leave(object sender, EventArgs e)
        {
            if (txtRetRentaFA.Text == "")
            {
                txtRetRentaFA.Text = "0,00";
            }
            double n = double.Parse(txtRetRentaFA.Text);
            txtRetRentaFA.Text = n.ToString("N2");
        }

        private void txtRetIVAFA_Leave(object sender, EventArgs e)
        {
            if (txtRetIVAFA.Text == "")
            {
                txtRetIVAFA.Text = "0,00";
            }
            double n = double.Parse(txtRetIVAFA.Text);
            txtRetIVAFA.Text = n.ToString("N2");
        }

        private void txtComisionFAM_Leave(object sender, EventArgs e)
        {
            if (txtComisionFAM.Text == "")
            {
                txtComisionFAM.Text = "0,00";
            }
            double n = double.Parse(txtComisionFAM.Text);
            txtComisionFAM.Text = n.ToString("N2");
        }

        private void txtComisionFAA_Leave(object sender, EventArgs e)
        {
            if (txtComisionFAA.Text == "")
            {
                txtComisionFAA.Text = "0,00";
            }
            double n = double.Parse(txtComisionFAA.Text);
            txtComisionFAA.Text = n.ToString("N2");
        }

        private void txtSubtotalFTBC_Leave(object sender, EventArgs e)
        {
            if (txtSubtotalFTBC.Text == "")
            {
                txtSubtotalFTBC.Text = "0,00";
            }
            double n = double.Parse(txtSubtotalFTBC.Text);
            txtSubtotalFTBC.Text = n.ToString("N2");
        }

        private void txtRetRentaFTBC_Leave(object sender, EventArgs e)
        {
            if (txtRetRentaFTBC.Text == "")
            {
                txtRetRentaFTBC.Text = "0,00";
            }
            double n = double.Parse(txtRetRentaFTBC.Text);
            txtRetRentaFTBC.Text = n.ToString("N2");
        }

        private void txtIVAFTBC_Leave(object sender, EventArgs e)
        {
            if (txtIVAFTBC.Text == "")
            {
                txtIVAFTBC.Text = "0,00";
            }
            double n = double.Parse(txtIVAFTBC.Text);
            txtIVAFTBC.Text = n.ToString("N2");
        }

        private void txtValorComisionesExtra_Leave(object sender, EventArgs e)
        {
            if (txtValorComisionesExtra.Text == "")
            {
                txtValorComisionesExtra.Text = "0,00";
            }
            double n = double.Parse(txtValorComisionesExtra.Text);
            txtValorComisionesExtra.Text = n.ToString("N2");
        }




        private void btnQuitarPersonaCobranzas_Click(object sender, EventArgs e)
        {
            contPCob--;
            personaCobranzas(contPCob);
        }

        private void txtPCEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail.Text))
            {
                txtPCEmail.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC1.Visible = true;
            }
            else
            {
                txtPCEmail.ForeColor = Color.White;
                lblCompEmailPC1.Visible = false;
            }
        }

        private void txtPCEmail2_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail2.Text))
            {
                txtPCEmail2.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC2.Visible = true;
            }
            else
            {
                txtPCEmail2.ForeColor = Color.White;
                lblCompEmailPC2.Visible = false;
            }
        }

        private void txtPCEmail3_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail3.Text))
            {
                txtPCEmail3.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC3.Visible = true;
            }
            else
            {
                txtPCEmail3.ForeColor = Color.White;
                lblCompEmailPC3.Visible = false;
            }
        }

        private void txtPCEmail4_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail4.Text))
            {
                txtPCEmail4.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC4.Visible = true;
            }
            else
            {
                txtPCEmail4.ForeColor = Color.White;
                lblCompEmailPC4.Visible = false;
            }
        }

        private void txtPCEmail5_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail5.Text))
            {
                txtPCEmail5.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC5.Visible = true;
            }
            else
            {
                txtPCEmail5.ForeColor = Color.White;
                lblCompEmailPC5.Visible = false;
            }
        }

        private void txtPCobEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCobEmail.Text))
            {
                txtPCobEmail.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPCob1.Visible = true;
            }
            else
            {
                txtPCobEmail.ForeColor = Color.White;
                lblCompEmailPCob1.Visible = false;
            }
        }

        private void txtPCobEmail2_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCobEmail2.Text))
            {
                txtPCobEmail2.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPCob2.Visible = true;
            }
            else
            {
                txtPCobEmail2.ForeColor = Color.White;
                lblCompEmailPCob2.Visible = false;
            }
        }

        private void txtPCobEmail3_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCobEmail3.Text))
            {
                txtPCobEmail3.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPCob3.Visible = true;
            }
            else
            {
                txtPCobEmail3.ForeColor = Color.White;
                lblCompEmailPCob3.Visible = false;
            }
        }

        private void txtDiasCreditoFA_Leave(object sender, EventArgs e)
        {
            if (txtDiasCreditoFA.Text == "")
            {
                txtDiasCreditoFA.Text = "0";
            }
        }

        private void txtDiasCreditoFTBC_Leave(object sender, EventArgs e)
        {
            if (txtDiasCreditoFTBC.Text == "")
            {
                txtDiasCreditoFTBC.Text = "0";
            }
        }

        private void txtDiasCreditoTransporte_Leave(object sender, EventArgs e)
        {
            if (txtDiasCreditoTransporte.Text == "")
            { 
                txtDiasCreditoTransporte.Text = "0";
            }
        }

        private void txtDiasCreditoGastos_Leave(object sender, EventArgs e)
        {
            if (txtDiasCreditoGastos.Text == "")
            {
                txtDiasCreditoGastos.Text = "0";
            }
        }

        private void FormCrearCliente_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idCliente = 1; 
        }

        private void txtSubtotalFAT_Leave(object sender, EventArgs e)
        {
            if (txtSubtotalFAT.Text == "")
            {
                txtSubtotalFAT.Text = "0,00";
            }
            double n = double.Parse(txtSubtotalFAT.Text);
            txtSubtotalFAT.Text = n.ToString("N2");
        }

        private void txtComisionFT_Leave(object sender, EventArgs e)
        {
            if (txtComisionFT.Text == "")
            {
                txtComisionFT.Text = "0,00";
            }
            double n = double.Parse(txtComisionFT.Text);
            txtComisionFT.Text = n.ToString("N2");
        }

        private void txtSubtotalTBCFA_Leave(object sender, EventArgs e)
        {
            if (txtSubtotalTBCFA.Text == "")
            {
                txtSubtotalTBCFA.Text = "0,00";
            }
            double n = double.Parse(txtSubtotalTBCFA.Text);
            txtSubtotalTBCFA.Text = n.ToString("N2");

        }

        private void txtSubtotalTBCFT_Leave(object sender, EventArgs e)
        {
            if (txtSubtotalTBCFT.Text == "")
            {
                txtSubtotalTBCFT.Text = "0,00";
            }
            double n = double.Parse(txtSubtotalTBCFT.Text);
            txtSubtotalTBCFT.Text = n.ToString("N2");

        }

        private void personaCobranzas(int pCobranzas)
        {
            switch (pCobranzas)
            {
                case -1:
                    contPCob = 0;
                    break;

                case 0:
                    panelPCob1.Visible = true;
                    panelPCob2.Visible = false;
                    panelPCob3.Visible = false;
                    break;

                case 1:
                    panelPCob1.Visible = true;
                    panelPCob2.Visible = true;
                    panelPCob3.Visible = false;
                    break;
                case 2:
                    panelPCob1.Visible = true;
                    panelPCob2.Visible = true;
                    panelPCob3.Visible = true;
                    break;

                case 3:
                    contPCob = 2;
                    break;
            }
        }


        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                string expression = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                return Regex.IsMatch(email,
                    expression,
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }



    }
}
