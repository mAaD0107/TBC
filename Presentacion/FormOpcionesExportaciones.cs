using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentacion
{
    public partial class FormOpcionesExportaciones : Form
    {
        public FormOpcionesExportaciones()
        {
            InitializeComponent();

        }

        private void FormOpcionesExportaciones_Load(object sender, EventArgs e)
        {

        }
        private void panelTramite_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(185, 209, 234);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);
            btnTramite.BackColor = Color.FromArgb(185, 209, 234);
            btnFactura.BackColor = Color.FromArgb(41, 46, 54);
            btnPago.BackColor = Color.FromArgb(41, 46, 54);
            btnComision.BackColor = Color.FromArgb(41, 46, 54);
            btnReporte.BackColor = Color.FromArgb(41, 46, 54);
            btnTramite.Focus();
        }
        private void panelComisiones_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(185, 209, 234);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);
            btnTramite.BackColor = Color.FromArgb(41, 46, 54);
            btnFactura.BackColor = Color.FromArgb(41, 46, 54);
            btnPago.BackColor = Color.FromArgb(41, 46, 54);
            btnComision.BackColor = Color.FromArgb(185, 209, 234);
            btnReporte.BackColor = Color.FromArgb(41, 46, 54);
            btnTramite.Focus();
        }
        private void pnlFactura_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(185, 209, 234);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);
            btnTramite.BackColor = Color.FromArgb(41, 46, 54);
            btnFactura.BackColor = Color.FromArgb(185, 209, 234);
            btnPago.BackColor = Color.FromArgb(41, 46, 54);
            btnComision.BackColor = Color.FromArgb(41, 46, 54);
            btnReporte.BackColor = Color.FromArgb(41, 46, 54);
            btnFactura.Focus();
        }

        private void pnlPago_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(185, 209, 234);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);
            btnTramite.BackColor = Color.FromArgb(41, 46, 54);
            btnFactura.BackColor = Color.FromArgb(41, 46, 54);
            btnPago.BackColor = Color.FromArgb(185, 209, 234);
            btnComision.BackColor = Color.FromArgb(41, 46, 54);
            btnReporte.BackColor = Color.FromArgb(41, 46, 54);
            btnPago.Focus();
        }

        private void pnlReporte_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(185, 209, 234);
            btnTramite.BackColor = Color.FromArgb(41, 46, 54);
            btnFactura.BackColor = Color.FromArgb(41, 46, 54);
            btnPago.BackColor = Color.FromArgb(41, 46, 54);
            btnComision.BackColor = Color.FromArgb(41, 46, 54);
            btnReporte.BackColor = Color.FromArgb(185, 209, 234);
            btnReporte.Focus();
        }
        private void callOpcionesTramite()
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesTramitesExportaciones formOpcionesTramite = new FormOpcionesTramitesExportaciones();
                formOpcionesTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesTramite);
                formPrincipal.AbrirFormInPanel(formOpcionesTramite);
            }


        }
        private void panelTramite_Click(object sender, EventArgs e)
        {
            callOpcionesTramite();
        }
        private void pnlFactura_Click(object sender, EventArgs e)
        {
            callOpcionesFactura();
        }
        private void callOpcionesFactura()
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesFactura formOpcionesFactura = new FormOpcionesFactura();
                formOpcionesFactura.diferenciar_atras(2);
                formOpcionesFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesFactura);
                formPrincipal.AbrirFormInPanel(formOpcionesFactura);
            }
        }
        private void pnlReporte_Click(object sender, EventArgs e)
        {
            callOpcionesReportes();
        }

        private void callOpcionesReportes()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesReportes formOpcionesReportes = new FormOpcionesReportes();
                formOpcionesReportes.diferenciar_atras(2);
                formOpcionesReportes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesReportes);
                formPrincipal.AbrirFormInPanel(formOpcionesReportes);
            }
        }

       

        private void pnlPago_Click(object sender, EventArgs e)
        {

            FormInformeNotaVentaRita info = new FormInformeNotaVentaRita();
            info.Show();
        }
    }
}
