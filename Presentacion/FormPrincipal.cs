using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;
using System.Threading;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        float ancho, alto, anchoPanelLateral;
        bool cBtnMax = false;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (!cBtnMax)
            {
                LX = this.Location.X;
                LY = this.Location.Y;
                ancho = this.Width;
                alto = this.Height;
                anchoPanelLateral = panelGlobal.ColumnStyles[0].Width;
                panelMenuVertical.AutoSize = false;

                
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                if(panelGlobal.ColumnStyles[0].Width>5)
                    panelGlobal.ColumnStyles[0].Width = anchoPanelLateral - 5;

                redondeoFormPrincipal.ApplyElipse(0);
            }
            else
            {
                this.Location = new Point(LX, LY);
                this.Size = new Size((int)ancho, (int)alto);
                panelGlobal.ColumnStyles[0].Width = anchoPanelLateral;

                redondeoFormPrincipal.ApplyElipse(20);

            }
            cBtnMax = !cBtnMax;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenuVertical_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mostrarMenu();
        }

        bool mantenerMenu = false;
        private void btnInicio_Click(object sender, EventArgs e)
        {
            vCliente = false;

            if (mantenerMenu)
            {
                mostrarMenu();
            }
            else
            {
                ocultarMenu();
            }

            mantenerMenu = !mantenerMenu;

        }



        private Form formG = null as Form;
        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);


            if (formG != null)
            {
                this.panelContenedor.Controls.Remove(formG);
                formG.Dispose();
                formG = null;
                MemoryManagement.FlushMemory();
            }

            formG = FormHijo as Form;
            formG.TopLevel = false;
            formG.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formG);
            this.panelContenedor.Tag = formG;
            formG.Show();
            formG.SelectNextControl(ActiveControl, true, true, true, true);



        }




        // Region de Botones Menu Vertical 
        #region 
        bool vCliente = false;
        bool vProveedor = false;
        bool vImportaciones = false;
        bool vExportaciones = false;


        private void btnClientes_Click(object sender, EventArgs e)
        {
            if(!vCliente)
            {
                btnInicio.BackColor = Color.FromArgb(150,33, 31, 41);
                btnClientes.BackColor = Color.FromArgb(57, 60, 67);
                btnTramites.BackColor = Color.FromArgb(150,33, 31, 41);
                btnImportaciones.BackColor = Color.FromArgb(150,33, 31, 41);
                btnExportaciones.BackColor = Color.FromArgb(150,33, 31, 41);
                btnReportes.BackColor = Color.FromArgb(150,33, 31, 41);
                btnConfigurar.BackColor = Color.FromArgb(150,33, 31, 41);
                btnLogOut.BackColor = Color.FromArgb(150,33, 31, 41);

                FormOpcionesClientes formOpcionesClientes = new FormOpcionesClientes();
                formOpcionesClientes.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                AddOwnedForm(formOpcionesClientes);
                AbrirFormInPanel(formOpcionesClientes);
               
                vCliente = true;
                vProveedor = false;
                vImportaciones = false;
                vExportaciones = false;

            }
            else
            {
                if (InterfaceCache.idCliente != 0)
                {
                    FormOpcionesClientes formOpcionesClientes = new FormOpcionesClientes();
                    formOpcionesClientes.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                    AddOwnedForm(formOpcionesClientes);
                    AbrirFormInPanel(formOpcionesClientes);
                }

            }

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

            if (!vProveedor)
            {
                btnInicio.BackColor = Color.FromArgb(150,33, 31, 41);
                btnClientes.BackColor = Color.FromArgb(150,33, 31, 41);
                btnTramites.BackColor = Color.FromArgb(57, 60, 67);
                btnImportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnExportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnReportes.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnConfigurar.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);

                FormOpcionesProveedores formOpcionesProveedores = new FormOpcionesProveedores();
                formOpcionesProveedores.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                AddOwnedForm(formOpcionesProveedores);
                AbrirFormInPanel(formOpcionesProveedores);

                vProveedor = true;
                vCliente = false;
                vImportaciones = false;
                vExportaciones = false;
            }
            else
            {
                if (InterfaceCache.idProveedor != 0)
                {
                    FormOpcionesProveedores formOpcionesProveedores = new FormOpcionesProveedores();
                    formOpcionesProveedores.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                    AddOwnedForm(formOpcionesProveedores);
                    AbrirFormInPanel(formOpcionesProveedores);
                }

            }
            


        }
        private void btnExportaciones_Click(object sender, EventArgs e)
        {
            if (!vExportaciones)
            {
                btnInicio.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnClientes.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnTramites.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnImportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnExportaciones.BackColor = Color.FromArgb(57, 60, 67);
                btnReportes.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnConfigurar.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);

                FormOpcionesExportaciones formOpcionesExportaciones = new FormOpcionesExportaciones();
                formOpcionesExportaciones.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                AddOwnedForm(formOpcionesExportaciones);
                AbrirFormInPanel(formOpcionesExportaciones);

                vImportaciones = false;
                vCliente = false;
                vProveedor = false;
                vExportaciones = true;
            }
            else
            {
            }
        }
                private void btnImportaciones_Click(object sender, EventArgs e)
        {
            if (!vImportaciones)
            {
                btnInicio.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnClientes.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnTramites.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnImportaciones.BackColor = Color.FromArgb(57, 60, 67);
                btnExportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnReportes.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnConfigurar.BackColor = Color.FromArgb(150, 33, 31, 41);
                btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);

                FormOpcionesImportaciones formOpcionesImportaciones = new FormOpcionesImportaciones();
                formOpcionesImportaciones.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                AddOwnedForm(formOpcionesImportaciones);
                AbrirFormInPanel(formOpcionesImportaciones);

                vImportaciones = true;
                vCliente = false;
                vProveedor = false;
                vExportaciones = false;
            }
            else
            {

                switch (InterfaceCache.idImportaciones)
                {
                    case 1:
                        opcionesImportaciones();
                        break;

                    case 2:
                        FormOpcionesTramite formOpcionesTramite = new FormOpcionesTramite();
                        formOpcionesTramite.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                        AddOwnedForm(formOpcionesTramite);
                        AbrirFormInPanel(formOpcionesTramite);
                        break;

                    case 3:
                        FormOpcionesFactura formOpcionesFactura = new FormOpcionesFactura();
                        formOpcionesFactura.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                        AddOwnedForm(formOpcionesFactura);
                        AbrirFormInPanel(formOpcionesFactura);
                        break;

                    case 4:
                        FormOpcionesPagos formOpcionesPagos = new FormOpcionesPagos();
                        formOpcionesPagos.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                        AddOwnedForm(formOpcionesPagos);
                        AbrirFormInPanel(formOpcionesPagos);
                        break;

                    case 5:
                        FormOpcionesComisiones formOpcionesComisiones = new FormOpcionesComisiones();
                        formOpcionesComisiones.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                        AddOwnedForm(formOpcionesComisiones);
                        AbrirFormInPanel(formOpcionesComisiones);
                        break;

                    case 6:
                        preCrearComision();
                        break;

                    case 7:
                        preCrearComision();
                        break;
                    case 8:
                        opcionesImportaciones();
                        break;
                    case 9:
                        FormOpcionesReportes formOpcionesReportes = new FormOpcionesReportes();
                        formOpcionesReportes.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                        AddOwnedForm(formOpcionesReportes);
                        AbrirFormInPanel(formOpcionesReportes);
                        break;
                    case 10:
                        FormOpcionesCuentasCobrar formOpcionesCuentasCobrar = new FormOpcionesCuentasCobrar();
                        formOpcionesCuentasCobrar.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
                        AddOwnedForm(formOpcionesCuentasCobrar);
                        AbrirFormInPanel(formOpcionesCuentasCobrar);
                        break;



                    default:
                        break;
                }

            }



        }

        private void preCrearComision()
        {
            FormPreCrearComision formPreCrearComision = new FormPreCrearComision();
            formPreCrearComision.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            AddOwnedForm(formPreCrearComision);
            AbrirFormInPanel(formPreCrearComision);
        }

        private void opcionesImportaciones()
        {
            FormOpcionesImportaciones formOpcionesImportaciones = new FormOpcionesImportaciones();
            formOpcionesImportaciones.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            AddOwnedForm(formOpcionesImportaciones);
            AbrirFormInPanel(formOpcionesImportaciones);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnClientes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnTramites.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnImportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnExportaciones.BackColor = Color.FromArgb(57, 60, 67);
            btnReportes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnConfigurar.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);
            vCliente = false;
            vProveedor = false;
            vImportaciones = false;
            vExportaciones = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnClientes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnTramites.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnImportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnExportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnReportes.BackColor = Color.FromArgb(57, 60, 67);
            btnConfigurar.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);

            FormOpcionesReporteGeneral opcionesReporteGeneral = new FormOpcionesReporteGeneral();
            opcionesReporteGeneral.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
            AddOwnedForm(opcionesReporteGeneral);
            AbrirFormInPanel(opcionesReporteGeneral);

            vCliente = false;
            vProveedor = false;
            vImportaciones = false;
            vExportaciones = false;


        }



        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnClientes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnTramites.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnImportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnExportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnReportes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnConfigurar.BackColor = Color.FromArgb(57, 60, 67);
            btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);
            vCliente = false;
            vProveedor = false;
            vImportaciones = false;
            vExportaciones = false;
        }


        #endregion

        private void btnLogOut_Click(object sender, EventArgs e)
        {

           // Application.Restart();
            FormLogin loggin = new FormLogin();
            loggin.Show();
            this.Close();
        }


        private void mostrarLogo()
        {
            AbrirFormInPanel(new FormLogo());
        }

        public void mostrarLogoAlCerrar(object sender, FormClosedEventArgs e)
        {

            mostrarLogo();
            btnInicio.BackColor = Color.FromArgb(57, 60, 67);
            btnClientes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnTramites.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnImportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnExportaciones.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnReportes.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnConfigurar.BackColor = Color.FromArgb(150, 33, 31, 41);
            btnLogOut.BackColor = Color.FromArgb(150, 33, 31, 41);


            vCliente = false;
            vProveedor = false;
            vImportaciones = false;
            vExportaciones = false;
        }



        float anchoPanelIzquierdo = 0;
        private void mostrarMenu()
        {
            panelGlobal.ColumnStyles[0].Width = anchoPanelIzquierdo;
        }


        private void ocultarMenu()
        {
            anchoPanelIzquierdo = panelGlobal.ColumnStyles[0].Width;
           // panelGlobal.ColumnStyles[0].Width = panelGlobal.ColumnStyles[0].Width*14/100;
            panelGlobal.ColumnStyles[0].Width =  14 * anchoPanelIzquierdo / 100 ;

        }
        



        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ventanas abiertas", Application.OpenForms.Count.ToString());
        }

        float menuVertialAncho;
        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            panelGlobal.Visible = true;
            panelTitulo.Visible = true;

            menuVertialAncho = panelGlobal.ColumnStyles[0].Width;

            

        }

        private void btnOtrosServicios_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {


            LoadUserData();
            mostrarLogo();

            CultureInfo ci = new CultureInfo("Es-Es");

            DateTime fecha = DateTime.Today;
            lblFecha.Text = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek) + ", " +
                            fecha.Day.ToString() + " de " +
                            ci.DateTimeFormat.GetMonthName(DateTime.Now.Month) + " de " +
                            fecha.Year.ToString();



            if (UserCache.Position == Positions.Tramitacion)
            {
                btnExportaciones.Visible = false;
                btnOtrosServicios.Visible = false;
                btnRecaudacion.Visible = false;
                btnReportes.Visible = false;
                btnTramites.Visible = false;
            }
            /*
            if (UserCache.Position == Positions.Informacion)
            {
                btnClientes.Enabled = false;
                btnTramites.Enabled = false;
                btnImportaciones.Enabled = false;
               // btnPagos.Enabled = false;

            }
            */
            if (UserCache.Position == Positions.Clientes)
            {
                btnTramites.Visible = false;
                btnImportaciones.Visible = true;
                btnExportaciones.Visible = false;
                btnRecaudacion.Visible = false;
                btnReportes.Visible = false;
                btnOtrosServicios.Visible = false;
            }

            if (UserCache.Position == Positions.Export)
            {
                btnExportaciones.Visible = false;
                btnOtrosServicios.Visible = false;
                btnRecaudacion.Visible = false;
                btnReportes.Visible = false;
                btnTramites.Visible = false;
            }

            if (UserCache.Position == Positions.Contabilidad)
            {
                btnExportaciones.Visible = false;
                btnOtrosServicios.Visible = false;
                btnRecaudacion.Visible = false;
                btnReportes.Visible = false;
                btnTramites.Visible = false;
            }
        
            if (UserCache.Position == Positions.Contabilidad2)
            {
                btnExportaciones.Visible = false;
                btnOtrosServicios.Visible = false;
                btnRecaudacion.Visible = false;
                //btnReportes.Visible = false;
                btnTramites.Visible = false;
            }
}

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(33, 31, 41);
        }

        private void panelTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }


        private void LoadUserData()
        {
            lblUsuario.Text = " " + UserCache.FirstName + " " + UserCache.LastName;
            lblCargo.Text = " " + UserCache.Position;
            lblEmail.Text = " " + UserCache.Email; 
        }


    }
}
