using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpar();
        }

        public void limpar() {
            txtdensidade.Text = "0";

            txtdiametro.Text = "0";

            txtreynolds.Text = "0";

            txtvel.Text = "0";

            txtviscosidade.Text = "0";
        }

        private void Btcalc_Click(object sender, EventArgs e)
        {
            double vel, den, diam, visco, N;
            vel = Convert.ToDouble(txtvel.Text);
            den = Convert.ToDouble(txtdensidade.Text);
            diam = Convert.ToDouble(txtdiametro.Text);
            visco = Convert.ToDouble(txtviscosidade.Text);

            N = (vel * den * diam) / visco;

            txtreynolds.Text = Convert.ToString(N);

            if (N >= 2000) lblresultado.Text = "Turbulento";
            else lblresultado.Text = "Laminado";


        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
