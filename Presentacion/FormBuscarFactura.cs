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
    public partial class FormBuscarFactura : Form
    {
        public FormBuscarFactura()
        {
            InitializeComponent();
        }

        private void panelPorTramite_MouseEnter(object sender, EventArgs e)
        {
            lblTramiteCliente.ForeColor = Color.FromArgb(185, 209, 234);
            lblDetalle.ForeColor = Color.FromArgb(57, 60, 67);

            btnTramiteCliente.Focus();
        }

        private void panelporDetalle_MouseEnter(object sender, EventArgs e)
        {
            lblDetalle.ForeColor = Color.FromArgb(185, 209, 234);
            lblTramiteCliente.ForeColor = Color.FromArgb(57, 60, 67);

            btnDetalle.Focus();
        }

        private void FormBuscarFactura_Shown(object sender, EventArgs e)
        {

        }

        private void panelPorTramite_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarFacturaPorClienteTramite formBuscarFactura = new FormBuscarFacturaPorClienteTramite();
                formBuscarFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarFactura);
                formPrincipal.AbrirFormInPanel(formBuscarFactura);
            }
        }

        private void panelporDetalle_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarporDetalle formBuscarFactura = new FormBuscarporDetalle();
                formBuscarFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarFactura);
                formPrincipal.AbrirFormInPanel(formBuscarFactura);
            }
        }
    }
}
