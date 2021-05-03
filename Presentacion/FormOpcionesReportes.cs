using Common.Cache;
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
    public partial class FormOpcionesReportes : Form
    {
        public FormOpcionesReportes()
        {
            InitializeComponent();

            if (UserCache.Position == Positions.Clientes)
            {
                panelCuentasCobrar.Visible = false; 
            }
        }

        private void FormOpcionesReportes_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        private void panelCuentasCobrar_MouseEnter(object sender, EventArgs e)
        {
            lblCuentaCobrar1.ForeColor = Color.FromArgb(185, 209, 234);
            lblCuentaCobrar2.ForeColor = Color.FromArgb(185, 209, 234);
            lblCarta.ForeColor = Color.FromArgb(57, 60, 67);

            btnCuentasCobrar.Focus();
        }

        private void panelCuentasCobrar_Click(object sender, EventArgs e)
        {
            callOpcionesCuentasCobrar();
        }

        private void callOpcionesCuentasCobrar()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesCuentasCobrar formOpcionesCuentasCobrar = new FormOpcionesCuentasCobrar();
                formOpcionesCuentasCobrar.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesCuentasCobrar);
                formPrincipal.AbrirFormInPanel(formOpcionesCuentasCobrar);
            }
        }

        private void FormOpcionesReportes_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 8;
        }

        private void panelCarta_MouseEnter(object sender, EventArgs e)
        {
            lblCarta.ForeColor = Color.FromArgb(185, 209, 234);
            lblCuentaCobrar1.ForeColor = Color.FromArgb(57, 60, 67);
            lblCuentaCobrar2.ForeColor = Color.FromArgb(57, 60, 67);

            btnCarta.Focus();
        }

        private void panelCarta_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesCarta formOpcionesCarta = new FormOpcionesCarta();
                formOpcionesCarta.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesCarta);
                formPrincipal.AbrirFormInPanel(formOpcionesCarta);
            }
        }

        private void FormOpcionesReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
