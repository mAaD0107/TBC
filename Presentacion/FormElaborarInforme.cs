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
    public partial class FormElaborarInforme : Form
    {

        UserModel Read = new UserModel();

        public FormElaborarInforme()
        {
            InitializeComponent();
            this.panelGeneral.MouseWheel += new MouseEventHandler(panelScroll);
        }

        private void FormElaborarInforme_Load(object sender, EventArgs e)
        {
            cmbTipoEmpresa.SelectedIndex = 0;
        }

        private void cargarFacturasLDM()
        {
            dataGridInformes.DataSource = Read.informeLDM();
        }

        private void cargarFacturasTBC()
        {
            dataGridInformes.DataSource = Read.informeTBC();
        }

        private void cmbTipoFactura_TextChanged(object sender, EventArgs e)
        {
            switch (cmbTipoEmpresa.Text)
            {
                case "TBC (PAGO DIRECTO)":
                    cargarFacturasTBC();
                    break;

                case "LDM (INFORMES)":
                    cargarFacturasLDM();
                    break;
                default:
                    break;
            }
        }

        bool activarTrigger = false;

        private void FormElaborarInforme_Shown(object sender, EventArgs e)
        {
            activarTrigger = true;

        }

        private void dataGridInformes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatos();
        }

        int idTramite = 0;
        private void cargarDatos()
        {
            string[] values = new string[10];

            if (activarTrigger)
            {
                if (dataGridInformes.Rows.Count > 0)
                {
                    int indice = dataGridInformes.CurrentCell.RowIndex;
                    

                    if (dataGridInformes.ColumnCount > 0)
                    {

                        for (int i = 0; i < dataGridInformes.ColumnCount; i++)
                        {
                            values[i] = dataGridInformes.Rows[indice].Cells[i].Value.ToString();
                        }

                        idTramite = int.Parse(values[8]);

                        txtClienteTramite.Text = values[0];
                        txtDAI.Text = values[2];
                        txtSecuencialCliente.Text = values[3];
                        txtNFacturaLDM.Text = values[4];
                        txtSubTotalLDM.Text = double.Parse(values[5]).ToString("N2");
                        txtPersonaComision.Text = readComision(idTramite)[0];
                        txtValorComision.Text = double.Parse(readComision(idTramite)[1]).ToString("N2");
                        txtPersonaComisionExtra.Text = values[6];
                        txtValComisionExtra.Text = double.Parse(values[7]).ToString("N2");
                    }
                }
                

                string[] codigo = new string[4];

                switch (cmbTipoEmpresa.Text)
                {
                    case "TBC":
                        codigo[0] = "INF";
                        break;

                    case "LDM":
                        codigo[0] = "PD";
                        break;
                    
                    default:
                        codigo[0] = "INF";
                        break;
                }

                switch (values[9])
                {
                    case "Quito":
                        codigo[1] = "UIO";
                        break;

                    case "Guayaquil":
                        codigo[1] = "GYE";
                        break;

                    case "Tulcán":
                        codigo[1] = "TLC";
                        break;

                    case "Huaquillas":
                        codigo[1] = "HQL";
                        break; 
                    
                    default:
                        codigo[1] = "GYE";
                        break;
                }


                codigo[2] = readIDInforme();
                codigo[3] = readYear();

                txtNumInforme.Text = codigo[0] + " - " +
                                     codigo[1] + " - " +
                                     codigo[2] + " - " +
                                     codigo[3];

            }
        }


        private string readIDInforme()
        {
            UserModel Read = new UserModel();
            int idInforme = Read.readIDInformes() + 1;
            return idInforme.ToString("D4");
        }

        private string[] readComision(int idTramite)
        {
            UserModel Read = new UserModel();
            DataTable comisiones = Read.seacrhComisiones(idTramite);

            string[] tabla = new string[2];

            if (comisiones.Rows.Count > 0)
            {
                tabla[0] = comisiones.Rows[0]["Empresa"].ToString();
                tabla[1] = comisiones.Rows[0]["Valor"].ToString();

                if (tabla[1] == "")
                {
                    tabla[1] = "0";
                }
            }
            else
            {
                tabla[0] = "N/A";
                tabla[1] = "0";
            }


            return tabla; 
        }


        private string readYear()
        {
            DateTime fecha = DateTime.Today;
            return fecha.Year.ToString();
        }

        private void dataGridInformes_DataSourceChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }


        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            panelGeneral.VerticalScroll.Value = e.Value;
            panelGeneral.Focus();
            vScrollBar.Maximum = panelGeneral.VerticalScroll.Maximum - 440;
            vScrollBar.Value = panelGeneral.VerticalScroll.Value;

        }

        private void panelScroll(object sender, MouseEventArgs e)
        {
            panelGeneral.Focus();
            vScrollBar.Maximum = panelGeneral.VerticalScroll.Maximum - 440;
            vScrollBar.Value = panelGeneral.VerticalScroll.Value;

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                                                    "Seguro desea generar el Informe ?",
                                                    "Info.",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                UserModel Write = new UserModel();

                if (Write.InsertInforme(InsertData()))
                {
                    MessageBox.Show("Informe Generado :)");
                    FormInforme formInforme = new FormInforme();
                    formInforme.Show();
                }
                else
                {
                    MessageBox.Show("No ha sido posible generar el informe\n" +
                                    "Por favor, inténtelo mas tarde.",
                                    "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }

        }

        private string[] InsertData()
        {
            string[] dato = new string[13];

            dato[1] = readIDInforme();
            dato[2] = txtNumInforme.Text;
            dato[3] = txtClienteTramite.Text;
            dato[4] = txtDAI.Text;
            dato[5] = txtSecuencialCliente.Text;
            dato[6] = txtNFacturaLDM.Text;
            dato[7] = txtSubTotalLDM.Text;
            dato[8] = txtPersonaComision.Text;
            dato[9] = txtValorComision.Text;
            dato[10] = txtPersonaComisionExtra.Text;
            dato[11] = txtValComisionExtra.Text;
            dato[12] = idTramite.ToString();

            dato[0] = "Insert";

            return dato;
        }
    }
}
