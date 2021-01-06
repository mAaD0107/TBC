using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion
{
    public partial class FormOpcionesFactura : Form
    {
        public FormOpcionesFactura()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
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

        private void panelCrearTramite_MouseEnter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblEditar.ForeColor = Color.FromArgb(57, 60, 67);

            btnCrear.Focus();
        }


        private void pnlBuscar_MouseEnter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblEditar.ForeColor = Color.FromArgb(185, 209, 234);

            btnBuscar.Focus();
        }




        private void panelCrearTramite_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            
            if (formPrincipal != null)
            {
                FormCrearFactura formCrearFactura = new FormCrearFactura();
                formCrearFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formCrearFactura.panelPrincipal.Visible = false;
                formPrincipal.AddOwnedForm(formCrearFactura);
                formPrincipal.AbrirFormInPanel(formCrearFactura);
            }
        }


        private void panelBuscarFactura_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarFactura formBuscarFactura = new FormBuscarFactura();
                formBuscarFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarFactura);
                formPrincipal.AbrirFormInPanel(formBuscarFactura);
            }
        }

        private void FormOpcionesFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                irAtras();
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

        private void FormOpcionesFactura_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 1;
        }

        private void FormOpcionesFactura_Load(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Export)
            {
                panelCrearFactura.Visible = false; 
            }
        }
    }
}
