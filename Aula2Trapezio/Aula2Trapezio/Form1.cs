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
            double bmaior, bmenor,alt, area;

            bmaior = Convert.ToDouble(txtbasemaior.Text);
            bmenor = Convert.ToDouble(txtbasemenor.Text);
            alt = Convert.ToDouble(txtaltura.Text);

            area = (bmaior + bmenor)/2 * alt;

            txtarea.Text = Convert.ToString(area);
        }
    }
}
