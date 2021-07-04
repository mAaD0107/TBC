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
    public partial class FormOpcionesTramitesExportaciones : Form
    {
        public FormOpcionesTramitesExportaciones()
        {
            InitializeComponent();
        }

        private void irAtras()
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesExportaciones formOpcionesExportaciones = new FormOpcionesExportaciones();
                formOpcionesExportaciones.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesExportaciones);
                formPrincipal.AbrirFormInPanel(formOpcionesExportaciones);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {

            irAtras();
        }

        private void pnlBuscar_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblAgregarInfo.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblDocumentos.ForeColor = Color.FromArgb(57, 60, 67);
            btnCrear.BackColor = Color.FromArgb(41, 46, 54);
            btnAgregarInfo.BackColor = Color.FromArgb(41, 46, 54);
            btnBuscar.BackColor = Color.FromArgb(185, 209, 234);
            btnDocumentos.BackColor = Color.FromArgb(41, 46, 54);

            btnBuscar.Focus();
        }

        private void pnlEditarTramite_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblAgregarInfo.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblDocumentos.ForeColor = Color.FromArgb(185, 209, 234);
            btnCrear.BackColor = Color.FromArgb(41, 46, 54);
            btnAgregarInfo.BackColor = Color.FromArgb(41, 46, 54);
            btnBuscar.BackColor = Color.FromArgb(41, 46, 54);
            btnDocumentos.BackColor = Color.FromArgb(185, 209, 234);
           

            btnDocumentos.Focus();
        }
        private void panelCrearTramite_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblAgregarInfo.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblDocumentos.ForeColor = Color.FromArgb(57, 60, 67);
            btnCrear.BackColor = Color.FromArgb(185, 209, 234);
            btnAgregarInfo.BackColor = Color.FromArgb(41, 46, 54);
            btnBuscar.BackColor = Color.FromArgb(41, 46, 54);
            btnDocumentos.BackColor = Color.FromArgb(41, 46, 54);

            btnCrear.Focus();
        }
        private void pnlAgregarInfo_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblAgregarInfo.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblDocumentos.ForeColor = Color.FromArgb(57, 60, 67);
            btnCrear.BackColor = Color.FromArgb(41, 46, 54);
            btnAgregarInfo.BackColor = Color.FromArgb(185, 209, 234);
            btnBuscar.BackColor = Color.FromArgb(41, 46, 54);
            btnDocumentos.BackColor = Color.FromArgb(41, 46, 54);

            btnAgregarInfo.Focus();
        }
    }
}
