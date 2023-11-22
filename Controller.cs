using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel
{
    public partial class Controller : Form
    {
        public Controller(string param, double valComb)
        {
            InitializeComponent();
            label3.Text = param;
            label4.Text = valComb.ToString();

            txtValSel.Text = "0,00";
            txtLitSel.Text = "0,00";
        }

        private void Controller_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valSel = Convert.ToDouble(txtValSel.Text);
            double litSel = Convert.ToDouble(txtLitSel.Text);
            double valPag, litPag;

            valPag = valSel;
            litPag = litSel;

            Form1 form = new Form1(valPag, litPag);
            this.Close();
        }

        private void txtValSel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separadorDecimal = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != separadorDecimal))
            {
                e.Handled = true;
            }

            if (e.KeyChar == separadorDecimal && (sender as TextBox).Text.Contains(separadorDecimal))
            {
                e.Handled = true; 
            }
        }

        private void txtValSel_Leave(object sender, EventArgs e)
        {
            double valorMinimo = 0.00;
            double valorAtual;

            if (double.TryParse(txtValSel.Text, out valorAtual))
            {
                if (valorAtual < valorMinimo)
                {
                    MessageBox.Show("O valor mínimo permitido é " + valorMinimo);
                    txtValSel.Text = valorMinimo.ToString("0.00");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
                txtValSel.Text = valorMinimo.ToString("0.00");
            }

            if(valorAtual > 0)
            {
                txtLitSel.Enabled = false;
                txtLitSel.Text = (valorAtual / Convert.ToDouble(label4.Text)).ToString("0.00");
            }
            else
            {
                txtLitSel.Enabled = true;
            }


        }

        private void txtLitSel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separadorDecimal = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != separadorDecimal))
            {
                e.Handled = true;
            }

            if (e.KeyChar == separadorDecimal && (sender as TextBox).Text.Contains(separadorDecimal))
            {
                e.Handled = true;
            }
        }

        private void txtLitSel_Leave(object sender, EventArgs e)
        {
            double valorMinimo = 0.00;
            double valorAtual;

            if (double.TryParse(txtLitSel.Text, out valorAtual))
            {
                if (valorAtual < valorMinimo)
                {
                    MessageBox.Show("O valor mínimo permitido é " + valorMinimo);
                    txtLitSel.Text = valorMinimo.ToString("0.00");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
                txtLitSel.Text = valorMinimo.ToString("0.00");
            }

            if(valorAtual > 0)
            {
                txtValSel.Enabled = false;
                txtValSel.Text = (valorAtual * Convert.ToDouble(label4.Text)).ToString("0.00");
            }
            else
            {
                txtValSel.Enabled = true;
            }
        }
    }
}
