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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCrearProveedor : Form
    {
        public FormCrearProveedor()
        {
            InitializeComponent();
        }

        private void FormCrearProveedor_Load(object sender, EventArgs e)
        {
            if (!desplegar)
            {
                txtRUC.LostFocus += new EventHandler(ValidarRUC);
            }
        }

        private void acoplarPaneles()
        {
            panelTitulo.Width = this.Width - 30;

            panelInfoCliente.Width = this.Width - 30;
            panelDatosBancarios.Width = this.Width - 30;
            panelDatosBancarios2.Width = this.Width - 30;

            panelPC1.Width = this.Width - 30;
            panelPC2.Width = this.Width - 30;
            panelPC3.Width = this.Width - 30;
            panelPC4.Width = this.Width - 30;
            panelPC5.Width = this.Width - 30;
            panelPC6.Width = this.Width - 30;
            panelPC7.Width = this.Width - 30;
            panelPC8.Width = this.Width - 30;
            panelPC9.Width = this.Width - 30;
            panelPC10.Width = this.Width - 30;

            panelDireccion.Width = this.Width - 30;

            panelBtnNPC.Width = this.Width - 30;
            panelBoton.Width = this.Width - 30; 


        }

        public int contPC;
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
                    panelPC6.Visible = false;
                    panelPC7.Visible = false;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;

                case 1:
                    panelPC2.Visible = true;
                    panelPC3.Visible = false;
                    panelPC4.Visible = false;
                    panelPC5.Visible = false;
                    panelPC6.Visible = false;
                    panelPC7.Visible = false;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 2:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = false;
                    panelPC5.Visible = false;
                    panelPC6.Visible = false;
                    panelPC7.Visible = false;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 3:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = false;
                    panelPC6.Visible = false;
                    panelPC7.Visible = false;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 4:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    panelPC6.Visible = false;
                    panelPC7.Visible = false;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 5:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    panelPC6.Visible = true;
                    panelPC7.Visible = false;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 6:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    panelPC6.Visible = true;
                    panelPC7.Visible = true;
                    panelPC8.Visible = false;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 7:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    panelPC6.Visible = true;
                    panelPC7.Visible = true;
                    panelPC8.Visible = true;
                    panelPC9.Visible = false;
                    panelPC10.Visible = false;
                    break;
                case 8:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    panelPC6.Visible = true;
                    panelPC7.Visible = true;
                    panelPC8.Visible = true;
                    panelPC9.Visible = true;
                    panelPC10.Visible = false;
                    break;
                case 9:
                    panelPC2.Visible = true;
                    panelPC3.Visible = true;
                    panelPC4.Visible = true;
                    panelPC5.Visible = true;
                    panelPC6.Visible = false;
                    panelPC7.Visible = true;
                    panelPC8.Visible = true;
                    panelPC9.Visible = true;
                    panelPC10.Visible = true;
                    break;

                case 10:
                    contPC = 9;
                    break;
            }
        }

        private void FormCrearProveedor_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
            btnAgregar.Left = (btnAgregar.Parent.Width / 2) - (btnAgregar.Width / 2);
            acoplarPaneles();
        }

        public bool desplegar = false;
        private bool tipeExit = false;
        private void cerrar_Click(object sender, EventArgs e)
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

        private void FormCrearProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tipeExit = false;
                exit();
            }

        }

        private void exit()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            
            if (regresar)
            {
                if (formPrincipal != null)
                {
                    FormCrearTramite formCrearTramite = new FormCrearTramite();
                    formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    TramiteCache.crearTramite = true;
                    TramiteCache.proveedor = txtEmpresa.Text;
                    formPrincipal.AddOwnedForm(formCrearTramite);
                    formPrincipal.AbrirFormInPanel(formCrearTramite);
                }

                this.Close();
            }
            else
            {
                if (txtRUC.Text == "" || !validatedRUC)
                {

                    formPrincipal.panelMenuVertical.Visible = true;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

                    if (tipeExit)
                    {
                        this.Close();
                    }
                    else
                    {
                        FormOpcionesProveedores formOpcionesProveedores = new FormOpcionesProveedores();
                        formOpcionesProveedores.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formOpcionesProveedores);
                        formPrincipal.AbrirFormInPanel(formOpcionesProveedores);
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


        bool maximized = false;
        bool maximizarAlDesplegar = false;
        float valAnterior;
        int LX, LY, ancho, alto;

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

        private void txtPCEmail6_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail6.Text))
            {
                txtPCEmail6.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC6.Visible = true;
            }
            else
            {
                txtPCEmail6.ForeColor = Color.White;
                lblCompEmailPC6.Visible = false;
            }
        }

        private void txtPCEmail7_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail7.Text))
            {
                txtPCEmail7.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC7.Visible = true;
            }
            else
            {
                txtPCEmail7.ForeColor = Color.White;
                lblCompEmailPC7.Visible = false;
            }
        }

        private void txtPCEmail8_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail8.Text))
            {
                txtPCEmail8.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC8.Visible = true;
            }
            else
            {
                txtPCEmail8.ForeColor = Color.White;
                lblCompEmailPC8.Visible = false;
            }
        }

        private void txtPCEmail9_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail9.Text))
            {
                txtPCEmail9.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC9.Visible = true;
            }
            else
            {
                txtPCEmail9.ForeColor = Color.White;
                lblCompEmailPC9.Visible = false;
            }
        }

        private void txtPCEmail10_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtPCEmail10.Text))
            {
                txtPCEmail10.ForeColor = Color.FromArgb(187, 42, 89);
                lblCompEmailPC10.Visible = true;
            }
            else
            {
                txtPCEmail10.ForeColor = Color.White;
                lblCompEmailPC10.Visible = false;
            }
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
                            if (model.InsertDataProveedor(insertDataProveedor()))
                            {
                                if (regresar)
                                {
                                    FormPrincipal formPrincipal = Owner as FormPrincipal;

                                    if (formPrincipal != null)
                                    {
                                        FormCrearTramite formCrearTramite = new FormCrearTramite();
                                        formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                        TramiteCache.crearTramite = true;
                                        TramiteCache.proveedor = txtEmpresa.Text;
                                        formPrincipal.AddOwnedForm(formCrearTramite);
                                        formPrincipal.AbrirFormInPanel(formCrearTramite);
                                    }
                                }
                                else
                                {
                                    DialogResult result = MessageBox.Show("El proveedor: " + values[2] +
                                "\n\nSe ha guardado exitosamente" +
                                "\n¿Desea agregar otro Proveedor?",
                                "Correcto",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                                    if (result == DialogResult.Yes)
                                    {

                                        FormPrincipal formPrincipal = Owner as FormPrincipal;

                                        if (formPrincipal != null)
                                        {
                                            FormCrearProveedor formCrearProveedor = new FormCrearProveedor();
                                            formCrearProveedor.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                            formPrincipal.AddOwnedForm(formCrearProveedor);
                                            formPrincipal.AbrirFormInPanel(formCrearProveedor);
                                        }

                                    }
                                    else
                                    {
                                        FormPrincipal formPrincipal = Owner as FormPrincipal;
                                        formPrincipal.panelMenuVertical.Visible = true;
                                        formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("No se han guardardado los datos del proveedor\n" +
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
                    if (model.InsertDataProveedor(insertDataProveedor()))
                    {
                        MessageBox.Show("El proveedor se ha actualizado exitosamente\n",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        FormPrincipal formPrincipal = Owner as FormPrincipal;

                        if (formPrincipal != null)              // Cambiar al crear Form Buscar Proveedor
                        {
                            FormBuscarProveedor formBuscarProveedor = new FormBuscarProveedor();
                            formBuscarProveedor.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                            formPrincipal.AddOwnedForm(formBuscarProveedor);
                            formPrincipal.AbrirFormInPanel(formBuscarProveedor);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No ha sido posible guardar los cambios realizados\n" +
                    "Por favor, inténtelo mas tarde",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }

        string[] values = new string[77];
        public string[] insertDataProveedor()
        {
            values[1] = txtRUC.Text;
            values[2] = txtEmpresa.Text;
            values[3] = cmbTipoContribuyente.Text;

            values[4] = txtBeneficiario.Text;
            values[5] = cmbNomBanco.Text;
            values[6] = cmbTipoCuenta.Text;
            values[7] = txtNumeroCuenta.Text;

            values[8] = txtBeneficiario2.Text;
            values[9] = cmbNomBanco2.Text;
            values[10] = cmbTipoCuenta2.Text;
            values[11] = txtNumeroCuenta2.Text;

            values[12] = txtPC.Text;
            values[13] = txtPCEmail.Text;
            values[14] = txtPCTelf.Text;
            values[15] = txtPCCell.Text;
            values[16] = txtPCDepartamento.Text;
            values[17] = txtPCCargo.Text;

            values[18] = txtPC2.Text;
            values[19] = txtPCEmail2.Text;
            values[20] = txtPCTelf2.Text;
            values[21] = txtPCCell2.Text;
            values[22] = txtPCDepartamento2.Text;
            values[23] = txtPCCargo2.Text;

            values[24] = txtPC3.Text;
            values[25] = txtPCEmail3.Text;
            values[26] = txtPCTelf3.Text;
            values[27] = txtPCCell3.Text;
            values[28] = txtPCDepartamento3.Text;
            values[29] = txtPCCargo3.Text;

            values[30] = txtPC4.Text;
            values[31] = txtPCEmail4.Text;
            values[32] = txtPCTelf4.Text;
            values[33] = txtPCCell4.Text;
            values[34] = txtPCDepartamento4.Text;
            values[35] = txtPCCargo4.Text;

            values[36] = txtPC5.Text;
            values[37] = txtPCEmail5.Text;
            values[38] = txtPCTelf5.Text;
            values[39] = txtPCCell5.Text;
            values[40] = txtPCDepartamento5.Text;
            values[41] = txtPCCargo5.Text;

            values[42] = txtPC6.Text;
            values[43] = txtPCEmail6.Text;
            values[44] = txtPCTelf6.Text;
            values[45] = txtPCCell6.Text;
            values[46] = txtPCDepartamento6.Text;
            values[47] = txtPCCargo6.Text;

            values[48] = txtPC7.Text;
            values[49] = txtPCEmail7.Text;
            values[50] = txtPCTelf7.Text;
            values[51] = txtPCCell7.Text;
            values[52] = txtPCDepartamento7.Text;
            values[53] = txtPCCargo7.Text;

            values[54] = txtPC8.Text;
            values[55] = txtPCEmail8.Text;
            values[56] = txtPCTelf8.Text;
            values[57] = txtPCCell8.Text;
            values[58] = txtPCDepartamento8.Text;
            values[59] = txtPCCargo8.Text;

            values[60] = txtPC9.Text;
            values[61] = txtPCEmail9.Text;
            values[62] = txtPCTelf9.Text;
            values[63] = txtPCCell9.Text;
            values[64] = txtPCDepartamento9.Text;
            values[65] = txtPCCargo9.Text;

            values[66] = txtPC10.Text;
            values[67] = txtPCEmail10.Text;
            values[68] = txtPCTelf10.Text;
            values[69] = txtPCCell10.Text;
            values[70] = txtPCDepartamento10.Text;
            values[71] = txtPCCargo10.Text;

            values[72] = txtCallePrincipal.Text;
            values[73] = txtNumeracion.Text;
            values[74] = txtCalleSecundaria.Text;
            values[75] = txtNombreEdificio.Text;
            values[76] = txtReferencia.Text;


            if (values[3] == "-- Seleccionar --") values[3] = "";
            if (values[5] == "-- Seleccionar --") values[5] = "";
            if (values[6] == "-- Seleccionar --") values[6] = "";
            if (values[9] == "-- Seleccionar --") values[9] = "";
            if (values[10] == "-- Seleccionar --") values[10] = "";

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

            if (model.searchRUCProveedor(RUC))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void FormCrearProveedor_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idProveedor = 1;
        }

        bool condicioneInit = false; 
        private void maximizar_Click(object sender, EventArgs e)
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
