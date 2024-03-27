using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using System.Threading;
using System.Threading.Tasks;
using Squirrel;
using System.Diagnostics;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            AddVersionNumber();
            CheckForUpdates();

        }

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            version.Text = $"V.{versionInfo.FileVersion}";
        }

        private async Task CheckForUpdates()
        {
            var repoUrl = "https://github.com/mAaD0107/TBC";
            using (var manager = await UpdateManager.GitHubUpdateManager(repoUrl))
            {
                await manager.UpdateApp();
            }


        }

        SplashScreen splash = null; 
        public void SplashStart()
        {
            try
            {
                splash = new SplashScreen();
                Application.Run(splash);
                //Application.Run(new SplashScreen());
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
            catch
            {}
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;

            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            loggear();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                loggear();
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }


        
        private void loggear()
        {
            if (txtuser.Text != "Usuario" && txtuser.Text != "")
            {
                if (txtpass.Text != "Contraseña")
                {
                    this.Hide();
                    // Crea un hilo 

                    
                    Thread t = new Thread(new ThreadStart(SplashStart));
                    t.SetApartmentState(ApartmentState.STA);
                    t.IsBackground = true; 
                    t.Start();
                    
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    
                    if (splash != null)
                    {
                        splash.CloseSplash();
                    }

                   
                    if (validLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.panelGlobal.Visible = false;
                        mainMenu.panelTitulo.Visible = false;
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrectos \nPor favor inténtelo de nuevo");
                        txtpass.Clear();
                        txtuser.Focus();
                        this.Show();
                    }
                    
                    

                }
                else msgError("Ingrese la contraseña");
            }
            else msgError("Ingrese el nombre de usuario");

        }


        private void btnlinkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperarContra = new FormRecuperarContraseña();
            recuperarContra.Show();

        }
    }
}
