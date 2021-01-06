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
    public partial class FormBuscarFacturaPorClienteTramite : Form
    {
        public FormBuscarFacturaPorClienteTramite()
        {
            InitializeComponent();
        }

        private void panelCliente_MouseEnter(object sender, EventArgs e)
        {
            lblCliente.ForeColor = Color.FromArgb(185, 209, 234);
            lblTramite.ForeColor = Color.FromArgb(57, 60, 67);

            btnCliente.Focus();
        }

        private void panelTramite_MouseEnter(object sender, EventArgs e)
        {
            lblTramite.ForeColor = Color.FromArgb(185, 209, 234);
            lblCliente.ForeColor = Color.FromArgb(57, 60, 67);

            btnTramite.Focus();
        }

        private void panelCliente_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarFacturaPorCliente formBuscarFactura = new FormBuscarFacturaPorCliente();
                formBuscarFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarFactura);
                formPrincipal.AbrirFormInPanel(formBuscarFactura);
            }
        }

        private void panelTramite_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarFacturaporTramite formBuscarFactura = new FormBuscarFacturaporTramite();
                formBuscarFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formBuscarFactura);
                formPrincipal.AbrirFormInPanel(formBuscarFactura);
            }
        }
    }
}
