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
    public partial class FormBuscarCarta : Form
    {
        public FormBuscarCarta()
        {
            InitializeComponent();
        }

        private void FormBuscarCarta_Load(object sender, EventArgs e)
        {
            cargarFechas();
            showClientes();
        }

        private void cargarFechas()
        {
            dateFin.Value = DateTime.Today.AddDays(0);
            dateInicio.Value = DateTime.Today.AddDays(-30);
        }


        private void showClientes()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readCartaCliente(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"));
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscar.Text != "")
                {
                    showClientesB();
                }
                else
                {
                    showClientes();
                }
            }
        }


        private void showClientesB()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readCartaClienteB(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"), txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showClientes();
            }
        }

        private void dateInicio_onValueChanged(object sender, EventArgs e)
        {
            if (dateInicio.Value > dateFin.Value)
            {
                dateInicio.Value = dateFin.Value;
            }

            if (txtBuscar.Text != "")
            {
                showClientesB();
            }
            else
            {
                showClientes();
            }
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int iTabla = dataGridClientes.CurrentCell.RowIndex;

            FacturaCache.Cliente = dataGridClientes.Rows[iTabla].Cells[0].Value.ToString();
            FacturaCache.RazonSocial = dataGridClientes.Rows[iTabla].Cells[1].Value.ToString();
            FacturaCache.RUC = dataGridClientes.Rows[iTabla].Cells[2].Value.ToString();
            FacturaCache.ID_Tramite = dataGridClientes.Rows[iTabla].Cells[3].Value.ToString();
            FacturaCache.SecuencialCliente = dataGridClientes.Rows[iTabla].Cells[4].Value.ToString();
            FacturaCache.DAI = dataGridClientes.Rows[iTabla].Cells[5].Value.ToString();
             

            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormInfoFacturasCarta formInfo = new FormInfoFacturasCarta();
                formInfo.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formInfo.txtTramite.Text = FacturaCache.ID_Tramite;
                formInfo.txtCliente.Text = FacturaCache.Cliente;
                formInfo.txtDAI.Text = FacturaCache.DAI;
                formInfo.txtSecuencialCliente.Text = FacturaCache.SecuencialCliente;
                formPrincipal.AddOwnedForm(formInfo);
                formPrincipal.AbrirFormInPanel(formInfo);
            }
        }
    }
}
