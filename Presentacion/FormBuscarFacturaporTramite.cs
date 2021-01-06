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
    public partial class FormBuscarFacturaporTramite : Form
    {
        public FormBuscarFacturaporTramite()
        {
            InitializeComponent();
        }


        public bool precargarDatos = false; 
        private void FormBuscarFacturaporTramite_Load(object sender, EventArgs e)
        {
            if (!precargarDatos)
            {
                cargarFechas();
                showTramites();
            }
            else
            {
                txtBuscar.Text = FacturaCache.Buscar;
                dateFin.Value = FacturaCache.DateHasta;
                dateInicio.Value = FacturaCache.DateDesde;
                compararFechas();
            }

        }


        private void cargarFechas()
        {
            dateInicio.Value = DateTime.Today.AddDays(-30);
            dateFin.Value = DateTime.Today.AddDays(0);

        }

        private void showTramites()
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.readFacturasTramiteT(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"));
        }

        private void dateInicio_onValueChanged(object sender, EventArgs e)
        {
            compararFechas();
        }

        private void compararFechas()
        {
            if (dateInicio.Value > dateFin.Value)
            {
                dateInicio.Value = dateFin.Value;
            }

            if (txtBuscar.Text == "")
            {
                showTramites();
            }
            else
            {
                showBusqueda();
            }
        }


        private void showBusqueda()
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.readFacturasTramiteTB(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"), txtBuscar.Text);
        }

        private void FormBuscarFacturaporTramite_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showTramites();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showBusqueda();
            }
        }

        private void dataGridTramites_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iTabla = dataGridTramites.CurrentCell.RowIndex;

            FacturaCache.ID_Tramite = dataGridTramites.Rows[iTabla].Cells[0].Value.ToString();
            FacturaCache.Cliente = dataGridTramites.Rows[iTabla].Cells[1].Value.ToString();
            FacturaCache.DAI = dataGridTramites.Rows[iTabla].Cells[2].Value.ToString();
            FacturaCache.SecuencialCliente = dataGridTramites.Rows[iTabla].Cells[3].Value.ToString();
            FacturaCache.Buscar = txtBuscar.Text;
            FacturaCache.DateDesde = dateInicio.Value;
            FacturaCache.DateHasta = dateFin.Value;

            showInfoFacturas();
        }

        private void showInfoFacturas()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormInfoFacturasTramite formInfo = new FormInfoFacturasTramite();
                formInfo.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formInfo.txtTramite.Text = FacturaCache.ID_Tramite;
                formInfo.txtCliente.Text = FacturaCache.Cliente;
                formInfo.txtDAI.Text = FacturaCache.DAI;
                formInfo.txtSecuencialCliente.Text = FacturaCache.SecuencialCliente;
                formInfo.tipoFormulario = 1;
                formPrincipal.AddOwnedForm(formInfo);
                formPrincipal.AbrirFormInPanel(formInfo);
            }
        }
    }
}
