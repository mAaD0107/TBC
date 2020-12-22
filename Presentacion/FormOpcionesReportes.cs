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
        }

        private void FormOpcionesReportes_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        private void panelCuentasCobrar_MouseEnter(object sender, EventArgs e)
        {
            lblCuentaCobrar1.ForeColor = Color.FromArgb(185, 209, 234);
            lblCuentaCobrar2.ForeColor = Color.FromArgb(185, 209, 234);

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
    }
}
