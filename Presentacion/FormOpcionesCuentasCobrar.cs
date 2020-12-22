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
    public partial class FormOpcionesCuentasCobrar : Form
    {
        public FormOpcionesCuentasCobrar()
        {
            InitializeComponent();
        }

        private void FormOpcionesCuentasCobrar_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        private void panelGeneral_MouseEnter(object sender, EventArgs e)
        {
            lblDetallado.ForeColor = Color.FromArgb(57, 60, 67);
            lblGeneral.ForeColor = Color.FromArgb(185, 209, 234);

            btnGeneral.Focus();
        }

        private void panelDetallado_Enter(object sender, EventArgs e)
        {
            lblDetallado.ForeColor = Color.FromArgb(185, 209, 234);
            lblGeneral.ForeColor = Color.FromArgb(57, 60, 67);

            btnDetallado.Focus();
        }

        private void panelGeneral_Click(object sender, EventArgs e)
        {
            
        }

        private void panelDetallado_Click(object sender, EventArgs e)
        {
            callOpcionesDetallado();
        }

        private void callOpcionesDetallado()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormOpcionesDetallado formOpcionesDetallado = new FormOpcionesDetallado();
                formOpcionesDetallado.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formPrincipal.AddOwnedForm(formOpcionesDetallado);
                formPrincipal.AbrirFormInPanel(formOpcionesDetallado);
            }
        }

        private void FormOpcionesCuentasCobrar_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 9; 
        }
    }
}
