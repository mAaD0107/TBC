using Domain;
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
    public partial class FormBuscarProveedor : Form
    {
        public FormBuscarProveedor()
        {
            InitializeComponent();
        }

        private void FormBuscarProveedor_Load(object sender, EventArgs e)
        {
            showProveedores();
            acoplarPaneles();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void acoplarPaneles()
        {
            panelBotones.Width = this.Width;
            panelBtnDer.Width = (this.Width - 50) / 2;
            panelBtnIzq.Width = (this.Width - 30) / 2;
        }

        private void showProveedores()
        {
            UserModel Read = new UserModel();
            dataGridProveedores.DataSource = Read.readProveedores();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                searchData(txtBuscar.Text);

            }
        }

        private void searchData(string data)
        {
            UserModel Read = new UserModel();
            dataGridProveedores.DataSource = Read.searchProveedores(data);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            showProveedores();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            cargarCampos();
        }


        string[] values = new string[77];
        private void cargarCampos()
        {
            FormCrearProveedor formCrearProveedor = new FormCrearProveedor();

            int iTabla = dataGridProveedores.CurrentCell.RowIndex;

            for (int i = 0; i < 77 - 1; i++)
            {
                values[i] = dataGridProveedores.Rows[iTabla].Cells[i].Value.ToString();
            }


            formCrearProveedor.txtRUC.Text = values[0];
            formCrearProveedor.txtEmpresa.Text = values[1];
            formCrearProveedor.cmbTipoContribuyente.Text = values[2];

            formCrearProveedor.txtBeneficiario.Text = values[3];
            formCrearProveedor.cmbNomBanco.Text = values[4];
            formCrearProveedor.cmbTipoCuenta.Text = values[5];
            formCrearProveedor.txtNumeroCuenta.Text = values[6];

            formCrearProveedor.txtBeneficiario2.Text = values[7];
            formCrearProveedor.cmbNomBanco2.Text = values[8];
            formCrearProveedor.cmbTipoCuenta2.Text = values[9];
            formCrearProveedor.txtNumeroCuenta2.Text = values[10];

            formCrearProveedor.txtPC.Text = values[11];
            formCrearProveedor.txtPCEmail.Text = values[12];
            formCrearProveedor.txtPCTelf.Text = values[13];
            formCrearProveedor.txtPCCell.Text = values[14];
            formCrearProveedor.txtPCDepartamento.Text = values[15];
            formCrearProveedor.txtPCCargo.Text = values[16];

            formCrearProveedor.txtPC2.Text = values[17];
            formCrearProveedor.txtPCEmail2.Text = values[18];
            formCrearProveedor.txtPCTelf2.Text = values[19];
            formCrearProveedor.txtPCCell2.Text = values[20];
            formCrearProveedor.txtPCDepartamento2.Text = values[21];
            formCrearProveedor.txtPCCargo2.Text = values[22];

            formCrearProveedor.txtPC3.Text = values[23];
            formCrearProveedor.txtPCEmail3.Text = values[24];
            formCrearProveedor.txtPCTelf3.Text = values[25];
            formCrearProveedor.txtPCCell3.Text = values[26];
            formCrearProveedor.txtPCDepartamento3.Text = values[27];
            formCrearProveedor.txtPCCargo3.Text = values[28];

            formCrearProveedor.txtPC4.Text = values[29];
            formCrearProveedor.txtPCEmail4.Text = values[30];
            formCrearProveedor.txtPCTelf4.Text = values[31];
            formCrearProveedor.txtPCCell4.Text = values[32];
            formCrearProveedor.txtPCDepartamento4.Text = values[33];
            formCrearProveedor.txtPCCargo4.Text = values[34];

            formCrearProveedor.txtPC5.Text = values[35];
            formCrearProveedor.txtPCEmail5.Text = values[36];
            formCrearProveedor.txtPCTelf5.Text = values[37];
            formCrearProveedor.txtPCCell5.Text = values[38];
            formCrearProveedor.txtPCDepartamento5.Text = values[39];
            formCrearProveedor.txtPCCargo5.Text = values[40];

            formCrearProveedor.txtPC6.Text = values[41];
            formCrearProveedor.txtPCEmail6.Text = values[42];
            formCrearProveedor.txtPCTelf6.Text = values[43];
            formCrearProveedor.txtPCCell6.Text = values[44];
            formCrearProveedor.txtPCDepartamento6.Text = values[45];
            formCrearProveedor.txtPCCargo6.Text = values[46];

            formCrearProveedor.txtPC7.Text = values[47];
            formCrearProveedor.txtPCEmail7.Text = values[48];
            formCrearProveedor.txtPCTelf7.Text = values[49];
            formCrearProveedor.txtPCCell7.Text = values[50];
            formCrearProveedor.txtPCDepartamento7.Text = values[51];
            formCrearProveedor.txtPCCargo7.Text = values[52];

            formCrearProveedor.txtPC8.Text = values[53];
            formCrearProveedor.txtPCEmail8.Text = values[54];
            formCrearProveedor.txtPCTelf8.Text = values[55];
            formCrearProveedor.txtPCCell8.Text = values[56];
            formCrearProveedor.txtPCDepartamento8.Text = values[57];
            formCrearProveedor.txtPCCargo8.Text = values[58];

            formCrearProveedor.txtPC9.Text = values[59];
            formCrearProveedor.txtPCEmail9.Text = values[60];
            formCrearProveedor.txtPCTelf9.Text = values[61];
            formCrearProveedor.txtPCCell9.Text = values[62];
            formCrearProveedor.txtPCDepartamento9.Text = values[63];
            formCrearProveedor.txtPCCargo9.Text = values[64];

            formCrearProveedor.txtPC10.Text = values[65];
            formCrearProveedor.txtPCEmail10.Text = values[66];
            formCrearProveedor.txtPCTelf10.Text = values[67];
            formCrearProveedor.txtPCCell10.Text = values[68];
            formCrearProveedor.txtPCDepartamento10.Text = values[69];
            formCrearProveedor.txtPCCargo10.Text = values[70];

            formCrearProveedor.txtCallePrincipal.Text = values[71];
            formCrearProveedor.txtNumeracion.Text = values[72];
            formCrearProveedor.txtCalleSecundaria.Text = values[73];
            formCrearProveedor.txtNombreEdificio.Text = values[74];
            formCrearProveedor.txtReferencia.Text = values[75];

            if (formCrearProveedor.txtPC2.Text != "" || formCrearProveedor.txtPCEmail2.Text != "") {formCrearProveedor.panelPC2.Visible = true; formCrearProveedor.contPC = 1;}
            if (formCrearProveedor.txtPC3.Text != "" || formCrearProveedor.txtPCEmail3.Text != "") { formCrearProveedor.panelPC3.Visible = true; formCrearProveedor.contPC = 2; }
            if (formCrearProveedor.txtPC4.Text != "" || formCrearProveedor.txtPCEmail4.Text != "") { formCrearProveedor.panelPC4.Visible = true; formCrearProveedor.contPC = 3; }
            if (formCrearProveedor.txtPC5.Text != "" || formCrearProveedor.txtPCEmail5.Text != "") { formCrearProveedor.panelPC5.Visible = true; formCrearProveedor.contPC = 4; }
            if (formCrearProveedor.txtPC6.Text != "" || formCrearProveedor.txtPCEmail6.Text != "") { formCrearProveedor.panelPC6.Visible = true; formCrearProveedor.contPC = 5; }
            if (formCrearProveedor.txtPC7.Text != "" || formCrearProveedor.txtPCEmail7.Text != "") { formCrearProveedor.panelPC7.Visible = true; formCrearProveedor.contPC = 6; }
            if (formCrearProveedor.txtPC8.Text != "" || formCrearProveedor.txtPCEmail8.Text != "") { formCrearProveedor.panelPC8.Visible = true; formCrearProveedor.contPC = 7; }
            if (formCrearProveedor.txtPC9.Text != "" || formCrearProveedor.txtPCEmail9.Text != "") { formCrearProveedor.panelPC9.Visible = true; formCrearProveedor.contPC = 8; }
            if (formCrearProveedor.txtPC10.Text != "" || formCrearProveedor.txtPCEmail10.Text != "") { formCrearProveedor.panelPC10.Visible = true; formCrearProveedor.contPC = 9; }


            formCrearProveedor.panelBoton.Visible = false;
            formCrearProveedor.panelBtnNPC.Visible = false;

            formCrearProveedor.cmbNomBanco.Enabled = false;
            formCrearProveedor.cmbTipoCuenta.Enabled = false;
            formCrearProveedor.cmbNomBanco2.Enabled = false;
            formCrearProveedor.cmbTipoCuenta2.Enabled = false;
            formCrearProveedor.cmbTipoContribuyente.Enabled = false;

            formCrearProveedor.minimizar.Visible = true;
            formCrearProveedor.desplegar = true;

            formCrearProveedor.lblTitulo.Text = values[1];
            formCrearProveedor.Text = values[1];
            formCrearProveedor.Opacity = 0.9;
            formCrearProveedor.Height = Screen.PrimaryScreen.WorkingArea.Size.Height - 30;
            formCrearProveedor.Show();

        }

        private void dataGridProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCampos();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            formPrincipal.panelMenuVertical.Visible = true;
            formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

            this.Close();
        }


        bool maximized = false;
        int valAnterior = 0;
        private void maximizar_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarEditar();
        }

        private void cargarEditar()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearProveedor formCrearProveedor = new FormCrearProveedor();

                int iTabla = dataGridProveedores.CurrentCell.RowIndex;

                for (int i = 0; i < 77 - 1; i++)
                {
                    values[i] = dataGridProveedores.Rows[iTabla].Cells[i].Value.ToString();
                }


                formCrearProveedor.txtRUC.Text = values[0];
                formCrearProveedor.txtEmpresa.Text = values[1];
                formCrearProveedor.cmbTipoContribuyente.Text = values[2];

                formCrearProveedor.txtBeneficiario.Text = values[3];
                formCrearProveedor.cmbNomBanco.Text = values[4];
                formCrearProveedor.cmbTipoCuenta.Text = values[5];
                formCrearProveedor.txtNumeroCuenta.Text = values[6];

                formCrearProveedor.txtBeneficiario2.Text = values[7];
                formCrearProveedor.cmbNomBanco2.Text = values[8];
                formCrearProveedor.cmbTipoCuenta2.Text = values[9];
                formCrearProveedor.txtNumeroCuenta2.Text = values[10];

                formCrearProveedor.txtPC.Text = values[11];
                formCrearProveedor.txtPCEmail.Text = values[12];
                formCrearProveedor.txtPCTelf.Text = values[13];
                formCrearProveedor.txtPCCell.Text = values[14];
                formCrearProveedor.txtPCDepartamento.Text = values[15];
                formCrearProveedor.txtPCCargo.Text = values[16];

                formCrearProveedor.txtPC2.Text = values[17];
                formCrearProveedor.txtPCEmail2.Text = values[18];
                formCrearProveedor.txtPCTelf2.Text = values[19];
                formCrearProveedor.txtPCCell2.Text = values[20];
                formCrearProveedor.txtPCDepartamento2.Text = values[21];
                formCrearProveedor.txtPCCargo2.Text = values[22];

                formCrearProveedor.txtPC3.Text = values[23];
                formCrearProveedor.txtPCEmail3.Text = values[24];
                formCrearProveedor.txtPCTelf3.Text = values[25];
                formCrearProveedor.txtPCCell3.Text = values[26];
                formCrearProveedor.txtPCDepartamento3.Text = values[27];
                formCrearProveedor.txtPCCargo3.Text = values[28];

                formCrearProveedor.txtPC4.Text = values[29];
                formCrearProveedor.txtPCEmail4.Text = values[30];
                formCrearProveedor.txtPCTelf4.Text = values[31];
                formCrearProveedor.txtPCCell4.Text = values[32];
                formCrearProveedor.txtPCDepartamento4.Text = values[33];
                formCrearProveedor.txtPCCargo4.Text = values[34];

                formCrearProveedor.txtPC5.Text = values[35];
                formCrearProveedor.txtPCEmail5.Text = values[36];
                formCrearProveedor.txtPCTelf5.Text = values[37];
                formCrearProveedor.txtPCCell5.Text = values[38];
                formCrearProveedor.txtPCDepartamento5.Text = values[39];
                formCrearProveedor.txtPCCargo5.Text = values[40];

                formCrearProveedor.txtPC6.Text = values[41];
                formCrearProveedor.txtPCEmail6.Text = values[42];
                formCrearProveedor.txtPCTelf6.Text = values[43];
                formCrearProveedor.txtPCCell6.Text = values[44];
                formCrearProveedor.txtPCDepartamento6.Text = values[45];
                formCrearProveedor.txtPCCargo6.Text = values[46];

                formCrearProveedor.txtPC7.Text = values[47];
                formCrearProveedor.txtPCEmail7.Text = values[48];
                formCrearProveedor.txtPCTelf7.Text = values[49];
                formCrearProveedor.txtPCCell7.Text = values[50];
                formCrearProveedor.txtPCDepartamento7.Text = values[51];
                formCrearProveedor.txtPCCargo7.Text = values[52];

                formCrearProveedor.txtPC8.Text = values[53];
                formCrearProveedor.txtPCEmail8.Text = values[54];
                formCrearProveedor.txtPCTelf8.Text = values[55];
                formCrearProveedor.txtPCCell8.Text = values[56];
                formCrearProveedor.txtPCDepartamento8.Text = values[57];
                formCrearProveedor.txtPCCargo8.Text = values[58];

                formCrearProveedor.txtPC9.Text = values[59];
                formCrearProveedor.txtPCEmail9.Text = values[60];
                formCrearProveedor.txtPCTelf9.Text = values[61];
                formCrearProveedor.txtPCCell9.Text = values[62];
                formCrearProveedor.txtPCDepartamento9.Text = values[63];
                formCrearProveedor.txtPCCargo9.Text = values[64];

                formCrearProveedor.txtPC10.Text = values[65];
                formCrearProveedor.txtPCEmail10.Text = values[66];
                formCrearProveedor.txtPCTelf10.Text = values[67];
                formCrearProveedor.txtPCCell10.Text = values[68];
                formCrearProveedor.txtPCDepartamento10.Text = values[69];
                formCrearProveedor.txtPCCargo10.Text = values[70];

                formCrearProveedor.txtCallePrincipal.Text = values[71];
                formCrearProveedor.txtNumeracion.Text = values[72];
                formCrearProveedor.txtCalleSecundaria.Text = values[73];
                formCrearProveedor.txtNombreEdificio.Text = values[74];
                formCrearProveedor.txtReferencia.Text = values[75];

                if (formCrearProveedor.txtPC2.Text == "" || formCrearProveedor.txtPCEmail2.Text == "") { formCrearProveedor.panelPC2.Visible = true; formCrearProveedor.contPC = 1; }
                if (formCrearProveedor.txtPC3.Text == "" || formCrearProveedor.txtPCEmail3.Text == "") { formCrearProveedor.panelPC3.Visible = true; formCrearProveedor.contPC = 2; }
                if (formCrearProveedor.txtPC4.Text == "" || formCrearProveedor.txtPCEmail4.Text == "") { formCrearProveedor.panelPC4.Visible = true; formCrearProveedor.contPC = 3; }
                if (formCrearProveedor.txtPC5.Text == "" || formCrearProveedor.txtPCEmail5.Text == "") { formCrearProveedor.panelPC5.Visible = true; formCrearProveedor.contPC = 4; }
                if (formCrearProveedor.txtPC6.Text == "" || formCrearProveedor.txtPCEmail6.Text == "") { formCrearProveedor.panelPC6.Visible = true; formCrearProveedor.contPC = 5; }
                if (formCrearProveedor.txtPC7.Text == "" || formCrearProveedor.txtPCEmail7.Text == "") { formCrearProveedor.panelPC7.Visible = true; formCrearProveedor.contPC = 6; }
                if (formCrearProveedor.txtPC8.Text == "" || formCrearProveedor.txtPCEmail8.Text == "") { formCrearProveedor.panelPC8.Visible = true; formCrearProveedor.contPC = 7; }
                if (formCrearProveedor.txtPC9.Text == "" || formCrearProveedor.txtPCEmail9.Text == "") { formCrearProveedor.panelPC9.Visible = true; formCrearProveedor.contPC = 8; }
                if (formCrearProveedor.txtPC10.Text == "" || formCrearProveedor.txtPCEmail10.Text == "") { formCrearProveedor.panelPC10.Visible = true; formCrearProveedor.contPC = 9; }


                formCrearProveedor.lblTitulo.Text = "EDITAR";
                formCrearProveedor.txtRUC.Enabled = false;
                formCrearProveedor.editar = true;


                if (formPrincipal != null)
                {
                    formCrearProveedor.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formCrearProveedor);
                    formPrincipal.AbrirFormInPanel(formCrearProveedor);


                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();

            if (model.InsertDataProveedor(deleteDataClient()))
            {
                MessageBox.Show(
                "El cliente: " + nombre +
                "\nHa sido elimininado exitosamente",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

                showProveedores();
            }
            else
            {
                MessageBox.Show(
                "No ha sido posible eliminar al cliente\n" +
                "Por favor, inténtelo una vez más.",
                "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }

        string nombre;
        public string[] deleteDataClient()
        {
            int e = dataGridProveedores.CurrentCell.RowIndex;

            values[1] = dataGridProveedores.Rows[e].Cells[0].Value.ToString();
            nombre = dataGridProveedores.Rows[e].Cells[1].Value.ToString();

            for (int i = 2; i < 77; i++)
            {
                values[i] = "0";
            }

            values[0] = "Delete";


            return values;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showProveedores();
            }
        }

        private void FormBuscarProveedor_Resize(object sender, EventArgs e)
        {
            acoplarPaneles();
        }

        private void FormBuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormOpcionesProveedores formOpcionesProveedores = new FormOpcionesProveedores();
                    formOpcionesProveedores.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formOpcionesProveedores);
                    formPrincipal.AbrirFormInPanel(formOpcionesProveedores);
                }
            }
        }

        private void FormBuscarProveedor_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idProveedor = 2;
        }
    }
}
