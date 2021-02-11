using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentacion
{
    public partial class FormOpcionesCarta : Form
    {
        public FormOpcionesCarta()
        {
            InitializeComponent();
        }

        private void panelCrear_MouseEnter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscarEditar.ForeColor = Color.FromArgb(57, 60, 67);

            btnCrear.Focus();
        }

        private void panelBuscarEditar_MouseEnter(object sender, EventArgs e)
        {
            lblBuscarEditar.ForeColor = Color.FromArgb(185, 209, 234);
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);

            btnBuscar.Focus();
        }

        private void panelCrear_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormBuscarCarta formBuscarCarta = new FormBuscarCarta();
                formBuscarCarta.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);

                //formBuscarCarta.panelGeneral.RowStyles[2].Height = 0;
                //formBuscarCarta.panelGeneral.RowStyles[0].Height = (float)14;

                formPrincipal.panelInferior.Visible = false;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
                formPrincipal.AddOwnedForm(formBuscarCarta);
                formPrincipal.AbrirFormInPanel(formBuscarCarta);
            }
        }

        private void panelBuscarEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void FormOpcionesCarta_Load(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Contabilidad)
            {
                panelCrear.Visible = false;

            }
        }
    }
}
