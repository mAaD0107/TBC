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
    public partial class FormOpcionesImportaciones : Form
    {
        public FormOpcionesImportaciones()
        {
            InitializeComponent();
        }

        private void panelTramite_MouseClick(object sender, MouseEventArgs e)
        {
            callOpcionesTramite();
        }




        private void callOpcionesTramite()
        {
            
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesTramite formOpcionesTramite = new FormOpcionesTramite();
                formOpcionesTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesTramite);
                formPrincipal.AbrirFormInPanel(formOpcionesTramite);
            }


        }





        private void callOpcionesFactura()
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesFactura formOpcionesFactura = new FormOpcionesFactura();
                formOpcionesFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesFactura);
                formPrincipal.AbrirFormInPanel(formOpcionesFactura);
            }
        }

        private void FormOpcionesImportaciones_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 0; 
        }



        private void FormOpcionesImportaciones_Load(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Contabilidad)
            {
                panelComisiones.Visible = false;
            }

            if (UserCache.Position == Positions.Contabilidad2)
            {
                panelTramite.Visible = false;
                panelComisiones.Visible = false;
                pnlReporte.Visible = false;
                //panelComisiones.Visible = false;
               // panelComisiones.Visible = false;
            }
        }



        private void panelTramite_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(185, 209, 234);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);

            btnTramite.Focus();
        }

        private void pnlFactura_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(185, 209, 234);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);

            btnFactura.Focus();
        }

        private void pnlPago_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(185, 209, 234);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);

            btnPago.Focus();
        }

        private void pnlReporte_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(57, 60, 67);
            lblReporte.ForeColor = Color.FromArgb(185, 209, 234);

            btnReporte.Focus();
        }

        private void panelTramite_Click(object sender, EventArgs e)
        {
            callOpcionesTramite();
        }

        private void pnlFactura_Click(object sender, EventArgs e)
        {
            callOpcionesFactura();
        }

        private void pnlPago_Click(object sender, EventArgs e)
        {
            callOpcionesPagos();
        }

        private void callOpcionesPagos()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesPagos formOpcionesPagos = new FormOpcionesPagos();
                formOpcionesPagos.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesPagos);
                formPrincipal.AbrirFormInPanel(formOpcionesPagos);
            }
        }

        private void panelComisiones_Click(object sender, EventArgs e)
        {
            callOpcionesComisiones();
        }

        private void panelComisiones_Enter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);
            lblFactura.ForeColor = Color.FromArgb(57, 60, 67);
            lblPago.ForeColor = Color.FromArgb(57, 60, 67);
            lblComisiones.ForeColor = Color.FromArgb(185, 209, 234);
            lblReporte.ForeColor = Color.FromArgb(57, 60, 67);


            btnComision.Focus();
        }

        private void callOpcionesComisiones()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesComisiones FormOpcionesComisiones = new FormOpcionesComisiones();
                FormOpcionesComisiones.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(FormOpcionesComisiones);
                formPrincipal.AbrirFormInPanel(FormOpcionesComisiones);
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
                formOpcionesReportes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesReportes);
                formPrincipal.AbrirFormInPanel(formOpcionesReportes);
            }
        }
    }
}
