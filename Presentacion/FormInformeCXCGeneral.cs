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
using Domain.CuentasPorCobrar;

namespace Presentacion
{
    public partial class FormInformeCXCGeneral : Form
    {
        public FormInformeCXCGeneral()
        {
            InitializeComponent();
        }

        private void FormInformeCXCGeneral_Load(object sender, EventArgs e)
        {
            initVector();
            inicializarFecha();
            cargarDatosGeneral();
        }

        private void initVector()
        {
            for (int x = 0; x < s.Length; x++)
                s[x] = "";

            s[0] = "TODOS";
        }
        private void inicializarFecha()
        {
            dateDesde.Value = DateTime.Today.AddYears(-1);
            dateHasta.Value = DateTime.Today;
        }

        private void cargarDatosGeneral()
        {
            InformeCXCGeneral informeCXC = new InformeCXCGeneral();
            informeCXC.CargarDatos();
            ListaCXCBindingSource.DataSource = informeCXC.listaCXC;
            this.reportViewer1.RefreshReport();
        }

        private void FormInformeCXCGeneral_Shown(object sender, EventArgs e)
        {
            UserModel Read = new UserModel();

            DataTable clientes = Read.getClientes();

            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Cliente";
            cmbClientes.ValueMember = "Cliente";

            cmbClientes.Enabled = true;
        }

        private void btnOcultarPanel_Click(object sender, EventArgs e)
        {
            if (panelFiltros.Width >= 245)
            {
                panelFiltros.Width = 15;
            }
            else
            {
                panelFiltros.Width = 245;
            }
        }

        private void cmbClientes_TextChanged(object sender, EventArgs e)
        {
            buscarDatos();
        }

        private void dateDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dateDesde.Value > dateHasta.Value)
            {
                dateDesde.Value = dateHasta.Value.AddDays(-1);
            }
            buscarDatos();
        }

        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {
            //buscarDatos();
        }


        private void buscarDatos()
        {
            InformeCXCGeneral informeCXC = new InformeCXCGeneral();
            if (checkListVencimiento.CheckedItems.Count == 4 || checkListVencimiento.CheckedItems.Count == 0)
            {
                informeCXC.cargarDatosT(cmbClientes.Text, dateDesde.Value, dateHasta.Value, "TODOS");
            }
            else
            {
                //MessageBox.Show("Buscando...");
                informeCXC.cargarDatosTL(cmbClientes.Text, dateDesde.Value, dateHasta.Value, s);
            }

            ListaCXCBindingSource.DataSource = informeCXC.listaCXC;
            this.reportViewer1.RefreshReport();
        }


        string[] s = new string[5];
        private void checkListVencimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkListVencimiento.CheckedItems.Count != 0)
            {
                for (int x = 0; x < s.Length; x++)
                    s[x] = "";

                if (checkListVencimiento.CheckedItems.Count == 4)
                {
                    s[0] = "TODOS";
                }
                else
                {
                    for (int x = 0; x < checkListVencimiento.CheckedItems.Count; x++)
                        s[x + 1] = checkListVencimiento.CheckedItems[x].ToString();
                }
            }
            buscarDatos();
        }
    }
}

