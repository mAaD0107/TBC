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
            this.panelGeneral.MouseWheel += new MouseEventHandler(panelScroll);
            
        }

        private void FormPreCrearComision_Load(object sender, EventArgs e)
        {
            dateInicio.Value = DateTime.Today.AddDays(-60);
            dateFin.Value = DateTime.Today.AddDays(0);

            
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            formPrincipal.panelInferior.Visible = false;
            formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
            showTramites();
            vScrollBar.Minimum = panelGeneral.VerticalScroll.Minimum;
            vScrollBar.Maximum = panelGeneral.VerticalScroll.Maximum;
            //hScrollBar.Maximum = dataFacturas.ColumnCount - 1;
            panelGeneral.VerticalScroll.Visible = false;
            panelGeneral.HorizontalScroll.Visible = false;
            ActiveControl = null;
            panelGeneral.Dock = DockStyle.Fill;
            panelGeneral.Focus();

        }

        private void showTramites()
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.readTramitesComision();
            acoplarScrolls();
        }
        int colMax;
        private void acoplarScrolls()
        {

            if (dataGridTramites.RowCount > 10)
            {
                if (dataGridTramites.RowCount == 1)
                {
                    datavScrollBar.Maximum = dataGridTramites.RowCount;
                }
                else
                {
                    datavScrollBar.Maximum = dataGridTramites.RowCount - 1;
                }

                datavScrollBar.Visible = true;

            }
            else
            {

                datavScrollBar.Minimum = 0;
                datavScrollBar.Maximum = 1;
                datavScrollBar.Visible = false;
            }

            if (dataGridTramites.ColumnCount > 0)
            {
                colMax = 0;
                for (int i = 0; i < dataGridTramites.ColumnCount; i++)
                    if (dataGridTramites.Columns[i].Visible) colMax++;

                hScrollBar.Maximum = colMax;
            }


        }
        private void panelContenedor_Scroll(object sender, ScrollEventArgs e)
        {
            // MessageBox.Show("scroll");
            //vScrollBar.Value = e.NewValue;
        }
        private void panelScroll(object sender, MouseEventArgs e)
        {
            panelGeneral.Focus();
            vScrollBar.Value = panelGeneral.VerticalScroll.Value;
        }
        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            panelGeneral.VerticalScroll.Value = e.Value;
        }
        private void datavScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            dataGridTramites.FirstDisplayedScrollingRowIndex = e.Value;
        }

        private void dataGridTramites_Scroll(object sender, ScrollEventArgs e)
        {
            datavScrollBar.Value = e.NewValue;
        }

        private void hScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {

            if (dataGridTramites.Columns[e.Value].Visible)
            {
                dataGridTramites.FirstDisplayedScrollingColumnIndex = e.Value;
            }

        }

        string[] values = new string[3];
        private void buscarTramite()
        {
            UserModel Read = new UserModel();

            values[0] = dateInicio.Value.ToString("yyyy-MM-dd");
            values[1] = dateFin.Value.ToString("yyyy-MM-dd");
            
            acoplarScrolls();
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
            ComisionesCache.Secuencial = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[3].Value.ToString();
            ComisionesCache.DAI = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[4].Value.ToString();
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if(dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[2].Value.ToString()=="Guayaquil")
            { 
                    
                        FormCrearComisionNV formCrearComisionNV = new FormCrearComisionNV();
                        formCrearComisionNV.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formCrearComisionNV);
                        formPrincipal.AbrirFormInPanel(formCrearComisionNV);
            }else { 
                   

              
                   
                        FormCrearComisionFactura formCrearComisionFactura = new FormCrearComisionFactura();
                        formCrearComisionFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                        formPrincipal.AddOwnedForm(formCrearComisionFactura);
                        formPrincipal.AbrirFormInPanel(formCrearComisionFactura);
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
                //valAntAltoMenuInf = formPrincipal.PanelSubContenedor.RowStyles[1].Height;
                formPrincipal.panelInferior.Visible = false;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;

                lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);




            }
            else
            {
                formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;
                formPrincipal.panelMenuVertical.Visible = true;
                //formPrincipal.panelInferior.Visible = true;

                lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);

            }


            maximized = !maximized;
        }
    
    }
}
