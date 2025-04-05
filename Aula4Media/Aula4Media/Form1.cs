using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btcalc_Click(object sender, EventArgs e)
        {
            double p1, p2, t, m;

            p1 = Convert.ToDouble(txtp1.Text);
            p2 = Convert.ToDouble(txtp2.Text);
            t = Convert.ToDouble(txttrabalho.Text);

            m = (p1 * 0.35) + (p2 * 0.35) + (t * 0.3);

            lblresultado.Text = Convert.ToString("A Média é de :" + m);

            txtmedia.Text = Convert.ToString(m);


            if (m >= 6) lblaprovado.Text = "Aprovado";
            else lblaprovado.Text = "Reprovado";


        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            txtp1.Text = "";
            txtp2.Text = "";
            txttrabalho.Clear();
            txtmedia.Clear();
            txtp1.Focus();
        }

        private void Txttrabalho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
