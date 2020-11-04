using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentacion
{
    public partial class FormNuevoIVA : Form
    {
        public FormNuevoIVA()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtIVA_Enter(object sender, EventArgs e)
        {
            if (txtIVA.Text == "0.00")
            {
                txtIVA.Text = "";
                txtIVA.ForeColor = Color.White;
            }

            lblError.Visible = false; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ingresarIVA();
        }

        private bool validarIVA()
        {
            string IVA = txtIVA.Text;
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

            if (regex.IsMatch(IVA))
            {
                return true; 
            }
            else
            {
                return false;
                
            } 
        }


        private bool searchIVA()
        {
            string IVA = txtIVA.Text;

            UserModel model = new UserModel();

            if (model.searchIVA(IVA))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarDecimal(sender, e);

            if ((int)e.KeyChar == (int) Keys.Enter)
            {
                ingresarIVA();
            }
        }

        private void ingresarIVA()
        {
            if (validarIVA())
            {
                if (!searchIVA())
                {
                    UserModel userModel = new UserModel();

                    if (!userModel.insertIVA(txtIVA.Text))
                    {
                        FormCrearFactura formCrearFactura = Owner as FormCrearFactura;
                        formCrearFactura.btnIVA.Enabled = true;
                        EmpresaCache.ivaFactura = txtIVA.Text; 
                        this.Close();
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "No se ha podido guardar el valor";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "El valor ingresado ya se encuentra registrado";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "El valor ingresado es incorrecto";
            }
        }

        private void comprobarDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
