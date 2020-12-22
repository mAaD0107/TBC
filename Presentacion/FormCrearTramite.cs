using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class FormCrearTramite : Form
    {
        public FormCrearTramite()
        {
            InitializeComponent();
        }

        private void FormAuxiliar_Load(object sender, EventArgs e)
        {
            if (!editar && !desplegar)
            {
                readTramites();
                cargarFechas();
            }




            readClientes();
            txtNTramite.Text = IDTramite.ToString("D5");

            if (agregarInfo)
            {
                
                switch (cmbTipoTramite.Text)
                {
                    case "Aéreo":
                        panelNContenedor.Visible = false;
                        panelNGuia.Visible = true;
                        panelNPasePuerta.Visible = false;

                        break;

                    case "Marítimo":
                        panelNContenedor.Visible = true;
                        panelNGuia.Visible = false;
                        panelNPasePuerta.Visible = false;
                        break;

                    case "Terrestre - Forwarder":
                        panelNContenedor.Visible = false;
                        panelNGuia.Visible = false;
                        panelNPasePuerta.Visible = true;
                        break;

                    default:
                        break;
                }


                panelComentarios.Visible = true;
                panelInferior.Visible = true;
                

                
            }


        }

        public int IDTramite = 0;
        public bool agregarInfo = false;
        private void readTramites()
        {
            UserModel Read = new UserModel();
            IDTramite = Read.readIDTramiteImport();

            IDTramite++;
            txtNTramite.Text = IDTramite.ToString("D5");
        }

        public string RUCCliente;
        DataTable clientes;
        private void readClientes()
        {
            UserModel Read = new UserModel();
            
            clientes = Read.readClients();

            cmbEmpresa.DataSource = clientes;
            cmbEmpresa.DisplayMember = "NombreEmpresa";
            cmbEmpresa.ValueMember = "NombreEmpresa";

            cargarRUCCliente();
        }

        public string RUCEmpresa; 
        private void cargarRUCCliente()
        {
            if (cmbEmpresa.SelectedIndex == -1)
            {
                RUCCliente = clientes.Rows[0]["RUC"].ToString();
            }
            else
            {
                RUCCliente = clientes.Rows[cmbEmpresa.SelectedIndex]["RUC"].ToString();
            }

            if (editar || desplegar || agregarInfo)
            {
                UserModel Read = new UserModel();
                //Consultar el nombre de la empresa al que pertenece ese ruc
                string nombreEmpresa = Read.readNombreEmpresa(RUCEmpresa);
                //Poner esa empresa en el comboBox 
                cmbEmpresa.SelectedValue = nombreEmpresa;
                RUCCliente = RUCEmpresa;
            }


        }




        private void cargarFechas()
        {
            dateLimite.Value = DateTime.Today.AddDays(+1);
            dateInicio.Value = DateTime.Today.AddDays(0);
            dateFinalizacion.Value = DateTime.Today.AddDays(0);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (!desplegar)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (reiniciarPanel)
                {
                    valAnterior = 19;
                    valAntAltoMenuInf = 20;
                }

                panelFormulario.Visible = false;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = valAntAltoMenuInf;
                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelInferior.Visible = true;
                this.Close();
            }
            else
            {
                this.Close();
            }
            

        }


        private bool maximized = false;
        private int valAnterior = 0;
        private float valAntAltoMenuInf = 0;


        int LX, LY;
        int ancho, alto;
        private void maximizar_Click(object sender, EventArgs e)
        {

            if (!desplegar)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (reiniciarPanel)
                {
                    maximized = true;
                    reiniciarPanel = false;
                    valAnterior = 19;
                }

                if (!maximized)
                {

                    formPrincipal.panelMenuVertical.Visible = false;
                    valAnterior = (int)formPrincipal.panelGlobal.ColumnStyles[0].Width;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;
                    valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;
                    formPrincipal.panelInferior.Visible = false;
                    formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;

                }
                else
                {

                    formPrincipal.panelMenuVertical.Visible = true;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                    formPrincipal.panelInferior.Visible = true;

                }

                
            }
            else
            {
                if (!maximized)
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
                
            }

            maximized = !maximized;

        }

        public bool desplegar = false; 
        private void FormCrearTramite_Shown(object sender, EventArgs e)
        {
            if (!desplegar)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                valAnterior = (int)formPrincipal.panelGlobal.ColumnStyles[0].Width;
                valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;

                panelFormulario.Visible = true;

                mostrarAlCargar();
                cmbTipoTramite.Focus();
            }

            InterfaceCache.idImportaciones = 2;

        }


        private bool reiniciarPanel = false;
        private void mostrarAlCargar()
        {
            if (TramiteCache.crearTramite)
            {
                TramiteCache.crearTramite = false;

                reiniciarPanel = true;

                IDTramite = TramiteCache.nFactura;
                cmbTipoTramite.SelectedItem = TramiteCache.tipoTramite;
                cmbCiudadNacionalizacion.SelectedItem = TramiteCache.ciudadNacionalizacion;
                txtDAI.Text = TramiteCache.DAI;
                dateInicio.Value = TramiteCache.fechaInicio;
                dateLimite.Value = TramiteCache.fechaLimite;
                txtSecuencialCliente.Text = TramiteCache.secuencialCliente;
                txtNFacturaProveedor.Text = TramiteCache.nFacturaProveedor;
                txtNLiquidacion.Text = TramiteCache.nLiquidacion;
                txtOrdenLDM.Text = TramiteCache.nOrdenLDM;
                txtNContenedor.Text = TramiteCache.nCOntenedor;
                txtNaviera.Text = TramiteCache.naviera;
                txtNGuia.Text = TramiteCache.nGuia;
                txtAerolinea.Text = TramiteCache.aerolinea;
                txtPasePuerta.Text = TramiteCache.nPasePuerta;
                txtForwarderTerrestre.Text = TramiteCache.forwarder = txtForwarderTerrestre.Text;
                dateFinalizacion.Value = TramiteCache.fechaFinalizacion;
                txtComentariosAgregar.Text = TramiteCache.comentarios;

                txtProveedor.Text = TramiteCache.proveedor;

                cmbEmpresa.SelectedIndex = cmbEmpresa.FindString(TramiteCache.empresa);

            }

            txtDAI.Select(txtDAI.Text.Length, 0);
            txtDAI.Focus();
            txtDAI.ScrollToCaret();


        }






        private void dateInicio_Enter(object sender, EventArgs e)
        {
            lineShape4.BorderColor = Color.FromArgb(187, 42, 89);
            dateInicio.ForeColor = Color.White;
        }

        private void dateInicio_Leave(object sender, EventArgs e)
        {
            lineShape4.BorderColor = Color.DimGray;
            dateInicio.ForeColor = Color.LightGray;
        }

        private void dateLimite_Enter(object sender, EventArgs e)
        {
            lineShape3.BorderColor = Color.FromArgb(187, 42, 89);
            dateLimite.ForeColor = Color.White;
        }

        private void dateLimite_Leave(object sender, EventArgs e)
        {
            lineShape3.BorderColor = Color.DimGray;
            dateLimite.ForeColor = Color.LightGray;

            if (dateInicio.Value > dateLimite.Value)
            {
                MessageBox.Show("La fecha límite del trámite debe ser posterior a la fecha de inicio",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                dateLimite.Value = dateInicio.Value;
            }
        }

        private void dateFinalizacion_Enter(object sender, EventArgs e)
        {
            lineShape14.BorderColor = Color.FromArgb(187, 42, 89);
            dateFinalizacion.ForeColor = Color.White;
        }

        private void dateFinalizacion_Leave(object sender, EventArgs e)
        {
            lineShape14.BorderColor = Color.DimGray;
            dateFinalizacion.ForeColor = Color.LightGray;
        }

        private void FormCrearTramite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormOpcionesTramite formOpcionesTramite = new FormOpcionesTramite();
                    formOpcionesTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formOpcionesTramite);
                    formPrincipal.AbrirFormInPanel(formOpcionesTramite);
                }
            }
        }


        private void cmbCiudadNacionalizacion_TextChanged(object sender, EventArgs e)
        {

            switch (cmbCiudadNacionalizacion.Text)
            {
                case "Quito":
                    string DAI; 
                    if (txtDAI.Text.Length > 4)
                    {
                        DAI = txtDAI.Text.Remove(0, 6);
                        txtDAI.Text = "055 - " + DAI;
                    }
                    else
                    {
                        txtDAI.Text = "055 - ";
                        txtDAI.Enabled = true;
                    }
                    break;

                case "Guayaquil":
                    if (cmbTipoTramite.Text != "Aéreo")
                    {
                        if (txtDAI.Text.Length > 4)
                        {
                            DAI = txtDAI.Text.Remove(0, 6);
                            txtDAI.Text = "028 - " + DAI;
                        }
                        else
                        {
                            txtDAI.Text = "028 - ";
                            txtDAI.Enabled = true;
                        }
                    }
                    else
                    {
                        if (txtDAI.Text.Length > 4)
                        {
                            DAI = txtDAI.Text.Remove(0, 6);
                            txtDAI.Text = "019 - " + DAI;
                        }
                        else
                        {
                            txtDAI.Text = "019 - ";
                            txtDAI.Enabled = true;
                        }
                    }

                    break;

                case "Tulcán":
                    if (txtDAI.Text.Length > 4)
                    {
                        DAI = txtDAI.Text.Remove(0, 6);
                        txtDAI.Text = "073 - " + DAI;
                    }
                    else
                    {
                        txtDAI.Text = "073 - ";
                        txtDAI.Enabled = true;
                    }
                    break;

                case "Huaquillas":
                    if (txtDAI.Text.Length > 4)
                    {
                        DAI = txtDAI.Text.Remove(0, 6);
                        txtDAI.Text = "082 - " + DAI;
                    }
                    else
                    {
                        txtDAI.Text = "082 - ";
                        txtDAI.Enabled = true;
                    }
                    break;

                default:
                    txtDAI.Text = "";
                    txtDAI.Enabled = false;
                    break;
            }


/*
            switch (cmbTipoTramite.Text)
            {
                case "Aéreo":
                    panelNContenedor.Visible = false;
                    panelNGuia.Visible = true;
                    panelNPasePuerta.Visible = false;

                    break;

                case "Marítimo":
                    panelNContenedor.Visible = true;
                    panelNGuia.Visible = false;
                    panelNPasePuerta.Visible = false;
                    break;

                case "Terrestre - Forwarder":
                    panelNContenedor.Visible = false;
                    panelNGuia.Visible = false;
                    panelNPasePuerta.Visible = true;
                    break;

                default:
                    break;
            }


*/

            //panelDatos.Visible = true;
           // panelComentarios.Visible = true;
            //panelComentariosCrear.Visible = true;
            panelInferior.Visible = true;
            /*
            txtDAI.Select(txtDAI.Text.Length, 0);
            txtDAI.Focus();
            txtDAI.ScrollToCaret();
            */
        }



        private void txtDAI_TextChanged(object sender, EventArgs e)
        {
            string texto = txtDAI.Text;
            string num = Regex.Replace(texto, "[^0-9]", "");
            bool cambiarFoco = false;
         
            switch (num.Length)
            {
                case 4:
                    texto = String.Format("{0:0## - #}", Int64.Parse(num));
                    break;

                case 8:
                    texto = String.Format("{0:0## - #### - #}", Int64.Parse(num));
                    break;

                case 10:
                    texto = String.Format("{0:0## - #### - ## - #}", Int64.Parse(num));
                    break;

                case 17:
                    texto = String.Format("{0:0## - #### - ## - ########}", Int64.Parse(num));

                    string DAI = texto.Substring(0,3);


                    if (DAI == "055" || DAI == "028" || DAI == "073" || DAI == "082" || DAI == "019")
                    {
                        txtDAI.ForeColor = Color.White;
                        lblErrorDAI.Visible = false;
                        dateInicio.Focus();
                        cambiarFoco = true;
                        //this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    }
                    else
                    {
                        txtDAI.ForeColor = Color.FromArgb(187, 42, 89);
                        lblErrorDAI.Text = "El código de nacionalización es incorrecto";
                        lblErrorDAI.Visible = true;
                    }

                    break;
                default:
                    break;
            }

            txtDAI.Text = texto;
            
            if (!cambiarFoco)
            {
                txtDAI.Select(txtDAI.Text.Length, 0);
                txtDAI.Focus();
                txtDAI.ScrollToCaret();
            }


        }


        private void txtDAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                 e.Handled = true;   
            }
        }

        private void cmbTipoTramite_TextChanged(object sender, EventArgs e)
        {
            switch (cmbTipoTramite.Text)
            {
                case "Otro":
                    lblConcepto.Visible = true;
                    txtConcepto.Visible = true;
                    lineConcepto.Visible = true;
                    break;

                case "Por Courier":
                    lblDAI.Text = "Número DAS:";
                    break;

                default:
                    lblConcepto.Visible = false;
                    txtConcepto.Visible = false;
                    lineConcepto.Visible = false;
                    lblDAI.Text = "Número DAI:";
                    break;
            }
        }



        private void cmbCiudadNacionalizacion_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true; 
        }

        private void FormAuxiliar_Resize(object sender, EventArgs e)
        {
            acoplarPaneles();

            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
            btnGuardar.Left = (btnGuardar.Parent.Width / 2) - (btnGuardar.Width / 2);
            
        }

        private void acoplarPaneles()
        {
            panelTitulo.Width = this.Width - 30;
            panelTramite.Width = this.Width - 30;
            panelDatosGenerales.Width = this.Width - 30;
            panelDatos.Width = this.Width - 30;
            panelNPasePuerta.Width = this.Width - 30;
            panelNGuia.Width = this.Width - 30;
            panelNContenedor.Width = this.Width - 30;
            panelComentariosCrear.Width = this.Width - 30;
            panelComentarios.Width = this.Width - 30;

            panelInferior.Width = this.Width - 30;

        }

        private void cmbEmpresa_TextChanged(object sender, EventArgs e)
        {
            //cargarRUCCliente();
        }



        private void cmbEmpresa_Leave(object sender, EventArgs e)
        {
            cargarRUCCliente();
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {

            UserModel model = new UserModel();

            DialogResult respuesta = MessageBox.Show("Está seguro que desea guardar el Trámite ?",
            "Info",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (model.InsertDataTramite(insertDataTramite()))
                {
                    if (!editar)
                    {
                        DialogResult result = MessageBox.Show("El trámite: " + IDTramite.ToString("D5") +
                        "\n\nSe ha guardado exitosamente" +
                        "\n¿Desea crear otro Trámite?",
                        "Correcto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {

                            FormPrincipal formPrincipal = Owner as FormPrincipal;

                            if (formPrincipal != null)
                            {
                                FormCrearTramite formCrearTramite = new FormCrearTramite();
                                formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                formPrincipal.AddOwnedForm(formCrearTramite);
                                formPrincipal.AbrirFormInPanel(formCrearTramite);
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
                    else
                    {

                        DialogResult result = MessageBox.Show("El trámite: " + IDTramite.ToString("D5") +
                       "\n\nSe ha actualizado exitosamente",
                       "Correcto",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                        FormPrincipal formPrincipal = Owner as FormPrincipal;

                        if (!agregarInfo)
                        {
                            if (formPrincipal != null)
                            {
                                FormBuscarTramite formBuscarTramite = new FormBuscarTramite();
                                formBuscarTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                formPrincipal.AddOwnedForm(formBuscarTramite);
                                formPrincipal.AbrirFormInPanel(formBuscarTramite);
                            }
                        }
                        else
                        {
                            if (formPrincipal != null)
                            {
                                FormOpcionesTramite formOpcionesTramite = new FormOpcionesTramite();
                                formOpcionesTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                                formPrincipal.AddOwnedForm(formOpcionesTramite);
                                formPrincipal.AbrirFormInPanel(formOpcionesTramite);
                            }
                        }

                        


                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("No ha sido posible guardar los datos del trámite\n" +
                    "Por favor, intente una vez más.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

        }

       
        
        public bool editar = false; 
        string[] values = new string[25];
        public string[] insertDataTramite()
        {
            if (!editar)
            {
                readTramites();
                
            }


            values[1] = IDTramite.ToString();
            values[2] = RUCCliente;
            values[3] = cmbTipoTramite.Text;
            values[4] = cmbCiudadNacionalizacion.Text;
            values[5] = txtSecuencialCliente.Text;
            values[6] = txtProveedor.Text;
            values[7] = txtNFacturaProveedor.Text;
            values[8] = dateInicio.Value.ToString("yyyy-MM-dd");
            values[9] = dateLimite.Value.ToString("yyyy-MM-dd");
            values[10] = dateFinalizacion.Value.ToString("yyyy-MM-dd");
            values[11] = txtComentariosCrear.Text;


            values[12] = txtDAI.Text;
            values[13] = txtNLiquidacion.Text;
            values[14] = txtOrdenLDM.Text;

            values[15] = txtNContenedor.Text;
            values[16] = txtNaviera.Text;
            values[17] = txtForwarderMaritima.Text;

            values[18] = txtNGuia.Text;
            values[19] = txtAerolinea.Text;
            values[20] = txtForwarderAerea.Text;

            values[21] = txtPasePuerta.Text;
            values[22] = txtTransportista.Text;
            values[23] = txtForwarderTerrestre.Text;
            values[24] = txtComentariosAgregar.Text;



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

        private void txtDAI_Leave(object sender, EventArgs e)
        {
            if (!validarDAI())
            {
                txtDAI.ForeColor = Color.FromArgb(187, 42, 89);
                lblErrorDAI.Text = "DAI erronea";
                lblErrorDAI.Visible = true;
            }
            else
            {
                txtDAI.ForeColor = Color.White;
                lblErrorDAI.Visible = false;
            }
            
        }

        private bool validarDAI()
        {
            string DAI = txtDAI.Text;
            string dai = Regex.Replace(DAI, "[^0-9]", "");

            if (dai.Length == 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {

            TramiteCache.crearTramite = true;
            TramiteCache.nFactura = IDTramite;
            TramiteCache.tipoTramite = cmbTipoTramite.Text;
            TramiteCache.ciudadNacionalizacion = cmbCiudadNacionalizacion.Text;
            TramiteCache.DAI = txtDAI.Text;
            TramiteCache.fechaInicio = dateInicio.Value;
            TramiteCache.fechaLimite = dateLimite.Value;
            TramiteCache.secuencialCliente = txtSecuencialCliente.Text;
            TramiteCache.nFacturaProveedor = txtNFacturaProveedor.Text;
            TramiteCache.nLiquidacion = txtNLiquidacion.Text;
            TramiteCache.nOrdenLDM = txtOrdenLDM.Text;
            TramiteCache.nCOntenedor = txtNContenedor.Text;
            TramiteCache.naviera = txtNaviera.Text;
            TramiteCache.nGuia = txtNGuia.Text;
            TramiteCache.aerolinea = txtAerolinea.Text;
            TramiteCache.nPasePuerta = txtPasePuerta.Text;
            TramiteCache.forwarder = txtForwarderTerrestre.Text;
            TramiteCache.fechaFinalizacion = dateFinalizacion.Value;
            TramiteCache.comentarios = txtComentariosCrear.Text;
            TramiteCache.proveedor = txtProveedor.Text;


            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearCliente formCrearCliente = new FormCrearCliente();
                formCrearCliente.regresar = true;
                formCrearCliente.lblTitulo.Text = "Crear Empresa";
                formPrincipal.AddOwnedForm(formCrearCliente);
                formPrincipal.AbrirFormInPanel(formCrearCliente);
            }
        }




        private void comprobarEntero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNLiquidacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarEntero(sender, e);
        }

        private void txtOrdenLDM_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarEntero(sender, e);
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
