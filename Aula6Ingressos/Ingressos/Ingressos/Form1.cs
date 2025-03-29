using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingressos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtdesconto.Text = "0";
            txtvalor.Text = "0";
        }

        private void calculo()
        {
            double valor, desconto, total;
            if (rdbfem.Checked == true && rdbsolteiro.Checked == true) txtdesconto.Text = "15";
            else if (rdbfem.Checked && rdbcasado.Checked) txtdesconto.Text = "10";
            else if (rdbmasc.Checked && rdbsolteiro.Checked) txtdesconto.Text = "5";
            else if (rdbmasc.Checked && rdbcasado.Checked) txtdesconto.Text = "3";

            valor = Convert.ToDouble(txtvalor.Text);
            desconto = Convert.ToDouble(txtdesconto.Text);
            total = valor * (1 - desconto / 100);
            lbltotal.Text = "Total: " + total.ToString();
        }

        private void Btcalc_Click(object sender, EventArgs e)
        {
            calculo();

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void Rdbcasado_CheckedChanged(object sender, EventArgs e)
        {
            calculo();

        }

        private void Rdbsolteiro_CheckedChanged(object sender, EventArgs e)
        {
            calculo();

        }

        private void Rdbfem_CheckedChanged(object sender, EventArgs e)
        {
            calculo();

        }

        private void Rdbmasc_CheckedChanged(object sender, EventArgs e)
        {
            calculo();

        }
    }
}
