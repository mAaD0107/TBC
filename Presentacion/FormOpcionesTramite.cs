using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion
{
    public partial class FormOpcionesTramite : Form
    {
        public FormOpcionesTramite()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            irAtras();
        }


        private void callCrearTramite()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearTramite formCrearTramite = new FormCrearTramite();
                formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formCrearTramite.panelFormulario.Visible = false;
               // formCrearTramite.listaTramites.Visible = false; 
                formPrincipal.AddOwnedForm(formCrearTramite);
                formPrincipal.AbrirFormInPanel(formCrearTramite);
            }
        }


        private void FormOpcionesTramite_Load(object sender, EventArgs e)
        {

            if (UserCache.Position == Positions.Tramitacion)
            {
                panelCrear.Visible = false;
            }

            if (UserCache.Position == Positions.Export)
            {
                panelAgregarInfo.Visible = false;
            }

            if (UserCache.Position == Positions.Contabilidad)
            {
                panelCrear.Visible = false;
                panelAgregarInfo.Visible = false;
                panelDocumentos.Visible = false;
            }
        }


        private void irAtras()
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesImportaciones formOpcionesImportaciones = new FormOpcionesImportaciones();
                formOpcionesImportaciones.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesImportaciones);
                formPrincipal.AbrirFormInPanel(formOpcionesImportaciones);
            }
        }



        private void FormOpcionesTramite_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 1;
        }

        private void FormOpcionesTramite_KeyDown(object sender, KeyEventArgs e)
        {
            irAtras();
        }

        private void panelCrearTramite_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblAgregarInfo.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblDocumentos.ForeColor = Color.FromArgb(57, 60, 67);

            btnCrear.Focus();
        }

        private void pnlBuscar_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblAgregarInfo.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblDocumentos.ForeColor = Color.FromArgb(57, 60, 67);

            btnBuscar.Focus();
        }

        private void pnlEditarTramite_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblAgregarInfo.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblDocumentos.ForeColor = Color.FromArgb(185, 209, 234);

            btnDocumentos.Focus();
        }

        private void panelCrearTramite_Click(object sender, EventArgs e)
        {
            callCrearTramite();
        }

        private void pnlBuscar_Click(object sender, EventArgs e)
        {
            callBuscarTramite();
        }

        private void callBuscarTramite()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarTramite formBuscarTramite = new FormBuscarTramite();
                formBuscarTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarTramite);
                formPrincipal.AbrirFormInPanel(formBuscarTramite);
            }
        }

        private void lblAgregarInfo_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblAgregarInfo.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblDocumentos.ForeColor = Color.FromArgb(57, 60, 67);

            btnAgregarInfo.Focus();
        }

        private void lblAgregarInfo_Click(object sender, EventArgs e)
        {
            callAgregarInfo();
        }

        private void callAgregarInfo()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarTramite formBuscarTramite = new FormBuscarTramite();
                formBuscarTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formBuscarTramite.panelBtnDer.Visible = false;
                formBuscarTramite.btnEditar.Visible = false;
                formBuscarTramite.btnActualizar.Text = "Cargar";
                formPrincipal.AddOwnedForm(formBuscarTramite);
                formPrincipal.AbrirFormInPanel(formBuscarTramite);
            }
        }
    }
}
