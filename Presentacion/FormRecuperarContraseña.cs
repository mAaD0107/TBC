using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentacion
{
    public partial class FormRecuperarContraseña : Form
    {
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario/Email")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario/Email";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviarPass();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enviarPass();
            }
        }

        private void enviarPass()
        {
            lblMessage.Text = "Estamos procesando tu solicitud...";
            btnEnviar.Enabled = false;

            var user = new UserModel();
            var result = user.recoverPassword(txtUsuario.Text);
            lblMessage.Text = result;

            if (lblMessage.Text.Contains("Lo sentimos"))
            {
                btnEnviar.Enabled = true;
            }
        }
    }
}
