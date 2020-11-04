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
    public partial class FormOpcionesPagos : Form
    {
        public FormOpcionesPagos()
        {
            InitializeComponent();
        }

        private void panelCrear_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblEditar.ForeColor = Color.FromArgb(57, 60, 67);

            btnCrear.Focus();
        }

        private void panelBuscar_Enter(object sender, EventArgs e)
        {
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblEditar.ForeColor = Color.FromArgb(185, 209, 234);
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);

            btnBuscar.Focus();
        }

        private void panelCrear_Click(object sender, EventArgs e)
        {
            callCrearPago();
        }

        private void callCrearPago()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            
            if (formPrincipal != null)
            {
                FormBuscarTramite formBuscarTramite = new FormBuscarTramite();
                formBuscarTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formBuscarTramite.panelBtnDer.Visible = false;
                formBuscarTramite.panelBtnIzq.Visible = false;
                formBuscarTramite.realizarPago = true; 
                formPrincipal.AddOwnedForm(formBuscarTramite);
                formPrincipal.AbrirFormInPanel(formBuscarTramite);
            }
        }

        private void FormOpcionesPagos_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 1;
        }
    }
}
