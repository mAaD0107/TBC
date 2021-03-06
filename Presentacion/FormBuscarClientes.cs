﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using Presentacion.ClasesComplementarias;

namespace Presentacion
{
    public partial class FormBuscarClientes : Form
    {
        public FormBuscarClientes()
        {
            InitializeComponent();
        }

        SplashScreen splash = null;
        public void SplashStart()
        {
            try
            {
                splash = new SplashScreen();
                Application.Run(splash);
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
            catch
            { }
        }


        private void SplashShow()
        { 
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
        }

        private void SplashClose()
        {
            if (splash != null)
            {
                splash.CloseSplash();
            }
        }

        DataTable clientes;
        private void showClients()
        {
            UserModel Read = new UserModel();
            clientes = Read.readClients();
            dataGridClientes.DataSource = Read.readShortClientes();
            acoplarScrolls();

        }

        private void FormBuscarClientes_Load(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            formPrincipal.Hide();
            SplashShow();
            showClients();
            acoplarPaneles();
            SplashClose();
            formPrincipal.Show();
        }

        private void acoplarPaneles()
        {
            panelBotones.Width = this.Width;
            panelBtnDer.Width = (this.Width - 50)/ 2;
            panelBtnIzq.Width = (this.Width - 50) / 2;
        }


        // btn desplegar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           // searchData(txtBuscar.Text);
        }

        private void searchData(string data)
        {
            UserModel Read = new UserModel();
            dataGridClientes.DataSource = Read.searchClients(data);
            acoplarScrolls();
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            agregarCampos();
        }

        private void agregarCampos()
        {
            FormCrearCliente formClientes = new FormCrearCliente();

            int iTabla = dataGridClientes.CurrentCell.RowIndex;
            string RUC = dataGridClientes.Rows[iTabla].Cells[0].Value.ToString();
            
            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                if (clientes.Rows[i][0].ToString() == RUC)
                {
                    iTabla = i;
                    break; 
                }
            }

            for (int i = 0; i < 127 - 1; i++)
            {
               // values[i] = dataGridClientes.Rows[iTabla].Cells[i].Value.ToString();
                values[i] = clientes.Rows[iTabla][i].ToString();
            }

            formClientes.txtRUC.Text = values[0];
            formClientes.txtEmpresa.Text = values[1];
            formClientes.txtPC.Text = values[2];
            formClientes.txtPCTelf.Text = values[3];
            formClientes.txtPCCell.Text = values[4];
            formClientes.txtPCEmail.Text = values[5];
            formClientes.txtTPC.Text = values[6];
            formClientes.txtPCCargo.Text = values[7];
            formClientes.txtPC2.Text = values[8];
            formClientes.txtPCTelf2.Text = values[9];
            formClientes.txtPCCell2.Text = values[10];
            formClientes.txtPCEmail2.Text = values[11];
            formClientes.txtTPC2.Text = values[12];
            formClientes.txtPCCargo2.Text = values[13];
            formClientes.txtPC3.Text = values[14];
            formClientes.txtPCTelf3.Text = values[15];
            formClientes.txtPCCell3.Text = values[16];
            formClientes.txtPCEmail3.Text = values[17];
            formClientes.txtTPC3.Text = values[18];
            formClientes.txtPCCargo3.Text = values[19];
            formClientes.txtPC4.Text = values[20];
            formClientes.txtPCTelf4.Text = values[21];
            formClientes.txtPCCell4.Text = values[22];
            formClientes.txtPCEmail4.Text = values[23];
            formClientes.txtTPC4.Text = values[24];
            formClientes.txtPCCargo4.Text = values[25];
            formClientes.txtPC5.Text = values[26];
            formClientes.txtPCTelf5.Text = values[27];
            formClientes.txtPCCell5.Text = values[28];
            formClientes.txtPCEmail5.Text = values[29];
            formClientes.txtTPC5.Text = values[30];
            formClientes.txtPCCargo5.Text = values[31];
            formClientes.txtPCob.Text = values[32];
            formClientes.txtPCobEmail.Text = values[33];
            formClientes.txtPCobTel.Text = values[34];
            formClientes.txtPCobCell.Text = values[35];
            formClientes.txtPCob2.Text = values[36];
            formClientes.txtPCobEmail2.Text = values[37];
            formClientes.txtPCobTel2.Text = values[38];
            formClientes.txtPCobCell2.Text = values[39];
            formClientes.txtPCob3.Text = values[40];
            formClientes.txtPCobEmail3.Text = values[41];
            formClientes.txtPCobTel3.Text = values[42];
            formClientes.txtPCobCell3.Text = values[43];
            formClientes.txtSubtotalFAM.Text = values[44];
            formClientes.txtSubtotalFAA.Text = values[45];
            formClientes.txtRetRentaFA.Text = values[46];
            formClientes.txtRetIVAFA.Text = values[47];
            formClientes.txtDiasCreditoFA.Text = values[48];
            formClientes.txtComisionFAM.Text = values[49];
            formClientes.txtComisionFAA.Text = values[50];
            formClientes.txtSubtotalFTBC.Text = values[51];
            formClientes.txtRetRentaFTBC.Text = values[52];
            formClientes.txtIVAFTBC.Text = values[53];
            formClientes.txtDiasCreditoFTBC.Text = values[54];
            formClientes.cmbComisionesBancarias.Text = values[55];
            formClientes.txtPersonasComisionesExtra.Text = values[56];
            formClientes.txtValorComisionesExtra.Text = values[57];
            formClientes.txtDiasCreditoTransporte.Text = values[58];
            formClientes.txtDiasCreditoGastos.Text = values[59];
            formClientes.txtBeneficiario.Text = values[60];
            formClientes.cmbNomBanco.Text = values[61];
            formClientes.cmbTipoCuenta.Text = values[62];
            formClientes.txtNumeroCuenta.Text = values[63];
            formClientes.txtBeneficiario2.Text = values[64];
            formClientes.cmbNomBanco2.Text = values[65];
            formClientes.cmbTipoCuenta2.Text = values[66];
            formClientes.txtNumeroCuenta2.Text = values[67];
            formClientes.txtCallePrincipal.Text = values[68];
            formClientes.txtNumeracion.Text = values[69];
            formClientes.txtCalleSecundaria.Text = values[70];
            formClientes.txtNombreEdificio.Text = values[71];
            formClientes.txtReferencia.Text = values[72];

            //Nuevos valores
            formClientes.txtSubtotalFAT.Text = values[73];
            formClientes.txtComisionFT.Text = values[74];
            formClientes.txtSubtotalTBCFA.Text = values[75];
            formClientes.txtSubtotalTBCFT.Text = values[76];
            formClientes.PC1Ext.Text = values[77];
            formClientes.PC2Ext.Text = values[78];
            formClientes.PC3Ext.Text = values[79];
            formClientes.PC4Ext.Text = values[80];
            formClientes.PC5Ext.Text = values[81];
            formClientes.txtCiudad.Text = values[82];
            formClientes.txtCodPostal.Text = values[83];
            formClientes.txtCallePrincipal2.Text = values[84];
            formClientes.txtNumeracion2.Text = values[85];
            formClientes.txtCiudad2.Text = values[86];
            formClientes.txtCalleSecundaria2.Text = values[87];
            formClientes.txtEdificio2.Text = values[88];
            formClientes.txtCodPostal2.Text = values[89];
            formClientes.txtReferencia2.Text = values[90];

            //Valores agregados 22/12/2020 para Exportaciones
            formClientes.txtRetRentFAA.Text = values[91];
            formClientes.txtRetIVAFAA.Text = values[92];
            formClientes.txtSubTFAM.Text = values[93];
            formClientes.txtSubTFAA.Text = values[94];
            formClientes.txtSubTFAT.Text = values[95];
            formClientes.txtRetRentaFALDM.Text = values[96];
            formClientes.txtRetIVAFALDM.Text = values[97];
            formClientes.txtRetRentaFAA.Text = values[98];
            formClientes.txtRetIVAFAAA.Text = values[99];
            formClientes.txtDiasCredFA.Text = values[100];
            formClientes.txtComiFAM.Text = values[101];
            formClientes.txtComiFAA.Text = values[102];
            formClientes.txtComiFAT.Text = values[103];
            formClientes.txtSubTFTBCM.Text = values[104];
            formClientes.txtSubTFTBCA.Text = values[105];
            formClientes.txtSubTFTBCT.Text = values[106];
            formClientes.txtRetRentaFTBCExp.Text = values[107];
            formClientes.txtRetIVAFTBCExp.Text = values[108];
            formClientes.txtDiasCredFTBCExp.Text = values[109];
            formClientes.cmbCOmisionesBancariasExp.Text = values[110];
            formClientes.txtPCExtraExp.Text = values[111];
            formClientes.txtValComExtraExp.Text = values[112];
            formClientes.txtDiasCreditoTExp.Text = values[113];
            formClientes.txtDiasCredGExp.Text = values[114];

            formClientes.txtRazonSocial.Text = values[115];

            //Agregar Cargo y extencion 
            formClientes.txtCargoPC.Text = values[116];
            formClientes.txtCargoPC2.Text = values[117];
            formClientes.txtCargoPC3.Text = values[118];
            formClientes.txtExtPC.Text = values[119];
            formClientes.txtExtPC2.Text = values[120];
            formClientes.txtExtPC3.Text = values[121];

            //Agregar provincia y barrio
            formClientes.txtBarrio1.Text = values[122];
            formClientes.txtProvincia1.Text = values[123];
            formClientes.txtBarrio2.Text = values[124];
            formClientes.txtProvincia2.Text = values[125];




            if (formClientes.txtPC2.Text != "" || formClientes.txtPCTelf2.Text != "") { formClientes.panelPC2.Visible = true; formClientes.contPC = 1; }
            if (formClientes.txtPC3.Text != "" || formClientes.txtPCTelf3.Text != "") { formClientes.panelPC3.Visible = true; formClientes.contPC = 2; }
            if (formClientes.txtPC4.Text != "" || formClientes.txtPCTelf4.Text != "") { formClientes.panelPC4.Visible = true; formClientes.contPC = 3; }
            if (formClientes.txtPC5.Text != "" || formClientes.txtPCTelf5.Text != "") { formClientes.panelPC5.Visible = true; formClientes.contPC = 4; }

            if (formClientes.txtPCob2.Text != "" || formClientes.txtPCobTel2.Text != "") { formClientes.panelPCob2.Visible = true; formClientes.contPCob = 1; }
            if (formClientes.txtPCob3.Text != "" || formClientes.txtPCobTel3.Text != "") { formClientes.panelPCob3.Visible = true; formClientes.contPCob = 2; }

            if(formClientes.txtCallePrincipal2.Text != "" || formClientes.txtNumeracion2.Text != "" || formClientes.txtReferencia2.Text != "") 
            { formClientes.panelDireccion2.Visible = true; formClientes.contDir = 1; }

            formClientes.panelBtn.Visible = false;
            formClientes.panelBtnPCob.Visible = false;
            formClientes.panelBtnNPC.Visible = false;
            formClientes.pnlBotonesDireccion.Visible = false; 

            formClientes.cmbComisionesBancarias.Enabled = false;
            formClientes.cmbNomBanco.Enabled = false;
            formClientes.cmbTipoCuenta.Enabled = false;
            formClientes.cmbNomBanco2.Enabled = false;
            formClientes.cmbTipoCuenta2.Enabled = false;

            formClientes.minimizar.Visible = true;
            formClientes.desplegar = true;

            formClientes.lblTitulo.Text = values[1];
            formClientes.Text = values[1];
            formClientes.Opacity = 0.9;
            formClientes.Height = Screen.PrimaryScreen.WorkingArea.Size.Height;
            formClientes.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;
            formPrincipal.panelMenuVertical.Visible = true;
            formPrincipal.panelGlobal.ColumnStyles[0].Width = 19;

            this.Close();
        }


        bool maximized = false;
        int valAnterior = 0;
        private void maximizar_Click(object sender, EventArgs e)
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

            maximized = !maximized;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            showClients();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void FormBuscarClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormPrincipal formPrincipal = Owner as FormPrincipal;
                if (formPrincipal != null)
                {
                    FormOpcionesClientes formOpcionesClientes = new FormOpcionesClientes();
                    formOpcionesClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formOpcionesClientes);
                    formPrincipal.AbrirFormInPanel(formOpcionesClientes);
                }
            }
        }

        private void FormBuscarClientes_Shown(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            InterfaceCache.idCliente = 2;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                searchData(txtBuscar.Text);

            }
        }

        private void FormBuscarClientes_Resize(object sender, EventArgs e)
        {
            acoplarPaneles();
        }

        string[] values = new string[127];
        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarDatos();
            
        }

        private void cargarDatos()
        {
            FormPrincipal formPrincipal = Owner as FormPrincipal;

            if (formPrincipal != null)
            {
                FormCrearCliente formClientes = new FormCrearCliente();

                int iTabla = dataGridClientes.CurrentCell.RowIndex;
                string RUC = dataGridClientes.Rows[iTabla].Cells[0].Value.ToString();

                for (int i = 0; i < clientes.Rows.Count; i++)
                {
                    if (clientes.Rows[i][0].ToString() == RUC)
                    {
                        iTabla = i;
                        break;
                    }
                }

                for (int i = 0; i < 127 - 1; i++)
                {
                    // values[i] = dataGridClientes.Rows[iTabla].Cells[i].Value.ToString();
                    values[i] = clientes.Rows[iTabla][i].ToString();
                }

                formClientes.txtRUC.Text = values[0];
                formClientes.txtEmpresa.Text = values[1];
                formClientes.txtPC.Text = values[2];
                formClientes.txtPCTelf.Text = values[3];
                formClientes.txtPCCell.Text = values[4];
                formClientes.txtPCEmail.Text = values[5];
                formClientes.txtTPC.Text = values[6];
                formClientes.txtPCCargo.Text = values[7];
                formClientes.txtPC2.Text = values[8];
                formClientes.txtPCTelf2.Text = values[9];
                formClientes.txtPCCell2.Text = values[10];
                formClientes.txtPCEmail2.Text = values[11];
                formClientes.txtTPC2.Text = values[12];
                formClientes.txtPCCargo2.Text = values[13];
                formClientes.txtPC3.Text = values[14];
                formClientes.txtPCTelf3.Text = values[15];
                formClientes.txtPCCell3.Text = values[16];
                formClientes.txtPCEmail3.Text = values[17];
                formClientes.txtTPC3.Text = values[18];
                formClientes.txtPCCargo3.Text = values[19];
                formClientes.txtPC4.Text = values[20];
                formClientes.txtPCTelf4.Text = values[21];
                formClientes.txtPCCell4.Text = values[22];
                formClientes.txtPCEmail4.Text = values[23];
                formClientes.txtTPC4.Text = values[24];
                formClientes.txtPCCargo4.Text = values[25];
                formClientes.txtPC5.Text = values[26];
                formClientes.txtPCTelf5.Text = values[27];
                formClientes.txtPCCell5.Text = values[28];
                formClientes.txtPCEmail5.Text = values[29];
                formClientes.txtTPC5.Text = values[30];
                formClientes.txtPCCargo5.Text = values[31];
                formClientes.txtPCob.Text = values[32];
                formClientes.txtPCobEmail.Text = values[33];
                formClientes.txtPCobTel.Text = values[34];
                formClientes.txtPCobCell.Text = values[35];
                formClientes.txtPCob2.Text = values[36];
                formClientes.txtPCobEmail2.Text = values[37];
                formClientes.txtPCobTel2.Text = values[38];
                formClientes.txtPCobCell2.Text = values[39];
                formClientes.txtPCob3.Text = values[40];
                formClientes.txtPCobEmail3.Text = values[41];
                formClientes.txtPCobTel3.Text = values[42];
                formClientes.txtPCobCell3.Text = values[43];
                formClientes.txtSubtotalFAM.Text = values[44];
                formClientes.txtSubtotalFAA.Text = values[45];
                formClientes.txtRetRentaFA.Text = values[46];
                formClientes.txtRetIVAFA.Text = values[47];
                formClientes.txtDiasCreditoFA.Text = values[48];
                formClientes.txtComisionFAM.Text = values[49];
                formClientes.txtComisionFAA.Text = values[50];
                formClientes.txtSubtotalFTBC.Text = values[51];
                formClientes.txtRetRentaFTBC.Text = values[52];
                formClientes.txtIVAFTBC.Text = values[53];
                formClientes.txtDiasCreditoFTBC.Text = values[54];
                formClientes.cmbComisionesBancarias.Text = values[55];
                formClientes.txtPersonasComisionesExtra.Text = values[56];
                formClientes.txtValorComisionesExtra.Text = values[57];
                formClientes.txtDiasCreditoTransporte.Text = values[58];
                formClientes.txtDiasCreditoGastos.Text = values[59];
                formClientes.txtBeneficiario.Text = values[60];
                formClientes.cmbNomBanco.Text = values[61];
                formClientes.cmbTipoCuenta.Text = values[62];
                formClientes.txtNumeroCuenta.Text = values[63];
                formClientes.txtBeneficiario2.Text = values[64];
                formClientes.cmbNomBanco2.Text = values[65];
                formClientes.cmbTipoCuenta2.Text = values[66];
                formClientes.txtNumeroCuenta2.Text = values[67];
                formClientes.txtCallePrincipal.Text = values[68];
                formClientes.txtNumeracion.Text = values[69];
                formClientes.txtCalleSecundaria.Text = values[70];
                formClientes.txtNombreEdificio.Text = values[71];
                formClientes.txtReferencia.Text = values[72];

                //Nuevos valores
                formClientes.txtSubtotalFAT.Text = values[73];
                formClientes.txtComisionFT.Text = values[74];
                formClientes.txtSubtotalTBCFA.Text = values[75];
                formClientes.txtSubtotalTBCFT.Text = values[76];
                formClientes.PC1Ext.Text = values[77];
                formClientes.PC2Ext.Text = values[78];
                formClientes.PC3Ext.Text = values[79];
                formClientes.PC4Ext.Text = values[80];
                formClientes.PC5Ext.Text = values[81];
                formClientes.txtCiudad.Text = values[82];
                formClientes.txtCodPostal.Text = values[83];
                formClientes.txtCallePrincipal2.Text = values[84];
                formClientes.txtNumeracion2.Text = values[85];
                formClientes.txtCiudad2.Text = values[86];
                formClientes.txtCalleSecundaria2.Text = values[87];
                formClientes.txtEdificio2.Text = values[88];
                formClientes.txtCodPostal2.Text = values[89];
                formClientes.txtReferencia2.Text = values[90];

                //Valores agregados 22/12/2020 para Exportaciones
                formClientes.txtRetRentFAA.Text = values[91];
                formClientes.txtRetIVAFAA.Text = values[92];
                formClientes.txtSubTFAM.Text = values[93];
                formClientes.txtSubTFAA.Text = values[94];
                formClientes.txtSubTFAT.Text = values[95];
                formClientes.txtRetRentaFALDM.Text = values[96];
                formClientes.txtRetIVAFALDM.Text = values[97];
                formClientes.txtRetRentaFAA.Text = values[98];
                formClientes.txtRetIVAFAAA.Text = values[99];
                formClientes.txtDiasCredFA.Text = values[100];
                formClientes.txtComiFAM.Text = values[101];
                formClientes.txtComiFAA.Text = values[102];
                formClientes.txtComiFAT.Text = values[103];
                formClientes.txtSubTFTBCM.Text = values[104];
                formClientes.txtSubTFTBCA.Text = values[105];
                formClientes.txtSubTFTBCT.Text = values[106];
                formClientes.txtRetRentaFTBCExp.Text = values[107];
                formClientes.txtRetIVAFTBCExp.Text = values[108];
                formClientes.txtDiasCredFTBCExp.Text = values[109];
                formClientes.cmbCOmisionesBancariasExp.Text = values[110];
                formClientes.txtPCExtraExp.Text = values[111];
                formClientes.txtValComExtraExp.Text = values[112];
                formClientes.txtDiasCreditoTExp.Text = values[113];
                formClientes.txtDiasCredGExp.Text = values[114];

                formClientes.txtRazonSocial.Text = values[115];

                //Agregar Cargo y extencion 
                formClientes.txtCargoPC.Text = values[116];
                formClientes.txtCargoPC2.Text = values[117];
                formClientes.txtCargoPC3.Text = values[118];
                formClientes.txtExtPC.Text = values[119];
                formClientes.txtExtPC2.Text = values[120];
                formClientes.txtExtPC3.Text = values[121];


                //Agregar provincia y barrio
                formClientes.txtBarrio1.Text = values[122];
                formClientes.txtProvincia1.Text = values[123];
                formClientes.txtBarrio2.Text = values[124];
                formClientes.txtProvincia2.Text = values[125];

                if (formClientes.txtPC2.Text != "" || formClientes.txtPCTelf2.Text != "") { formClientes.panelPC2.Visible = true; formClientes.contPC = 1; }
                if (formClientes.txtPC3.Text != "" || formClientes.txtPCTelf3.Text != "") { formClientes.panelPC3.Visible = true; formClientes.contPC = 2; }
                if (formClientes.txtPC4.Text != "" || formClientes.txtPCTelf4.Text != "") { formClientes.panelPC4.Visible = true; formClientes.contPC = 3; }
                if (formClientes.txtPC5.Text != "" || formClientes.txtPCTelf5.Text != "") { formClientes.panelPC5.Visible = true; formClientes.contPC = 4; }

                if (formClientes.txtPCob2.Text != "" || formClientes.txtPCobTel2.Text != "") { formClientes.panelPCob2.Visible = true; formClientes.contPCob = 1; }
                if (formClientes.txtPCob3.Text != "" || formClientes.txtPCobTel3.Text != "") { formClientes.panelPCob3.Visible = true; formClientes.contPCob = 2; }


                if (formClientes.txtCallePrincipal2.Text != "" || formClientes.txtNumeracion2.Text != "" || formClientes.txtReferencia2.Text != "")
                { formClientes.panelDireccion2.Visible = true; formClientes.contDir = 1; }

                formClientes.lblTitulo.Text = "EDITAR";
                formClientes.txtRUC.Enabled = false;
                formClientes.editar = true;


                if (formPrincipal != null)
                {
                    formClientes.FormClosed += new FormClosedEventHandler(formPrincipal.mostrarLogoAlCerrar);
                    formPrincipal.AddOwnedForm(formClientes);
                    formPrincipal.AbrirFormInPanel(formClientes);


                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
               DialogResult result =  MessageBox.Show(
                "Seguro desea eliminar el cliente: "+ nombre,
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );

            if(result == DialogResult.Yes)
            {
                UserModel model = new UserModel();
                if (model.InsertDataClient(deleteDataClient()))
                {
                    MessageBox.Show(
                    "El cliente: " + nombre +
                    "\nHa sido elimininado exitosamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    showClients();
                }
                else
                {
                    MessageBox.Show(
                    "No ha sido posible eliminar al cliente\n" +
                    "Por favor, inténtelo una vez más.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
        }

        string nombre;
        public string[] deleteDataClient()
        {
            int e = dataGridClientes.CurrentCell.RowIndex;

            values[1] = dataGridClientes.Rows[e].Cells[0].Value.ToString();
            nombre = dataGridClientes.Rows[e].Cells[1].Value.ToString();

            for (int i = 2; i < 127; i++)
            {
                values[i] = "0";
            }

            values[0] = "Delete";


            return values;
        }

        private void vScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            dataGridClientes.FirstDisplayedScrollingRowIndex = e.Value;
        }

        private void dataGridClientes_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar.Value = e.NewValue;
        }

        private void hScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            dataGridClientes.FirstDisplayedScrollingColumnIndex = e.Value;
        }

        private void acoplarScrolls()
        {

            if (dataGridClientes.RowCount > 0)
            {
                if (dataGridClientes.RowCount == 1)
                {
                    vScrollBar.Maximum = dataGridClientes.RowCount;
                }
                else
                {
                    vScrollBar.Maximum = dataGridClientes.RowCount - 1;
                }

            }
            else
            {

                vScrollBar.Minimum = 0;
                vScrollBar.Maximum = 1;
            }

            hScrollBar.Maximum = dataGridClientes.ColumnCount - 1;
        }

        ToolStripProfessionalRenderer r = new ToolStripProfessionalRenderer(new MyColorTable(Color.Red));
        ToolStripProfessionalRenderer normal = new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(185, 209, 234)));
        private void dataGridClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                ToolStripMenuItem mi;

                // Item 1, null in constructor to say : no picture on the label
                mi = new ToolStripMenuItem("Actualizar", null, (s, a) => Actualizar());
                mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                mi.ForeColor = Color.White;
                mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
                mi.MouseLeave += new EventHandler(menuItem_MouseLeave); 
                menu.Items.Add(mi);

                // Item 2

                mi = new ToolStripMenuItem("Desplegar", null, (s, a) => agregarCampos());
                mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                mi.ForeColor = Color.White;
                mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
                mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
                menu.Items.Add(mi);

                // Item 3
                if (UserCache.Position != Positions.Contabilidad2)
                {
                    mi = new ToolStripMenuItem("Editar", null, (s, a) => cargarDatos());
                    mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                    mi.ForeColor = Color.White;
                    mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
                    mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
                    menu.Items.Add(mi);

                    // Item 3
                    mi = new ToolStripMenuItem("Eliminar", null, (s, a) => Eliminar());
                    mi.BackColor = Color.FromArgb(200, 41, 46, 54);
                    mi.ForeColor = Color.White;
                    mi.MouseEnter += new EventHandler(menuItem_MouseEnter);
                    mi.MouseLeave += new EventHandler(menuItem_MouseLeave);
                    menu.Items.Add(mi);

                }


                menu.RenderMode = ToolStripRenderMode.ManagerRenderMode;
                
               // menu.MouseLeave +

                menu.BackColor = Color.FromArgb(100, 41, 46, 54);
                menu.Show(new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50));
            }
        }

        private void menuItem_MouseEnter(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (item.Text == "Eliminar")
            {
                ToolStripManager.Renderer = r;
            }
            else
            {
                ToolStripManager.Renderer = normal;
                item.ForeColor = Color.FromArgb(200, 41, 46, 54);
            }
        }

        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (item.Text == "Eliminar")
            {
                ToolStripManager.Renderer = r;
            }
            else
            {
                ToolStripManager.Renderer = normal;
                item.ForeColor = Color.White;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                showClients();
            }
        }
    }
}
