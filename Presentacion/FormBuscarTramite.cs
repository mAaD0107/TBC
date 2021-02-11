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
    public partial class FormBuscarTramite : Form
    {
        public FormBuscarTramite()
        {
            InitializeComponent();
        }


        bool maximized = false;
        int valAnterior = 0;
        private void maximizar_Click(object sender, EventArgs e)
        {
            if (buscarTramite)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;

                if (!maximized)
                {
                    formPrincipal.panelMenuVertical.Visible = false;
                    valAnterior = (int)formPrincipal.panelGlobal.ColumnStyles[0].Width;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = 0;
                }
                else
                {
                    formPrincipal.panelMenuVertical.Visible = true;
                    formPrincipal.panelGlobal.ColumnStyles[0].Width = valAnterior;
                }
            }
            else
            {

            }

            maximized = !maximized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (!buscarTramite) // carga el tramite desde facturas
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                formPrincipal.panelMenuVertical.Visible = true;
                formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

                this.Close();
            }
            else
            {
                FormCrearFactura formCrearFactura = Owner as FormCrearFactura;
                formCrearFactura.buscarEstaAbierta = false;
                this.Close();
            }
        }

        public bool buscarTramite = false;
        private void FormBuscarTramite_Load(object sender, EventArgs e)
        {
            showTramites();
            this.SetStyle(ControlStyles.ResizeRedraw, true);


            if (buscarTramite)
            {
                searchData(txtBuscar.Text);
            }

            if (UserCache.Position == Positions.Tramitacion)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false; 
            }
        }

        public void showTramites()
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.readTramitesImport();
            acoplarScrolls();
        }


        private void FormBuscarTramite_Resize(object sender, EventArgs e)
        {
            acoplarPaneles();
        }

        private void acoplarPaneles()
        {
            panelBotones.Width = this.Width;
            panelBtnDer.Width = (this.Width - 50) / 2;
            panelBtnIzq.Width = (this.Width - 50) / 2;
        }



        public void searchData(string data)
        {
            UserModel Read = new UserModel();
            dataGridTramites.DataSource = Read.searchTramiteImport(data);
            acoplarScrolls();
        }


        private void acoplarScrolls()
        {

            if (dataGridTramites.RowCount > 0)
            {
                if (dataGridTramites.RowCount == 1)
                {
                    vScrollBar.Maximum = dataGridTramites.RowCount;
                }
                else
                {
                    vScrollBar.Maximum = dataGridTramites.RowCount - 1;
                }
                
            }
            else
            {

                vScrollBar.Minimum = 0;
                vScrollBar.Maximum = 1;
            }

            hScrollBar.Maximum = dataGridTramites.ColumnCount - 1;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showTramites();
            }
        }


        string[] values = new string[34];
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearTramite formCrearTramite = new FormCrearTramite();

                int iTabla = dataGridTramites.CurrentCell.RowIndex;

                for (int i = 0; i < 34 - 1; i++)
                {
                    values[i] = dataGridTramites.Rows[iTabla].Cells[i].Value.ToString();
                }

                formCrearTramite.txtNTramite.Text = values[1];
                formCrearTramite.RUCEmpresa = values[2];
                formCrearTramite.cmbTipoTramite.Text = values[3];
                formCrearTramite.cmbCiudadNacionalizacion.Text = values[4];
                formCrearTramite.txtSecuencialCliente.Text = values[5];
                formCrearTramite.txtProveedor.Text = values[6];
                formCrearTramite.txtNFacturaProveedor.Text = values[7];
                formCrearTramite.dateInicio.Value = Convert.ToDateTime(values[8]);
                formCrearTramite.dateLimite.Value = Convert.ToDateTime(values[9]);
                formCrearTramite.dateFinalizacion.Value = Convert.ToDateTime(values[10]);
                formCrearTramite.txtComentariosCrear.Text = values[11];


                formCrearTramite.txtDAI.Text = values[12];
                formCrearTramite.txtNLiquidacion.Text = values[13];
                formCrearTramite.txtOrdenLDM.Text = values[14];

                formCrearTramite.txtNContenedor.Text = values[15];
                formCrearTramite.txtNaviera.Text = values[16];
                formCrearTramite.txtForwarderMaritima.Text = values[17];

                formCrearTramite.txtNGuia.Text = values[18];
                formCrearTramite.txtAerolinea.Text = values[19];
                formCrearTramite.txtForwarderAerea.Text = values[20];

                formCrearTramite.txtPasePuerta.Text = values[21];
                formCrearTramite.txtTransportista.Text = values[22];
                formCrearTramite.txtForwarderTerrestre.Text = values[23];
                formCrearTramite.txtComentariosAgregar.Text = values[24];

                formCrearTramite.txtConcepto.Text = values[28];
                formCrearTramite.txtNBL.Text = values[29];

                formCrearTramite.txtNGuiaCourier.Text = values[30];
                formCrearTramite.txtAerolineaCourier.Text = values[31];
                formCrearTramite.txtForwarderCourier.Text = values[32];

                formCrearTramite.IDTramite = int.Parse(values[0]);


                formCrearTramite.lblTitulo.Text = "EDITAR";
                formCrearTramite.txtNTramite.Enabled = false;
                formCrearTramite.editar = true;



                

                if (formPrincipal != null)
                {
                    formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formCrearTramite);
                    formPrincipal.AbrirFormInPanel(formCrearTramite);
                }
            }
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            desplegarV();

        }

        public bool realizarPago = false; 
        private void dataGridTramites_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!realizarPago)
            {
                if (btnActualizar.Text == "Actualizar")
                {
                    if (buscarTramite)
                    {
                        FormCrearFactura formCrearFactura = Owner as FormCrearFactura;

                        if (formCrearFactura != null)
                        {
                            int n = int.Parse(dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[0].Value.ToString());
                            TramiteCache.nTramite = n;
                            TramiteCache.rucEmpresa = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[2].Value.ToString();
                            TramiteCache.DAI = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[12].Value.ToString();
                            TramiteCache.secuencialCliente = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[5].Value.ToString();
                            TramiteCache.idTramite = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();

                            formCrearFactura.txtBuscarTramite.Text = TramiteCache.idTramite;
                            formCrearFactura.txtBuscarTramite.TextAlign = HorizontalAlignment.Center;
                            using (Font font = new Font("Century Gothic", 14.0f)) formCrearFactura.txtBuscarTramite.Font = font;
                            formCrearFactura.txtBuscarTramite.ForeColor = Color.White;
                            formCrearFactura.txtBuscarTramite.Enabled = false;

                            formCrearFactura.txtDAI.Text = TramiteCache.DAI;
                            formCrearFactura.txtSecuencialCliente.Text = TramiteCache.secuencialCliente;
                            formCrearFactura.txtCliente.Text = TramiteCache.rucEmpresa;


                            UserModel Read = new UserModel();

                            Read.searchRetenciones(TramiteCache.rucEmpresa);


                            List<string> tipoFactura = new List<string>();
                            List<string> tipoFacturaOtros = new List<string>();

                            string[] array = Read.readTipoFactura(n).ToArray();
                            int indice = 0;

                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i] == "Otros")
                                {
                                    indice = i;
                                    break;
                                }
                            }

                            for (int i = 0; i <= indice; i++)
                            {
                                tipoFactura.Add(array[i]);
                            }

                            for (int i = indice + 1; i < array.Length; i++)
                            {
                                tipoFacturaOtros.Add(array[i]);
                            }

                            formCrearFactura.cmbTipoFactura.DataSource = tipoFactura;
                            formCrearFactura.cmbOtros.DataSource = tipoFacturaOtros;


                            formCrearFactura.readRetenciones();
                            formCrearFactura.buscarEstaAbierta = false;
                            this.Close();
                        }

                    }
                    else
                    {
                        desplegarV();
                    }

                }
                else
                {
                    agregarInformacion();
                }
            }
            else
            {
                TramiteCache.rucEmpresa = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();
                int n = int.Parse(dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[0].Value.ToString());

                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormTipoPago formCrearPago = new FormTipoPago();
                    formCrearPago.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    PagosCache.numeroTramite = n;

                    PagosCache.Empresa = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    PagosCache.DAI = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[12].Value.ToString();
                    PagosCache.secuencialCliente = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[5].Value.ToString();
                    PagosCache.idTramite = dataGridTramites.Rows[dataGridTramites.CurrentCell.RowIndex].Cells[1].Value.ToString();


                    formPrincipal.panelInferior.Visible = false;
                    formPrincipal.PanelSubContenedor.RowStyles[1].Height = 0;

                    formPrincipal.AddOwnedForm(formCrearPago);
                    formPrincipal.AbrirFormInPanel(formCrearPago);
                }

            }
        }


        public void desplegarV()
        {
            string numeroT;
            int numero;
            int iTabla;

            FormCrearTramite formCrearTramite = new FormCrearTramite();


            formCrearTramite.cmbEmpresa.FlatStyle = FlatStyle.Standard;
            formCrearTramite.cmbTipoTramite.FlatStyle = FlatStyle.Standard;
            formCrearTramite.cmbCiudadNacionalizacion.FlatStyle = FlatStyle.Standard;

            iTabla = dataGridTramites.CurrentCell.RowIndex;
            


            for (int i = 0; i < 34 - 1; i++)
            {
                values[i] = dataGridTramites.Rows[iTabla].Cells[i].Value.ToString();
            }

            formCrearTramite.txtNTramite.Text = values[1];
            formCrearTramite.RUCEmpresa = values[2];
            formCrearTramite.cmbTipoTramite.Text = values[3];
            formCrearTramite.cmbCiudadNacionalizacion.Text = values[4];
            formCrearTramite.txtSecuencialCliente.Text = values[5];
            formCrearTramite.txtProveedor.Text = values[6];
            formCrearTramite.txtNFacturaProveedor.Text = values[7];
            formCrearTramite.dateInicio.Value = Convert.ToDateTime(values[8]);
            formCrearTramite.dateLimite.Value = Convert.ToDateTime(values[9]);
            formCrearTramite.dateFinalizacion.Value = Convert.ToDateTime(values[10]);
            formCrearTramite.txtComentariosCrear.Text = values[11];


            formCrearTramite.txtDAI.Text = values[12];
            formCrearTramite.txtNLiquidacion.Text = values[13];
            formCrearTramite.txtOrdenLDM.Text = values[14];

            formCrearTramite.txtNContenedor.Text = values[15];
            formCrearTramite.txtNaviera.Text = values[16];
            formCrearTramite.txtForwarderMaritima.Text = values[17];

            formCrearTramite.txtNGuia.Text = values[18];
            formCrearTramite.txtAerolinea.Text = values[19];
            formCrearTramite.txtForwarderAerea.Text = values[20];

            formCrearTramite.txtPasePuerta.Text = values[21];
            formCrearTramite.txtTransportista.Text = values[22];
            formCrearTramite.txtForwarderTerrestre.Text = values[23];
            formCrearTramite.txtComentariosAgregar.Text = values[24];

            formCrearTramite.txtConcepto.Text = values[28];
            formCrearTramite.txtNBL.Text = values[29];

            formCrearTramite.txtNGuiaCourier.Text = values[30];
            formCrearTramite.txtAerolineaCourier.Text = values[31];
            formCrearTramite.txtForwarderCourier.Text = values[32];


            formCrearTramite.IDTramite = int.Parse(values[0]);


            formCrearTramite.lblTitulo.Text = "TRÁMITE";
            formCrearTramite.txtNTramite.Enabled = false;
            formCrearTramite.panelInferior.Visible = false;
            formCrearTramite.desplegar = true;
            //formCrearTramite.detectSecuencial();
            formCrearTramite.minimizar.Visible = true;
            formCrearTramite.editar = true;
            formCrearTramite.agregarInfo = true;


            formCrearTramite.panelDatos.Visible = true;
            formCrearTramite.cmbEmpresa.Enabled = false;
            formCrearTramite.cmbTipoTramite.Enabled = false;
            formCrearTramite.cmbCiudadNacionalizacion.Enabled = false;
            formCrearTramite.txtConcepto.Enabled = false;
            formCrearTramite.txtSecuencialCliente.Enabled = false;
            formCrearTramite.txtProveedor.Enabled = false;
            formCrearTramite.txtNFacturaProveedor.Enabled = false;
            formCrearTramite.dateInicio.Enabled = false;
            formCrearTramite.dateLimite.Enabled = false;
            formCrearTramite.dateFinalizacion.Enabled = false;
            formCrearTramite.txtComentariosCrear.Enabled = false;
            formCrearTramite.btnNuevaEmpresa.Visible = false;
            formCrearTramite.panelInferior.Visible = false; 

            formCrearTramite.Opacity = 0.9;
            formCrearTramite.Height = Screen.PrimaryScreen.WorkingArea.Size.Height - 30;
            numero = int.Parse(values[0]);
            numeroT = numero.ToString("D5");
            formCrearTramite.Text = "Trámite: "+ numeroT;
            formCrearTramite.StartPosition = FormStartPosition.CenterScreen;
            formCrearTramite.Show();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
            "Está seguro que desea eliminar el trámite ? ",
            "Alerta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation
            );

            if (result == DialogResult.Yes)
            {
                UserModel model = new UserModel();

                if (model.InsertDataTramite(deleteDataClient()))
                {
                    MessageBox.Show(
                    "El cliente: " + nombre +
                    "\nHa sido elimininado exitosamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    showTramites();
                }
                else
                {
                    MessageBox.Show(
                    "No ha sido posible eliminar el tramite\n" +
                    "Por favor, inténtelo una vez más.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }

           
        }


        string nombre = "";
        public string[] deleteDataClient()
        {
            int e = dataGridTramites.CurrentCell.RowIndex;

            values[1] = dataGridTramites.Rows[e].Cells[0].Value.ToString();
            nombre = dataGridTramites.Rows[e].Cells[1].Value.ToString();

            for (int i = 2; i < 31; i++)
            {
                values[i] = "0";
            }


            values[8] = "2020-10-01";
            values[9] = "2020-10-01"; 
            values[10] = "2020-10-01";

            values[0] = "Delete";


            return values;
        }

        private void FormBuscarTramite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormOpcionesTramite formOpcionesTramite = new FormOpcionesTramite();
                    formOpcionesTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formOpcionesTramite);
                    formPrincipal.AbrirFormInPanel(formOpcionesTramite);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (btnActualizar.Text == "Actualizar")
            {
                showTramites();
            }
            else
            {
                agregarInformacion();
            }
        }

        private void agregarInformacion()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            if (formPrincipal != null)
            {
                FormCrearTramite formCrearTramite = new FormCrearTramite();
                formCrearTramite.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                formCrearTramite.panelDatos.Visible = true;
                formCrearTramite.txtDAI.Focus();
                formCrearTramite.cmbEmpresa.Enabled = false;
                formCrearTramite.cmbTipoTramite.Enabled = false;
                formCrearTramite.cmbCiudadNacionalizacion.Enabled = false;
                formCrearTramite.txtConcepto.Enabled = false;
                formCrearTramite.txtSecuencialCliente.Enabled = false;
                formCrearTramite.txtProveedor.Enabled = false;
                formCrearTramite.txtNFacturaProveedor.Enabled = false;
                formCrearTramite.dateInicio.Enabled = false;
                formCrearTramite.dateLimite.Enabled = false;
                formCrearTramite.dateFinalizacion.Enabled = false;
                formCrearTramite.txtComentariosCrear.Enabled = false;
                formCrearTramite.btnNuevaEmpresa.Visible = false;

                formCrearTramite.cmbEmpresa.FlatStyle = FlatStyle.Standard;
                formCrearTramite.cmbTipoTramite.FlatStyle = FlatStyle.Standard;
                formCrearTramite.cmbCiudadNacionalizacion.FlatStyle = FlatStyle.Standard;


                int iTabla = dataGridTramites.CurrentCell.RowIndex;

                for (int i = 0; i < 34 - 1; i++)
                {
                    values[i] = dataGridTramites.Rows[iTabla].Cells[i].Value.ToString();
                }

                formCrearTramite.txtNTramite.Text = values[1];
                formCrearTramite.RUCEmpresa = values[2];
                formCrearTramite.cmbTipoTramite.Text = values[3];
                formCrearTramite.cmbCiudadNacionalizacion.Text = values[4];
                formCrearTramite.txtSecuencialCliente.Text = values[5];
                formCrearTramite.txtProveedor.Text = values[6];
                formCrearTramite.txtNFacturaProveedor.Text = values[7];
                formCrearTramite.dateInicio.Value = Convert.ToDateTime(values[8]);
                formCrearTramite.dateLimite.Value = Convert.ToDateTime(values[9]);
                formCrearTramite.dateFinalizacion.Value = Convert.ToDateTime(values[10]);
                formCrearTramite.txtComentariosCrear.Text = values[11];


                formCrearTramite.txtDAI.Text = values[12];
                formCrearTramite.txtNLiquidacion.Text = values[13];
                formCrearTramite.txtOrdenLDM.Text = values[14];

                formCrearTramite.txtNContenedor.Text = values[15];
                formCrearTramite.txtNaviera.Text = values[16];
                formCrearTramite.txtForwarderMaritima.Text = values[17];

                formCrearTramite.txtNGuia.Text = values[18];
                formCrearTramite.txtAerolinea.Text = values[19];
                formCrearTramite.txtForwarderAerea.Text = values[20];

                formCrearTramite.txtPasePuerta.Text = values[21];
                formCrearTramite.txtTransportista.Text = values[22];
                formCrearTramite.txtForwarderTerrestre.Text = values[23];
                formCrearTramite.txtComentariosAgregar.Text = values[24];

                formCrearTramite.txtConcepto.Text = values[28];
                formCrearTramite.txtNBL.Text = values[29];

                formCrearTramite.txtNGuiaCourier.Text = values[30];
                formCrearTramite.txtAerolineaCourier.Text = values[31];
                formCrearTramite.txtForwarderCourier.Text = values[32];

                formCrearTramite.IDTramite = int.Parse(values[0]);


                formCrearTramite.lblTitulo.Text = "Trámite";
                formCrearTramite.txtNTramite.Enabled = false;
                formCrearTramite.editar = true;
                formCrearTramite.agregarInfo = true;

                formPrincipal.AddOwnedForm(formCrearTramite);
                formPrincipal.AbrirFormInPanel(formCrearTramite);
            }
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormBuscarTramite_Shown(object sender, EventArgs e)
        {
            InterfaceCache.idImportaciones = 2;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscar.Text == "")
                {
                    showTramites();
                }
                else
                {
                    searchData(txtBuscar.Text);
                }
            }
        }

        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            dataGridTramites.FirstDisplayedScrollingRowIndex = e.Value;
        }

        private void dataGridTramites_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar.Value = e.NewValue;
        }

        private void hScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            dataGridTramites.FirstDisplayedScrollingColumnIndex = e.Value;
        }
    }
}
