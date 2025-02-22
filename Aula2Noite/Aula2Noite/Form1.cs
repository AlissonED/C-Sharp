using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2Noite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2, soma;

            valor1 = Convert.ToDouble(txtv1.Text);
            valor2 = Convert.ToDouble(txtv2.Text);

            soma = valor1 + valor2;

            txtsoma.Text = Convert.ToString(soma);

        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtv1.Text = "";
            txtv2.Text = "";
            txtsoma.Clear();
        }
    }
}
