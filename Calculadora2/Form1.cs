using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        double a, b;
        string c;

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "2";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "2";
            }
            btnIgual.Focus();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "3";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "3";
            }
            btnIgual.Focus();
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "4";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "4";
            }
            btnIgual.Focus();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "5";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "5";
            }
            btnIgual.Focus();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "6";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "6";
            }
            btnIgual.Focus();
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "7";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "7";
            }
            btnIgual.Focus();
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "8";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "8";
            }
            btnIgual.Focus();
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "9";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "9";
            }
            btnIgual.Focus();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text == "")
            {
                txbResultado.Text = "0";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "0";
            }
            btnIgual.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //txbResultado.Text = "";
            txbResultado.Text = string.Empty;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txbResultado.Text);
            c = "+";
            txbResultado.Clear();
            btnIgual.Focus();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txbResultado.Text);
            c = "-";
            txbResultado.Clear();
            btnIgual.Focus();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txbResultado.Text);
            c = "*";
            txbResultado.Clear();
            btnIgual.Focus();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txbResultado.Text);
            c = "/";
            txbResultado.Clear();
            btnIgual.Focus();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(txbResultado.Text.Contains(",") == false)
            {
                txbResultado.Text = txbResultado.Text + ",";
            }
            btnIgual.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(txbResultado.Text != string.Empty)
            {
                b = Convert.ToDouble(txbResultado.Text);
                switch (c)
                {
                    case "+":
                        txbResultado.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        txbResultado.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        txbResultado.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        txbResultado.Text = Convert.ToString(a / b);
                        break;
                }
            }
        }

        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnUm.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnDois.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnTres.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btnQuatro.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btnCinco.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btnSeis.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btnSete.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btnOito.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btnNove.PerformClick();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btnZero.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnLimpar.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                btnSomar.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnSubtrair.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiplicar.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnDividir.PerformClick();
            }
            if (e.KeyValue == 188)
            {
                btnVirgula.PerformClick();
            }
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if(txbResultado.Text == "")
            {
                txbResultado.Text = "1";
            }
            else
            {
                txbResultado.Text = txbResultado.Text + "1";
            }
            btnIgual.Focus();
        }
    }
}
