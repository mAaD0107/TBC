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
    public partial class FormBuscarporDetalle : Form
    {
        public FormBuscarporDetalle()
        {
            InitializeComponent();
        }

        private void FormBuscarporDetalle_Load(object sender, EventArgs e)
        {
            showFacturas();

            if (UserCache.Position == Positions.Contabilidad2)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showFacturas();
            }
        }

        private void showFacturas()
        {
            UserModel Read = new UserModel();
            dataGridDetalles.DataSource = Read.readInfoFacturasT();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchFacturas();
            }
        }

        private void searchFacturas()
        {
            UserModel Read = new UserModel();
            dataGridDetalles.DataSource = Read.readInfoFacturasTB(txtBuscar.Text);
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            desplegarFactura();
        }

        private void dataGridDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            desplegarFactura();
        }


        string[] values = new string[37];
        private void desplegarFactura()
        {
            UserModel Read = new UserModel();


            int iTabla = dataGridDetalles.CurrentCell.RowIndex;
            string nFactura = dataGridDetalles.Rows[iTabla].Cells[2].Value.ToString();

            Read.searchIDTramite(nFactura); // Carga datos del tramite en el Cache de Facturas
            DataTable Facturas = Read.readFacturas(nFactura);

            for (int i = 0; i < Facturas.Columns.Count; i++)
            {
                values[i] = Facturas.Rows[0][i].ToString();
            }

            FormCrearFactura formCrearFactura = new FormCrearFactura(1);

            formCrearFactura.txtNFactura.Text = values[0];
            formCrearFactura.txtEmpresa.Text = values[1];
            TramiteCache.nTramite = int.Parse(values[2]);
            formCrearFactura.tipoFact = values[3];
            formCrearFactura.dateFactura.Value = Convert.ToDateTime(values[4]);
            formCrearFactura.txtConceptoFactura.Text = values[5];
            formCrearFactura.txtSubtotalFactura.Text = values[6];
            formCrearFactura.valIVA1 = values[7];
            formCrearFactura.txtValIVA.Text = values[8];
            formCrearFactura.txtTotalFactura.Text = values[9];
            formCrearFactura.txtNumeroRetencion.Text = values[10];
            formCrearFactura.txtValorRetencioRenta.Text = values[11];
            formCrearFactura.valRetRenta = values[12];
            formCrearFactura.txtValorRetencionIVA.Text = values[13];
            formCrearFactura.valRetIVA = values[14];
            formCrearFactura.txtTotalRetencion.Text = values[15];
            formCrearFactura.txtNNotaCredito.Text = values[16];
            formCrearFactura.txtEmpresaNotCredito.Text = values[17];
            formCrearFactura.txtSubTotalNotCredito.Text = values[18];
            formCrearFactura.txtIVANotCredito.Text = values[19];
            formCrearFactura.txtTotalNotCredito.Text = values[20];
            formCrearFactura.txtValorCobrarFactura.Text = values[21];
            formCrearFactura.txtDiasCredito.Text = values[22];
            formCrearFactura.dateVencimiento.Value = Convert.ToDateTime(values[23]);
            formCrearFactura.txtComentarios.Text = values[24];
            formCrearFactura.txtSubT2.Text = values[25];
            formCrearFactura.valIVA2 = values[26];
            formCrearFactura.txtValIVA2.Text = values[27];
            formCrearFactura.txtSubT3.Text = values[28];
            formCrearFactura.valIVA3 = values[29];
            formCrearFactura.txtValIVA3.Text = values[30];
            formCrearFactura.txtNNotaCreditoII.Text = values[31];
            formCrearFactura.txtEmpresaNotCreditoII.Text = values[32];
            formCrearFactura.txtSubTotalNotCreditoII.Text = values[33];
            formCrearFactura.txtIVANotCreditoII.Text = values[34];
            formCrearFactura.txtTotalNotCreditoII.Text = values[35];

            formCrearFactura.txtBuscarTramite.Text = FacturaCache.ID_Tramite;
            formCrearFactura.txtCliente.Text = FacturaCache.Cliente;
            formCrearFactura.txtDAI.Text = FacturaCache.DAI;
            formCrearFactura.txtSecuencialCliente.Text = FacturaCache.SecuencialCliente;


            formCrearFactura.Buscar.Visible = false;
            formCrearFactura.txtNFactura.Enabled = false;
            formCrearFactura.tipoForm = 1;

            /*
             * tipoForm = 0 -> Form normal
             * tipoForm = 1 -> Form editar
             * tipoForm = 2 -> Form desplegar
             */


            if (double.TryParse(formCrearFactura.txtSubT2.Text, out double val))
            {
                if (val != 0)
                {
                    formCrearFactura.panelSubT2.Visible = true;
                    formCrearFactura.panelIVA2.Visible = true;
                }
                else
                {
                    formCrearFactura.panelSubT2.Visible = false;
                    formCrearFactura.panelIVA2.Visible = false;
                }

            }
            else
            {
                formCrearFactura.panelSubT2.Visible = false;
                formCrearFactura.panelIVA2.Visible = false;
            }

            if (double.TryParse(formCrearFactura.txtSubT3.Text, out double val2))
            {
                if (val2 != 0)
                {
                    formCrearFactura.panelSubT3.Visible = true;
                    formCrearFactura.panelIVA3.Visible = true;
                }
                else
                {
                    formCrearFactura.panelSubT3.Visible = false;
                    formCrearFactura.panelIVA3.Visible = false;
                }

            }
            else
            {
                formCrearFactura.panelSubT3.Visible = false;
                formCrearFactura.panelIVA3.Visible = false;
            }

            if (formCrearFactura.txtNNotaCredito.Text != "" || formCrearFactura.txtSubTotalNotCredito.Text != "")
            {
                formCrearFactura.panelTNC.Visible = true;
                formCrearFactura.panelNotaCredito.Visible = true;
                formCrearFactura.panelTotalNC.Visible = true;
            }

            if (formCrearFactura.txtNNotaCreditoII.Text != "" || formCrearFactura.txtSubTotalNotCreditoII.Text != "")
            {
                formCrearFactura.panelNotaCreditoII.Visible = true;
                formCrearFactura.panelTotalNCII.Visible = true;
            }


            formCrearFactura.mostrarFactura = true;

            formCrearFactura.btnIVA.Visible = false;
            formCrearFactura.BtnEliminarIVA.Visible = false;
            formCrearFactura.panelAgregarSubtotal.Visible = false;
            formCrearFactura.panelBotonesNotaCredito.Visible = false;
            formCrearFactura.panelInferior.Visible = false;

            formCrearFactura.Opacity = 0.95;
            formCrearFactura.Height = Screen.PrimaryScreen.WorkingArea.Size.Height - 30;
            formCrearFactura.Text = "Factura: " + values[0];
            formCrearFactura.StartPosition = FormStartPosition.CenterScreen;
            formCrearFactura.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            UserModel Read = new UserModel();

            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearFactura formCrearFactura = new FormCrearFactura(1);


                int iTabla = dataGridDetalles.CurrentCell.RowIndex;
                string nFactura = dataGridDetalles.Rows[iTabla].Cells[2].Value.ToString();
                Read.searchIDTramite(nFactura); // Carga datos del tramite en el Cache de Facturas

                DataTable facturas = Read.readFacturas(nFactura);

                for (int i = 0; i < facturas.Columns.Count; i++)
                {
                    values[i] = facturas.Rows[0][i].ToString();
                }


                formCrearFactura.txtNFactura.Text = values[0];
                formCrearFactura.txtEmpresa.Text = values[1];
                TramiteCache.nTramite = int.Parse(values[2]);
                formCrearFactura.tipoFact = values[3];
                formCrearFactura.dateFactura.Value = Convert.ToDateTime(values[4]);
                formCrearFactura.txtConceptoFactura.Text = values[5];
                formCrearFactura.txtSubtotalFactura.Text = values[6];
                formCrearFactura.valIVA1 = values[7];
                formCrearFactura.txtValIVA.Text = values[8];
                formCrearFactura.txtTotalFactura.Text = values[9];
                formCrearFactura.txtNumeroRetencion.Text = values[10];
                formCrearFactura.txtValorRetencioRenta.Text = values[11];
                formCrearFactura.valRetRenta = values[12];
                formCrearFactura.txtValorRetencionIVA.Text = values[13];
                formCrearFactura.valRetIVA = values[14];
                formCrearFactura.txtTotalRetencion.Text = values[15];
                formCrearFactura.txtNNotaCredito.Text = values[16];
                formCrearFactura.txtEmpresaNotCredito.Text = values[17];
                formCrearFactura.txtSubTotalNotCredito.Text = values[18];
                formCrearFactura.txtIVANotCredito.Text = values[19];
                formCrearFactura.txtTotalNotCredito.Text = values[20];
                formCrearFactura.txtValorCobrarFactura.Text = values[21];
                formCrearFactura.txtDiasCredito.Text = values[22];
                formCrearFactura.dateVencimiento.Value = Convert.ToDateTime(values[23]);
                formCrearFactura.txtComentarios.Text = values[24];
                formCrearFactura.txtSubT2.Text = values[25];
                formCrearFactura.valIVA2 = values[26];
                formCrearFactura.txtValIVA2.Text = values[27];
                formCrearFactura.txtSubT3.Text = values[28];
                formCrearFactura.valIVA3 = values[29];
                formCrearFactura.txtValIVA3.Text = values[30];
                formCrearFactura.txtNNotaCreditoII.Text = values[31];
                formCrearFactura.txtEmpresaNotCreditoII.Text = values[32];
                formCrearFactura.txtSubTotalNotCreditoII.Text = values[33];
                formCrearFactura.txtIVANotCreditoII.Text = values[34];
                formCrearFactura.txtTotalNotCreditoII.Text = values[35];

                formCrearFactura.txtBuscarTramite.Text = FacturaCache.ID_Tramite;
                formCrearFactura.txtCliente.Text = FacturaCache.Cliente;
                formCrearFactura.txtDAI.Text = FacturaCache.DAI;
                formCrearFactura.txtSecuencialCliente.Text = FacturaCache.SecuencialCliente;


                formCrearFactura.Buscar.Visible = false;
                formCrearFactura.txtNFactura.Enabled = false;
                formCrearFactura.tipoForm = 1;
                formCrearFactura.tipoFormulario = 1;
                formCrearFactura.editar = true;
                /*
                 * tipoForm = 0 -> Form normal
                 * tipoForm = 1 -> Form editar
                 * tipoForm = 2 -> Form desplegar
                 */


                if (double.TryParse(formCrearFactura.txtSubT2.Text, out double val))
                {
                    if (val != 0)
                    {
                        formCrearFactura.panelSubT2.Visible = true;
                        formCrearFactura.panelIVA2.Visible = true;
                    }
                    else
                    {
                        formCrearFactura.panelSubT2.Visible = false;
                        formCrearFactura.panelIVA2.Visible = false;
                    }

                }
                else
                {
                    formCrearFactura.panelSubT2.Visible = false;
                    formCrearFactura.panelIVA2.Visible = false;
                }

                if (double.TryParse(formCrearFactura.txtSubT3.Text, out double val2))
                {
                    if (val2 != 0)
                    {
                        formCrearFactura.panelSubT3.Visible = true;
                        formCrearFactura.panelIVA3.Visible = true;
                    }
                    else
                    {
                        formCrearFactura.panelSubT3.Visible = false;
                        formCrearFactura.panelIVA3.Visible = false;
                    }

                }
                else
                {
                    formCrearFactura.panelSubT3.Visible = false;
                    formCrearFactura.panelIVA3.Visible = false;
                }

                if (formCrearFactura.txtNNotaCredito.Text != "" || formCrearFactura.txtSubTotalNotCredito.Text != "")
                {
                    formCrearFactura.panelTNC.Visible = true;
                    formCrearFactura.panelNotaCredito.Visible = true;
                    formCrearFactura.panelTotalNC.Visible = true;
                }

                if (formCrearFactura.txtNNotaCreditoII.Text != "" || formCrearFactura.txtSubTotalNotCreditoII.Text != "")
                {
                    formCrearFactura.panelNotaCreditoII.Visible = true;
                    formCrearFactura.panelTotalNCII.Visible = true;
                }

                formCrearFactura.panelInferior.Visible = true;

                if (formPrincipal != null)
                {
                    formCrearFactura.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formCrearFactura);
                    formPrincipal.AbrirFormInPanel(formCrearFactura);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UserModel Write = new UserModel();
            FormPrincipal formPrincipal = Owner as FormPrincipal;


            if (formPrincipal != null)
            {
                int iTabla = dataGridDetalles.CurrentCell.RowIndex;
                string nFactura = dataGridDetalles.Rows[iTabla].Cells[2].Value.ToString();

                for (int i = 0; i < 37; i++)
                {
                    values[i] = "0";
                }

                values[0] = "Delete";
                values[1] = nFactura;
                values[3] = TramiteCache.nTramite.ToString();
                values[4] = dataGridDetalles.Rows[iTabla].Cells[0].Value.ToString();
                values[5] = "2020-03-03";
                values[24] = "2020-03-03";


                if (Write.InsertDataFactura(values))
                {
                    MessageBox.Show(
                    "La Factura: " + nFactura +
                    "\nHa sido elimininada exitosamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    showFacturas();
                }
                else
                {
                    MessageBox.Show(
                    "No ha sido posible eliminar la factura\n" +
                    "Por favor, inténtelo una vez más.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel Read = new UserModel();

            string texto = ""; 

            for (int i = 0; i < dataGridDetalles.RowCount; i++)
            {
                string nFactura = dataGridDetalles.Rows[i].Cells[2].Value.ToString();
                //MessageBox.Show(nFactura);
                DataTable datosF = Read.datosRetencionCredito(nFactura);

                string RUC = datosF.Rows[0][0].ToString();
                string nombreEmpresa = datosF.Rows[0][1].ToString();
                DateTime fechaFactura = Convert.ToDateTime(datosF.Rows[0][2].ToString());
                string tipoFactura = datosF.Rows[0][3].ToString();

                int DCFA = Convert.ToInt32(datosF.Rows[0][4].ToString());
                int DCTBC = Convert.ToInt32(datosF.Rows[0][5].ToString());
                int DCG = Convert.ToInt32(datosF.Rows[0][6].ToString());
                int DCT = Convert.ToInt32(datosF.Rows[0][7].ToString());

                int DiasCredito = 0;

                switch (tipoFactura)
                {
                    case "Agente":
                        DiasCredito = DCFA;
                        break;
                    case "Agente_LDM":
                        DiasCredito = DCFA;
                        break;
                    case "TBC":
                        DiasCredito = DCTBC;
                        break;


                    case "Transporte":
                        DiasCredito = DCT;
                        break;
                    case "Transporte_I":
                        DiasCredito = DCT;
                        break;
                    case "Transporte_II":
                        DiasCredito = DCT;
                        break;
                    case "Transporte_III":
                        DiasCredito = DCT;
                        break;



                    case "Honorarios":
                        DiasCredito = DCTBC;
                        break;
                    case "Honorarios_I":
                        DiasCredito = DCTBC;
                        break;
                    case "Honorarios_II":
                        DiasCredito = DCTBC;
                        break;
                    case "Honorarios_III":
                        DiasCredito = DCTBC;
                        break;


                    default:

                        DiasCredito = DCG;
                        break;
                }


                DateTime fechaVencimiento = fechaFactura.AddDays(DiasCredito);
                string dateVencimiento = fechaVencimiento.ToString("yyyy-MM-dd");

                //Actualizar
                bool estado = Read.updateFacturas(DiasCredito, dateVencimiento, nFactura);
                if (estado)
                {
                    texto += nFactura + "\t\t OK ";
                    //MessageBox.Show("La factura: " + nFactura + " se actualizo correctamente");
                }
                else
                {
                    texto += nFactura + "\t\t FALLO ";
                    //MessageBox.Show("La factura: " + nFactura + " NO se actualizo");
                }
            }

           // textBox1.Text = texto;
            MessageBox.Show("Proceso Finalizado...");
        }
    }
}
