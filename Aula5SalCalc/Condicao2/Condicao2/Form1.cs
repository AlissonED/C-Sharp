using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcalc_Click(object sender, EventArgs e)
        {
            double salhora, horastrab, salbruto, salliq, inss;

            inss = 0;

            salhora = Convert.ToDouble(txtsalhora.Text);
            horastrab = Convert.ToDouble(txthorastrab.Text);

            salbruto = salhora * horastrab;
            txtsalbruto.Text = Convert.ToString(salbruto);

            if (salbruto>0 && salbruto <= 1500) inss = salbruto * 0.075;
            else if (salbruto <= 2800) inss = salbruto * 0.09;
            else if (salbruto <= 4200) inss = salbruto * 0.12;
            else if (salbruto <= 8200) inss = salbruto * 0.14;
            else inss = 8200 * 0.14;

            txtinss.Text = inss.ToString();

            salliq = salbruto - inss;
            txtsalliq.Text = Convert.ToString(salliq);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtsalhora.Text = "";
            txthorastrab.Text = "";
            txtsalbruto.Text = "";
            txtinss.Text = "";
            txtsalliq.Clear();
        }
    }
}
