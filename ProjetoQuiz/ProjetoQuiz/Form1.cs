using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class Form1 : Form
    {

        string[,] Mat = new string[4, 6];
        int i, pontos;
        string correta, resposta;

        public Form1()
        {
            InitializeComponent();
        }

        private void resp2_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp2.Text;
        }

        private void resp3_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp3.Text;

        }

        private void resp4_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp4.Text;

        }

        private void resp1_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp1.Text;

        }

        private void btprox_Click(object sender, EventArgs e)
        {


            if (resposta == correta)
            {
                pontos = pontos + 1;
                lblpontos.Text = pontos.ToString();
            }

            i = i + 1;

            if (i <= 3) {
               preenche();
            }else{
                MessageBox.Show("Fim do teste", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i = 0;

                btiniciar.Visible = true;
                grupo.Visible = false;
            }

            
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            i = 0;
            grupo.Visible = true;
            preenche();
            pontos = 0;
            lblpontos.Text = pontos.ToString();
            btiniciar.Visible = false;
        }

        private void preenche() {
            lblpergunta.Text = Mat[i, 0];
            resp1.Text = Mat[i, 1];
            resp2.Text = Mat[i, 2];
            resp3.Text = Mat[i, 3];
            resp4.Text = Mat[i, 4];
            correta = Mat[i, 5];
            resposta = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grupo.Visible = false;

            Mat[0, 0] = "Qual a cor do céu?";
            Mat[0, 1] = "Amarelo";
            Mat[0, 2] = "Roxo";
            Mat[0, 3] = "Preto";
            Mat[0, 4] = "Azul";
            Mat[0, 5] = "Azul";

            Mat[1, 0] = "Qual o ano de descobrimiento do Brasil?";
            Mat[1, 1] = "1400";
            Mat[1, 2] = "1450";
            Mat[1, 3] = "1500";
            Mat[1, 4] = "1800";
            Mat[1, 5] = "1500";

            Mat[2, 0] = "Qual foi a primeira capital do Brasil?";
            Mat[2, 1] = "Rio de Janeiro";
            Mat[2, 2] = "Salvador";
            Mat[2, 3] = "Brasília";
            Mat[2, 4] = "São Vicente";
            Mat[2, 5] = "Salvador";

            Mat[3, 0] = "Qual o prof mais lindo da Fatec?";
            Mat[3, 1] = "Pavão";
            Mat[3, 2] = "Sebastião";
            Mat[3, 3] = "Osmil";
            Mat[3, 4] = "Adilson";
            Mat[3, 5] = "Pavão";

            i = 0;
            preenche();
        }
    }
}
