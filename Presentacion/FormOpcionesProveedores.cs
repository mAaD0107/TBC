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
    public partial class FormOpcionesProveedores : Form
    {
        public FormOpcionesProveedores()
        {
            InitializeComponent();
        }

        private void panelCrear_MouseClick(object sender, MouseEventArgs e)
        {
            callCrearProveedor();
        }

        private void lblCrear_MouseClick(object sender, MouseEventArgs e)
        {
            callCrearProveedor();
        }

        private void imgCrear_MouseClick(object sender, MouseEventArgs e)
        {
            callCrearProveedor();
        }

        private void callCrearProveedor()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;


            FormCrearProveedor formCrearProveedor = new FormCrearProveedor();
            if (formPrincipal != null)
            {
                formCrearProveedor.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formCrearProveedor);
                formPrincipal.AbrirFormInPanel(formCrearProveedor);
            }

        }


        private void callBuscarProveedor()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;


            FormBuscarProveedor formBuscarProveedor = new FormBuscarProveedor();
            if (formPrincipal != null)
            {
                formBuscarProveedor.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarProveedor);
                formPrincipal.AbrirFormInPanel(formBuscarProveedor);
            }
        }



        private void callEditarProveedor()
        {

        }

        private void panelCrear_MouseEnter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblEditar.ForeColor = Color.FromArgb(57, 60, 67);

            btnCrear.Focus();
        }

        private void panelCrear_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panelCrear_MouseClick_1(object sender, MouseEventArgs e)
        {
            callCrearProveedor();
        }



        private void panelBuscar_MouseEnter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblEditar.ForeColor = Color.FromArgb(185, 209, 234);

            btnBuscar.Focus();
        }

        private void panelBuscar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panelBuscar_MouseClick_1(object sender, MouseEventArgs e)
        {
            callBuscarProveedor();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            callCrearProveedor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            callBuscarProveedor();
        }

        private void FormOpcionesProveedores_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idProveedor = 0;
        }
    }
}
