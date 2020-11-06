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
    public partial class FormCrearComisionNV : Form
    {
        public FormCrearComisionNV()
        {
            InitializeComponent();
        }

        private void FormCrearComisionNV_Load(object sender, EventArgs e)
        {
            cargarComision();
            cmbNombres.SelectedIndex = 0;
        }

        double subTotalFacturaTBC = 0, subTotalAereo = 0, subTotalMaritimo = 0;

        private void panelGeneral_Resize(object sender, EventArgs e)
        {
            panelTitulo.Width = this.Width - 30;
            panelFiltros.Width = this.Width - 30;
            panelSubtotalLDM.Width = this.Width - 30;

        }

        private void panelTitulo_Resize(object sender, EventArgs e)
        {
            lblTitulo.Left = (lblTitulo.Parent.Width / 2) - (lblTitulo.Width / 2);
        }

        double subTotalLDM = 0, comision = 0;
        private void cargarComision()
        {
            DataTable comisiones = new DataTable();
            
            UserModel Read = new UserModel();
            comisiones = Read.searchComisionCliente(ComisionesCache.CI);

            subTotalFacturaTBC = double.Parse(comisiones.Rows[0]["Comisiones"].ToString());
            subTotalAereo = double.Parse(comisiones.Rows[0]["Subtotal_Factura_Aerea"].ToString());
            subTotalMaritimo = double.Parse(comisiones.Rows[0]["Subtotal_Factura_Maritima"].ToString());

            subTotalLDM = Read.searchValorFacturaLDM(ComisionesCache.nTramite);
            
            txtComisionTBC.Text = subTotalFacturaTBC.ToString("N2");

            if (subTotalFacturaTBC != subTotalLDM)
            {
                switch (ComisionesCache.tipoTramite)
                {
                    case "Marítimo":
                        comision = subTotalMaritimo;
                        break;

                    case "Aéreo":
                        comision = subTotalAereo;
                        break;

                    default:
                        comision = 0;
                        break;
                }
            }

            txtSubtotalLDM.Text = comision.ToString("N2");
        }
    }
}
