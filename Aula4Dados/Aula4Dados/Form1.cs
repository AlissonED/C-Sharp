using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btjogar_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();
            int d1, d2;
            d1 = sorteio.Next(1, 7);
            d2 = sorteio.Next(1, 7);

            lbl1.Text = Convert.ToString(d1);
            lbl2.Text = d2.ToString();

            /* caminho de imagem local :
            pic1.Load("C:\\Users\\labs\\Documents\\dados\\" + d1 + ".png");
            pic2.Load(@"C:\Users\labs\Documents\dados\" + d2 + ".png");*/

            pic1.Load(Application.StartupPath +"\\dados\\" + d1 + ".png");
            pic2.Load(Application.StartupPath + @"\dados\" + d2 + ".png");

            if (d1==d2) {
                lblresultado.Text = "Ganhou";
                lblresultado.ForeColor = Color.Green;
            } else {
                lblresultado.Text = "Perdeu";
                lblresultado.ForeColor = Color.Red;
            }
        }

        private void Lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
