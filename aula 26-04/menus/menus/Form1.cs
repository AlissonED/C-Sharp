using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AmareloToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label1.BackColor = Color.Yellow;
        }

        private void RosaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label1.BackColor = Color.Pink;
        }

        private void VerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label1.BackColor = Color.Green;
        }

        private void PretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void BrancoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label1.ForeColor = Color.White;
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCategorias cat = new CadCategorias();
            cat.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadProduto cat = new CadProduto();
            cat.Show();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadFornecedor cat = new CadFornecedor();
            cat.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Verde_ValueChanged(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(Convert.ToInt16(alpha.Value),Convert.ToInt16(azul.Value), Convert.ToInt16(verde.Value), Convert.ToInt16(vermelho.Value));
        }

        private void Vermelho_ValueChanged(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(Convert.ToInt16(alpha.Value), Convert.ToInt16(azul.Value), Convert.ToInt16(verde.Value), Convert.ToInt16(vermelho.Value));

        }

        private void Azul_ValueChanged(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(Convert.ToInt16(alpha.Value), Convert.ToInt16(azul.Value), Convert.ToInt16(verde.Value), Convert.ToInt16(vermelho.Value));

        }

        private void Alpha_ValueChanged(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(Convert.ToInt16(alpha.Value), Convert.ToInt16(azul.Value), Convert.ToInt16(verde.Value), Convert.ToInt16(vermelho.Value));

        }

        private void OutrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupo.Visible = true;
        }

        private void Btok_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(Convert.ToInt16(alpha.Value), Convert.ToInt16(azul.Value), Convert.ToInt16(verde.Value), Convert.ToInt16(vermelho.Value));
            grupo.Visible = false;

        }
    }
}
