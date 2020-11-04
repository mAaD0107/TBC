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


namespace Presentacion
{
    public partial class FormEditarClientes : Form
    {
        public FormEditarClientes()
        {
            InitializeComponent();
        }


        private void showClients()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readClients();

        }

        private void FormEditarClientes_Load(object sender, EventArgs e)
        {
            showClients();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBuscar.Text);
        }

        private void searchData(string data)
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.searchClients(data);
        }

        private void cerrar_MouseClick(object sender, MouseEventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            formPrincipal.panelMenuVertical.Visible = true;
            formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

            this.Close();
        }


        bool maximized = false;


        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();

            if (model.InsertDataClient(deleteDataClient()))
            {
                MessageBox.Show(
                "El cliente: "+nombre+
                "\n Ha sido elimininado exitosamente",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

                showClients();
            }
            else
            {
                MessageBox.Show(
                "No ha sido posible eliminar al cliente\n"+
                "Por favor, inténtelo una vez más.",
                "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
            
            
        }



        
        private void btnEditar_Click(object sender, EventArgs e)
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            try
            {
                FormCrearCliente formClientes = new FormCrearCliente();

                int iTabla = dataGridClientes.CurrentCell.RowIndex;

                for (int i = 0; i < 32; i++)
                {
                    values[i] = dataGridClientes.Rows[iTabla].Cells[i].Value.ToString();
                }


                formClientes.txtRUC.Text = values[0];
                formClientes.txtEmpresa.Text = values[1];
                formClientes.txtPC.Text = values[2];
               // formClientes.txtPC1.Text = values[3];
                formClientes.txtPCTelf.Text = values[4];
                //formClientes.txtTelf1.Text = values[5];
                formClientes.txtPCEmail.Text = values[6];
               // formClientes.txtEmail1.Text = values[7];
                formClientes.txtTPC.Text = values[8];
               // formClientes.txtTPC2.Text = values[9];
               // formClientes.txtPCob.Text = values[10];
               // formClientes.txtPCob1.Text = values[11];
              //  formClientes.txtPCEmail.Text = values[12];
               // formClientes.txtPCEmail1.Text = values[13];
               // formClientes.txtPCobTelf.Text = values[14];
               // formClientes.txtPCobTelf1.Text = values[15];
                
                formClientes.txtSubtotalFAM.Text = values[16];
                formClientes.txtSubtotalFAA.Text = values[17];
                formClientes.txtRetRentaFA.Text = values[18];
                formClientes.txtRetIVAFA.Text = values[19];
                formClientes.txtDiasCreditoFA.Text = values[20];
                formClientes.txtComisionFAM.Text = values[21];
                formClientes.txtComisionFAA.Text = values[22];

                formClientes.txtSubtotalFTBC.Text = values[23];
                formClientes.txtRetRentaFTBC.Text = values[24];
                formClientes.txtIVAFTBC.Text = values[25];
                formClientes.txtDiasCreditoFTBC.Text = values[26];
               // formClientes.txtComisionesBancarias.Text = values[27];
                formClientes.txtPersonasComisionesExtra.Text = values[28];
                formClientes.txtValorComisionesExtra.Text = values[29];
                formClientes.txtDiasCreditoTransporte.Text = values[30];
                formClientes.txtDiasCreditoGastos.Text = values[31];

                formClientes.lblTitulo.Text = "EDITAR";
                formClientes.txtRUC.Enabled = false;
                formClientes.editar = true;

                if (formPrincipal != null)
                {
                    formClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formClientes);
                    formPrincipal.AbrirFormInPanel(formClientes);

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cargando...\n"+ex);
            }
        }


        string[] values = new string[74];
        string nombre;
        public string[] deleteDataClient()
        {
            int e = dataGridClientes.CurrentCell.RowIndex;
            
            values[1] = dataGridClientes.Rows[e].Cells[0].Value.ToString();
            nombre = dataGridClientes.Rows[e].Cells[1].Value.ToString();

            for (int i = 2; i < 74; i++)
            {
                values[i] = "0";
            }

            values[0] = "Delete";


            return values;
        }




        private int valAnterior = 0;
        private void maximizar_MouseClick(object sender, MouseEventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (!maximized)
            {
                formPrincipal.panelMenuVertical.Visible = false;
                valAnterior = (int)formPrincipal.panelGlobal.ColumnStyles[0].Width;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;
            }
            else
            {
                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
            }

            maximized = !maximized;

        }

        private void FormEditarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormOpcionesClientes formOpcionesClientes = new FormOpcionesClientes();
                    formOpcionesClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formOpcionesClientes);
                    formPrincipal.AbrirFormInPanel(formOpcionesClientes);
                }
            }
        }

        private void FormEditarClientes_Shown(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }
    }
}
