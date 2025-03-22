using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btmostrar_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(txtmes.Text);

            if (mes == 1) lblresultado.Text = "Janeiro";
            else if (mes == 2) lblresultado.Text = "Fevereiro";
            else if (mes == 3) lblresultado.Text = "Março";
            else if (mes == 4) lblresultado.Text = "Abril";
            else if (mes == 5) lblresultado.Text = "Maio";
            else if (mes == 6) lblresultado.Text = "Junho";
            else if (mes == 7) lblresultado.Text = "Julho";
            else if (mes == 8) lblresultado.Text = "Agosto";
            else if (mes == 9) lblresultado.Text = "Setembro";
            else if (mes == 10) lblresultado.Text = "Outubro";
            else if (mes == 11) lblresultado.Text = "Novembro";
            else if (mes == 12) lblresultado.Text = "Dezembro";
            else lblresultado.Text = "Mês inválido";

            txtmes.Text = "";
        }

        private void Btmostrar2_Click(object sender, EventArgs e)
        {

            int mes = Convert.ToInt32(txtmes.Text);

            switch (mes) {
                case 1:
                   lblresultado.Text = "Janeiro";
                break;
                case 2:
                    lblresultado.Text = "Fevereiro";
                    break;
                case 3:
                    lblresultado.Text = "Março";
                    break;
                case 4:
                    lblresultado.Text = "Abril";
                    break;
                case 5:
                    lblresultado.Text = "Maio";
                    break;
                case 6:
                    lblresultado.Text = "Junho";
                    break;
                case 7:
                    lblresultado.Text = "Julho";
                    break;
                case 8:
                    lblresultado.Text = "Agosto";
                    break;
                case 9:
                    lblresultado.Text = "Setembro";
                    break;
                case 10:
                    lblresultado.Text = "Outubro";
                    break;
                case 11:
                    lblresultado.Text = "Novembro";
                    break;
                case 12:
                    lblresultado.Text = "Dezembro";
                    break;
                default:
                    lblresultado.Text = "Mês inválido";
                    break;

            }
            txtmes.Text = "";

        }
    }
}
