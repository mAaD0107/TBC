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
    public partial class FormBuscarFacturaPorCliente : Form
    {
        public FormBuscarFacturaPorCliente()
        {
            InitializeComponent();
        }

        public bool precargarDatos = false;
        private void FormBuscarFacturaPorCliente_Load(object sender, EventArgs e)
        {
            if (!precargarDatos)
            {
                cargarFechas();
                showClientes();
            }
            else
            {
                contTabla = FacturaCache.Tabla;
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


        private void showClientes()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readFacturasporClientes(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"));
        }


        private void showBusqueda()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readFacturasporClientesNombre(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"), txtBuscar.Text);
        }

        private void dateInicio_onValueChanged(object sender, EventArgs e)
        {
            compararFechas();
        }

        private void dateFin_onValueChanged(object sender, EventArgs e)
        {
            compararFechas();
        }

        private void compararFechas()
        {

            if (dateInicio.Value > dateFin.Value)
            {
                dateInicio.Value = dateFin.Value;
            }
            
            switch (contTabla)
            {
                case 0:
                   
                    if (txtBuscar.Text == "")
                    {
                        showClientes();
                    }
                    else
                    {
                        showBusqueda();
                    }

                    break;

                case 1:

                    if (txtBuscar.Text == "")
                    {
                        showTramites();

                    }
                    else
                    {
                        showTramitesBusqueda();
                    }

                    break;
                default:
                    break;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                compararFechas();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                compararFechas();

            }
        }

        int contTabla = 0;
        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iTabla = dataGridClientes.CurrentCell.RowIndex;

            switch (contTabla)
            {
                case 0:
                    FacturaCache.Cliente = dataGridClientes.Rows[iTabla].Cells[0].Value.ToString();
                    FacturaCache.RazonSocial = dataGridClientes.Rows[iTabla].Cells[1].Value.ToString();
                    FacturaCache.RUC = dataGridClientes.Rows[iTabla].Cells[2].Value.ToString();
                    break;

                case 1:
                    FacturaCache.ID_Tramite = dataGridClientes.Rows[iTabla].Cells[0].Value.ToString();
                    FacturaCache.DAI = dataGridClientes.Rows[iTabla].Cells[2].Value.ToString();
                    FacturaCache.SecuencialCliente = dataGridClientes.Rows[iTabla].Cells[3].Value.ToString();
                    FacturaCache.Tabla = contTabla;
                    FacturaCache.Buscar = txtBuscar.Text;
                    FacturaCache.DateDesde = dateInicio.Value;
                    FacturaCache.DateHasta = dateFin.Value;
                    
                    showInfoFacturas();
                    break; 

                default:
                    break;
            }




            contTabla++;
            showTramites();
        }

        private void showTramites()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readFacturasTramite(FacturaCache.RUC, dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"));
        }

        private void showTramitesBusqueda()
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.readFacturasTramiteB(
                FacturaCache.RUC, 
                dateInicio.Value.ToString("yyyy-MM-dd"), 
                dateFin.Value.ToString("yyyy-MM-dd"),
                txtBuscar.Text);
        }

        private void FormBuscarFacturaPorCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                contTabla--;
                if (contTabla < 0) contTabla = 0;
                compararFechas();
            }
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
                formPrincipal.AddOwnedForm(formInfo);
                formPrincipal.AbrirFormInPanel(formInfo);
            }
        }
    }
}
