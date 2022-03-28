using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Domain.Comisiones;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInformeNV : Form
    {
        public FormInformeNV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getNV();
           
        }
        private void getNV()
        {
            InformeComisionesNV comisiones = new InformeComisionesNV();
            comisiones.CrearInformeComisionesNV();
            InformeComisionesNVBindingSource.DataSource = comisiones;
            this.reportViewer1.RefreshReport();

        }
    }
}
