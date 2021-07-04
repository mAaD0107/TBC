using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.txtpantalla.Focus();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.txtpantalla.Focus();
        }
        Decimal a=0;
        Decimal b=0;      
        string c;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        public void btndivision_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(this.txtpantalla.Text);
            c = "/";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        public void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(this.txtpantalla.Text);
            c = "*";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        public void btnresta_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(this.txtpantalla.Text);
            c = "-";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        public void btnsuma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(this.txtpantalla.Text);
            c = "+";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (this.txtpantalla.Text.Contains(',') == false)
            {
                this.txtpantalla.Text = this.txtpantalla.Text + ",";
            }


        }
        private void btnAtras(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
            {
                this.txtpantalla.Text = this.txtpantalla.Text.Remove(this.txtpantalla.Text.Length - 1);
            }
                        

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                b = Convert.ToDecimal(this.txtpantalla.Text);
                switch (c)
                {
                    case "+":
                        this.txtpantalla.Text = Convert.ToString(Math.Round((a + b), 2, MidpointRounding.AwayFromZero));
                        break;

                    case "-":
                        this.txtpantalla.Text = Convert.ToString(Math.Round((a - b), 2, MidpointRounding.AwayFromZero));
                        break;

                    case "*":
                        this.txtpantalla.Text = Convert.ToString(Math.Round((a * b), 2, MidpointRounding.AwayFromZero));
                        break;

                    case "/":
                        this.txtpantalla.Text = Convert.ToString(Math.Round((a / b), 2, MidpointRounding.AwayFromZero));
                        break;
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            this.txtpantalla.Text = "";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            FormInfoFacturasCarta formInfo = Owner as FormInfoFacturasCarta;
            formInfo.ACalcu = false;
            this.Close();
        }

        public void buttonSet_Click(object sender, EventArgs e)
        {
            
            FormInfoFacturasCarta formInfo = Owner as FormInfoFacturasCarta;
            formInfo.txtMayorContable.Text = this.txtpantalla.Text;
        }

        private void comprobarNumero(object sender, KeyPressEventArgs e)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-EC");

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        public void buttonReset_Click(object sender, EventArgs e)
        {

            FormInfoFacturasCarta formInfo = Owner as FormInfoFacturasCarta;
            formInfo.txtMayorContable.Text = "";
        }

     

        private void txtpantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '*' || e.KeyChar != '+' || e.KeyChar != '-' || e.KeyChar != '/' || e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                comprobarNumero(sender, e);
            }           
            if (e.KeyChar == '*') { 
                    btnmultiplicacion_Click(sender, e); 
                }
            if (e.KeyChar == '+') { 
                    btnsuma_Click(sender, e); 
                }
            if (e.KeyChar == '-') { 
                btnresta_Click(sender, e); 
                }
                if (e.KeyChar == '/') { btndivision_Click(sender, e); }
                if (e.KeyChar == Convert.ToChar(Keys.Enter) ) { btnigual_Click(sender, e);}
        }

    }
}
