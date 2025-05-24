using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaClasse
{
    public partial class Form1 : Form
    {

        Matematica mat = new Matematica();


        public Form1()
        {
            InitializeComponent();
        }

        private void btquadrado_Click(object sender, EventArgs e)
        {
            label1.Text = mat.AQuad(5).ToString();
        }

        private void btcilindro_Click(object sender, EventArgs e)
        { 
            label1.Text = mat.VCilindro(5,20).ToString();
        }

        private void btret_Click(object sender, EventArgs e)
        {
            Matematica mat = new Matematica();
            label1.Text = mat.ARet(5, 10).ToString();
        }

        private void bttriangulo_Click(object sender, EventArgs e)
        {
            Matematica mat = new Matematica();
            label1.Text = mat.ATriangulo(12, 10).ToString();
        }

        private void btcasa_Click(object sender, EventArgs e)
        {
            label1.Text = mat.ACasa(10, 5,14,5).ToString();
        }

        private void btfatorial_Click(object sender, EventArgs e)
        {

        }
    }
}
