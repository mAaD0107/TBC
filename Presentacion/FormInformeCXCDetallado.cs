using Domain;
using Domain.CuentasPorCobrarDetallado;
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
    public partial class FormInformeCXCDetallado : Form
    {
        public FormInformeCXCDetallado()
        {
            InitializeComponent();
        }

        private void FormInformeCXCDetallado_Load(object sender, EventArgs e)
        {
            initVector();
            inicializarFecha();
            cargarDatos();
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

        private void cargarDatos()
        {
            InformeCXCDetallado informeCXC = new InformeCXCDetallado();
            informeCXC.CargarDatos();
            ListaCXCDBindingSource.DataSource = informeCXC.listaCXCD;
            this.reportViewer1.RefreshReport();
        }

        private void FormInformeCXCDetallado_Shown(object sender, EventArgs e)
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
            if (!disableInt)
            {
                if (dateDesde.Value > dateHasta.Value)
                {
                    dateDesde.Value = dateHasta.Value.AddDays(-1);
                }
                buscarDatos();
            }
        }

        bool disableInt = false;
        private void buscarDatos()
        {
            InformeCXCDetallado informeCXC = new InformeCXCDetallado();
            if (checkListVencimiento.CheckedItems.Count == 5 || checkListVencimiento.CheckedItems.Count == 0)
            {
                informeCXC.cargarDatosT(cmbClientes.Text, dateDesde.Value, dateHasta.Value, "TODOS");
            }
            else if (!hayNoVencida())
            {
                informeCXC.cargarDatosTL(cmbClientes.Text, dateDesde.Value, dateHasta.Value, s);
            }
            else
            {
                informeCXC.cargarDatosTL(cmbClientes.Text, dateDesde.Value, dateHasta.Value.AddDays(60), s);
                disableInt = true;
                dateHasta.Value = DateTime.Today;
                dateHasta.Value = dateHasta.Value.AddDays(60);
                disableInt = false;
            }
                
            
            ListaCXCDBindingSource.DataSource = informeCXC.listaCXCD;
            this.reportViewer1.RefreshReport();
        }

        private bool hayNoVencida()
        {
            for (int x = 0; x < checkListVencimiento.CheckedItems.Count; x++)
            {
                if (checkListVencimiento.CheckedItems[x].ToString() == "NO VENCIDA")
                {
                    return true;
                }
            }
            return false; 
        }

 

        private void cmbClientes_TextChanged_1(object sender, EventArgs e)
        {
            buscarDatos();
        }

        string[] s = new string[6];
        private void checkListVencimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkListVencimiento.CheckedItems.Count != 0)
            {
                for (int x = 0; x < s.Length; x++)
                    s[x] = "";

                if (checkListVencimiento.CheckedItems.Count == 5)
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
