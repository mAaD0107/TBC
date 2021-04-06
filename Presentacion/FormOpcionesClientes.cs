using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormOpcionesClientes : Form
    {
        public FormOpcionesClientes()
        {
            InitializeComponent();

        }

        private void opcionesClientes_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        private void panelCrear_MouseClick(object sender, MouseEventArgs e)
        {
            callFormClient();
        }







        private void callFormClient()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            try
            {
                FormCrearCliente formClientes = new FormCrearCliente();
                if (formPrincipal != null)
                {
                    formClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formClientes);
                    formPrincipal.AbrirFormInPanel(formClientes);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cargando...\n");
            }

        }



        private void panelBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            callFormBuscar();
        }




        private void callFormBuscar()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            try
            {
                FormBuscarClientes formBuscarClientes = new FormBuscarClientes();
                if (formPrincipal != null)
                {
                    formBuscarClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);

                    formBuscarClientes.panelGeneral.RowStyles[2].Height = 0;
                    formBuscarClientes.panelGeneral.RowStyles[0].Height = (float)14;
                    //formBuscarTramite.panelGeneral.RowStyles[1].Height = (float)30;

                    formPrincipal.panelInferior.Visible = false;
                    formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
                    //  formPrincipal.panelGlobal.ColumnStyles[0].Width = (float)0.1;
                    formPrincipal.AddOwnedForm(formBuscarClientes);
                    formPrincipal.AbrirFormInPanel(formBuscarClientes);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cargando...\n");
            }
        }

        private void panelEditar_MouseClick(object sender, MouseEventArgs e)
        {
            callFormEditar();
        }




        public bool fomrEditar = false;


        private void callFormEditar()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            try
            {
                FormEditarClientes formEditarClientes = new FormEditarClientes();
                if (formPrincipal != null)
                {
                    formEditarClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formEditarClientes);
                    formPrincipal.AbrirFormInPanel(formEditarClientes);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cargando...\n");
            }
        }

        private void panelCrear_MouseEnter(object sender, EventArgs e)
        {
            lblCrear.ForeColor = Color.FromArgb(185, 209, 234);
            lblBuscar.ForeColor = Color.FromArgb(57, 60, 67);
            lblEditar.ForeColor = Color.FromArgb(57, 60, 67);

            btnCrear.Focus();

        }

        private void panelCrear_MouseLeave(object sender, EventArgs e)
        {
            
        }



        private void panelBuscar_MouseEnter(object sender, EventArgs e)
        {
            lblBuscar.ForeColor = Color.FromArgb(185, 209, 234);
            lblEditar.ForeColor = Color.FromArgb(185, 209, 234);
            lblCrear.ForeColor = Color.FromArgb(57, 60, 67);

            btnBuscar.Focus();

        }

        private void panelBuscar_MouseLeave(object sender, EventArgs e)
        {

        }





        private void FormOpcionesClientes_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            callFormClient();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            callFormBuscar();
        }

        private void FormOpcionesClientes_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idCliente = 0; 
        }

        private void FormOpcionesClientes_Load(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Contabilidad2)
            {
                panelCrear.Visible = false;
            }
        }
    }
}
