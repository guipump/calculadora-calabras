using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCalabresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Operacao
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma,

        }

        Operacao ultimaOperacao = Operacao.Nenhuma;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxdisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text =
                textBoxDisplay.Text.Remove (textBoxDisplay.Text.Length - 1,1);
            }
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void subtraçao_Click(object sender, EventArgs e)
        {
            {
                if (ultimaOperacao == Operacao.Nenhuma)
                {
                    ultimaOperacao = Operacao.Subtrai;
                }
                else
                {
                    fazerCalculo(ultimaOperacao);
                }
            }

        }

        private void divisao_Click(object sender, EventArgs e)
        {
            {
                if (ultimaOperacao == Operacao.Nenhuma)
                {
                    ultimaOperacao = Operacao.Divide;
                }
                else
                {
                    fazerCalculo(ultimaOperacao);
                }
                textBoxDisplay.Text += (sender as Button).Text;
            }


        }

        private void multiplicaçao_Click(object sender, EventArgs e)
        {
            {
                if (ultimaOperacao == Operacao.Nenhuma)
                {
                    ultimaOperacao = Operacao.Multiplica;
                }
                else
                {
                    fazerCalculo(ultimaOperacao);
                }
                textBoxDisplay.Text += (sender as Button).Text;
            }


        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacao.Nenhuma)
            {
                fazerCalculo(ultimaOperacao);
            }
                ultimaOperacao= Operacao.Nenhuma;
        }

        private void virgula_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "0";
        }

        private void ponto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            {
                if (ultimaOperacao == Operacao.Nenhuma)
                {
                    ultimaOperacao = Operacao.Soma;
                }
                else
                {
                    fazerCalculo(ultimaOperacao);
                }
                textBoxDisplay.Text += (sender as Button).Text;
            }

            
        }
        private void fazerCalculo(Operacao ultimaOperacao)
        {
            List<double> listadenumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case Operacao.Soma:
                    listadenumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = listadenumeros[0] + listadenumeros[1].ToString();
                    break;
                case Operacao.Subtrai:
                    listadenumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = listadenumeros[0] + listadenumeros[1].ToString();
                    break;
                case Operacao.Divide:
                    listadenumeros = textBoxDisplay.Text.Split('%').Select(double.Parse).ToList();
                    textBoxDisplay.Text = listadenumeros[0] + listadenumeros[1].ToString();
                    break;
                case Operacao.Multiplica:
                    listadenumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = listadenumeros[0] + listadenumeros[1].ToString();
                    break;
                case Operacao.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }
    }
}
