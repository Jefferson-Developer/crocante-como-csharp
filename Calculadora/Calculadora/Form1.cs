using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Res;
            Valor1 = double.Parse(Valor1Txt.Text);
            Valor2 = double.Parse(Valor2Txt.Text);
            Res = Valor1 + Valor2;
            ResultadoTxt.Text = Res.ToString();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Divisão_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Res;
            Valor1 = double.Parse(Valor1Txt.Text);
            Valor2 = double.Parse(Valor2Txt.Text);
            Res = Valor1 / Valor2;
            ResultadoTxt.Text = Res.ToString();
        }

        private void Multiplicação_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Res;
            Valor1 = double.Parse(Valor1Txt.Text);
            Valor2 = double.Parse(Valor2Txt.Text);
            Res = Valor1 * Valor2;
            ResultadoTxt.Text = Res.ToString();
        }

        private void Subtração_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Res;
            Valor1 = double.Parse(Valor1Txt.Text);
            Valor2 = double.Parse(Valor2Txt.Text);
            Res = Valor1 - Valor2;
            ResultadoTxt.Text = Res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
