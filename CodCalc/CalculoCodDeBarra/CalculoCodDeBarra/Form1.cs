using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoCodDeBarra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbldigito_Click(object sender, EventArgs e)
        {

        }

        private void Txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btcalc_Click(object sender, EventArgs e)
        {

            try
            {
                int somapar = 0, somaimpar = 0, total = 0, dezena = 0;
                int numero, digito, i;

                for (i = 0; i <= 11; i++)
                {
                    numero = Convert.ToInt16(txtcod.Text.Substring(i, 1));

                    if (i % 2 == 0)
                    {
                        somapar += numero;
                    }
                    else
                    {
                        somaimpar += numero;
                    }
                }
                total = somapar + somaimpar * 3;
                dezena = total / 10 * 10 + 10;
                digito = dezena - total;
                lbldigito.Text = digito.ToString();
            }
            catch (Exception erro) {
                MessageBox.Show("Código invalido, verifique o codigo " +erro.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
