using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btcores_Click(object sender, EventArgs e)
        {
            cores.ShowDialog();
            this.BackColor = cores.Color;
        }

        private void Btfonte_Click(object sender, EventArgs e)
        {
            fonte.ShowDialog();
        }

        private void Btsalvar_Click(object sender, EventArgs e)
        {
            salvar.ShowDialog();

        }

        private void Btabrir_Click(object sender, EventArgs e)
        {
            try { 
            abrir.ShowDialog();
            lbltexto.Text = abrir.FileName;
            figura.Load(abrir.FileName);

            }
            catch
            {
                MessageBox.Show("Escolha outro arquivo", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Fonte_Apply(object sender, EventArgs e)
        {
            fonte.ShowDialog();
            lbltexto.Font = fonte.Font;
            lbltexto.ForeColor = fonte.Color;
        }

        private void Btmais_Click(object sender, EventArgs e)
        {
            figura.Height = Convert.ToInt32(figura.Height * 1.25);
            figura.Width = Convert.ToInt32(figura.Width * 1.25);
        }

        private void Btmenos_Click(object sender, EventArgs e)
        {
            figura.Height = Convert.ToInt32(figura.Height / 1.25);
            figura.Width = Convert.ToInt32(figura.Width / 1.25);
        }
    }
}
