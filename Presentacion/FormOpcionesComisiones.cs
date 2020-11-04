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
    public partial class FormOpcionesComisiones : Form
    {
        public FormOpcionesComisiones()
        {
            InitializeComponent();
        }

        private void panelCrear_Click(object sender, EventArgs e)
        {
            callComisiones();
        }

        private void panelCrear_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblEditar.ForeColor = Color.FromArgb(57, 60, 67);
        }

        private void callComisiones()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormBuscarTramite formOpcionesFactura = new FormBuscarTramite();
                formOpcionesFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesFactura);
                formPrincipal.AbrirFormInPanel(formOpcionesFactura);
            }
        }

        private void panelBuscar_Click(object sender, EventArgs e)
        {
            callBuscarComisiones();
        }

        private void callBuscarComisiones()
        {

        }

        private void panelBuscar_Enter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblEditar.ForeColor = Color.FromArgb(185, 209, 234);
        }
    }
}
