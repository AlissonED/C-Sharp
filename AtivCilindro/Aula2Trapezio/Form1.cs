using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2Trapezio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcalc_Click(object sender, EventArgs e)
        {
            double raio, volume, altura;

            raio = Convert.ToDouble(txtraio.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            volume = 3.14 * (raio * raio) * altura;

            lblvolume.Text = Convert.ToString("O volume co cilindro é de: "+volume);
        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtraio.Clear();
            txtraio.Focus();
            lblvolume.Text = "";
        }

        private void Lblbasemaior_Click(object sender, EventArgs e)
        {

        }


    }
}
