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
    public partial class FormTipoPago : Form
    {
        public FormTipoPago()
        {
            InitializeComponent();
        }

        private void panelUnico_Enter(object sender, EventArgs e)
        {
            lblUnico.ForeColor = Color.FromArgb(185, 209, 234);
            lblMultiple.ForeColor = Color.FromArgb(57, 60, 67);
            btnUnico.Focus();
        }

        private void panelMultiple_Enter(object sender, EventArgs e)
        {
            lblMultiple.ForeColor = Color.FromArgb(185, 209, 234);
            lblUnico.ForeColor = Color.FromArgb(57, 60, 67);
            btnMultiple.Focus();
        }

        private void panelUnico_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormCrearPago formCrearPago = new FormCrearPago();
                formCrearPago.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formCrearPago.panelInfoPago.Visible = true;
                formCrearPago.panelTipoPago.RowStyles[1].Height = 0;
                formPrincipal.AddOwnedForm(formCrearPago);
                formPrincipal.AbrirFormInPanel(formCrearPago);

                PagosCache.tipoPago = "unico";
            }
        }

        private void panelMultiple_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormCrearPago formCrearPago = new FormCrearPago();
                formCrearPago.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formCrearPago.panelPagoGeneral.Visible = true;
                formCrearPago.panelTipoPago.RowStyles[0].Height = 0;
                formCrearPago.cargarPagoGeneral = true; 
                formPrincipal.AddOwnedForm(formCrearPago);
                formPrincipal.AbrirFormInPanel(formCrearPago);

                PagosCache.tipoPago = "multiple";
            }

        }
    }
}
