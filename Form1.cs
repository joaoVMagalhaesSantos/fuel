using System.Security.Cryptography.Pkcs;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Fuel
{
    public partial class Form1 : Form
    {
        double valorPag = 0.00;
        double litroPag = 0.00;
        double valComb = 0.00;
        double litrosAbastecidos;
        double valorDesejado;
        string combSel = "";
        private System.Timers.Timer timer;
        

        public Form1(double valor, double litragem)
        {
            InitializeComponent();

            if (valor > 0 && litragem > 0)
            {
                valorPag = valor;
                litroPag = litragem;

                timer = new System.Timers.Timer();
                timer.Interval = 500;
                timer.Start();
            }
            else
            {
                txtValPag.Text = "0,00";
                txtLtAbast.Text = "0,00";
            }


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            valorDesejado += 0.01;
            litrosAbastecidos += 0.01;

            txtValPag.Text = valorDesejado.ToString("0.00");
            txtLtAbast.Text = litrosAbastecidos.ToString("0.00");

            if (valorDesejado >= valorPag && litrosAbastecidos >= litroPag)
            {
                timer.Stop();
                MessageBox.Show("Abastecimento concluído!");
            }
        }


        private void btnVpower_Click(object sender, EventArgs e)
        {
            combSel = "Shell V-Power: ";
            valComb = Convert.ToDouble(txtVpower.Text);

            string param = combSel + valComb;
            Controller control = new(param, valComb);
            control.ShowDialog();
        }

        private void btnComum_Click(object sender, EventArgs e)
        {
            combSel = "Gasolina Comum: ";
            valComb = Convert.ToDouble(txtComum.Text);

            string param = combSel + valComb;
            Controller control = new(param, valComb);
            control.Show();
        }

        private void btnEtanol_Click(object sender, EventArgs e)
        {
            combSel = "Etanol: ";
            valComb = Convert.ToDouble(txtEtanol.Text);

            string param = combSel + valComb;
            Controller control = new(param, valComb);
            control.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
