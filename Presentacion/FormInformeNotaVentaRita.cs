﻿using System;
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
    public partial class FormInformeNotaVentaRita : Form
    {
        public FormInformeNotaVentaRita()
        {
            InitializeComponent();
        }

        private void FormInformeNotaVentaRita_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
