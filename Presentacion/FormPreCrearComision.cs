using Common.Cache;
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
    public partial class FormPreCrearComision : Form
    {
        public FormPreCrearComision()
        {
            InitializeComponent();
        }

        private void FormPreCrearComision_Load(object sender, EventArgs e)
        {
            dateInicio.Value = DateTime.Today.AddDays(-60);
            dateFin.Value = DateTime.Today.AddDays(0);

            cmbCiudadNacionalizacion.SelectedIndex = 0;
            cmbTipoDocumento.SelectedIndex = 0;

            showTramites();

        }

        private void showTramites()
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.readTramitesComision();
        }

        string[] values = new string[3];
        private void buscarTramite()
        {
            UserModel Read = new UserModel();

            values[0] = dateInicio.Value.ToString("yyyy-MM-dd");
            values[1] = dateFin.Value.ToString("yyyy-MM-dd");
            values[2] = cmbCiudadNacionalizacion.Text;

            if (cmbTipoDocumento.Text == "Factura")
            {
                dataGridTramites.DataSource = Read.readTramitesComisionFactura(values);
            }
            else if (cmbTipoDocumento.Text == "Nota de Venta")
            {
                dataGridTramites.DataSource = Read.readTramitesComisionNotaVenta(values);
            }
        }

       
        private void dateInicio_onValueChanged(object sender, EventArgs e)
        {
            buscarTramite();
        }

        private void dateFin_onValueChanged(object sender, EventArgs e)
        {
            if (dateFin.Value > dateInicio.Value)
            {
                buscarTramite();
            }
            else
            {
                MessageBox.Show("La fecha limite debe ser mayor a la fecha de inicio",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                dateFin.Value = DateTime.Today.AddDays(0);
            }
            
        }

        private void cmbCiudadNacionalizacion_TextChanged(object sender, EventArgs e)
        {
            buscarTramite();
        }

        private void cmbTipoDocumento_TextChanged(object sender, EventArgs e)
        {
            buscarTramite();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool maximized = false;
        private float valAnterior = 0, valAntAltoMenuInf = 0;

        private void panelGeneral_Resize(object sender, EventArgs e)
        {
            panelTitulo.Width = this.Width - 30;
            panelTituloFiltro.Width = this.Width - 30;
            panelFiltros.Width = this.Width - 30;
            panelDatos.Width = this.Width - 30;


            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        private void dataGridTramites_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ComisionesCache.nTramite = int.Parse(dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[0].Value.ToString());
            ComisionesCache.CI = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[6].Value.ToString();
            ComisionesCache.tipoTramite = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            switch (cmbTipoDocumento.Text)
            {
                case "Nota de Venta":
                    if (formPrincipal != null)
                    {
                        FormCrearComisionNV formCrearComisionNV = new FormCrearComisionNV();
                        formCrearComisionNV.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formCrearComisionNV);
                        formPrincipal.AbrirFormInPanel(formCrearComisionNV);
                    }
                    break;

                case "Factura":
                    if (formPrincipal != null)
                    {
                        FormCrearComisionFactura formCrearComisionFactura = new FormCrearComisionFactura();
                        formCrearComisionFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formCrearComisionFactura);
                        formPrincipal.AbrirFormInPanel(formCrearComisionFactura);
                    }
                    break;

                default:
                    break;
            }

        }

        private void FormPreCrearComision_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 5;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (!maximized)
            {
                formPrincipal.panelMenuVertical.Visible = false;
                valAnterior = formPrincipal.panelGlobal.ColumnStyles[0].Width;
                valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;
                formPrincipal.panelInferior.Visible = false;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;

                lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2) + 15;




            }
            else
            {
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = valAntAltoMenuInf;
                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelInferior.Visible = true;

                lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);

            }


            maximized = !maximized;
        }
    
    }
}
