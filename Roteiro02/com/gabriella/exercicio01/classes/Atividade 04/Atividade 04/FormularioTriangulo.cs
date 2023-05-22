using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04
{
    public partial class FormularioTriangulo : Form
    {
        public FormularioTriangulo()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioTriangulo_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcular;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void baseTriangulo_TextChanged(object sender, EventArgs e)
        {
            string input = baseTriangulo.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            baseTriangulo.Text = validInput.ToString();
            baseTriangulo.SelectionStart = baseTriangulo.Text.Length;
        }


        private void FormularioTriangulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcular_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(baseTriangulo.Text, out double baseT))
            {
                double.TryParse(alturaTriangulo.Text, out double altT);
                double.TryParse(ladoTriangulo.Text, out double ladoT);

                double area = (baseT * altT) / 2;
                double perimetro = ladoT * 3;
                trianguloImg.Image = Properties.Resources.triangulo;
                areaTxt.Text = "Área do triângulo: " + area;
                periTxt.Text = "Perímetro do triângulo: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para as propriedades do triângulo.");
            }
        }

        private void FormularioTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void areaTxt_Click(object sender, EventArgs e)
        {

        }

        private void periTxt_Click(object sender, EventArgs e)
        {

        }

        private void alturaTriangulo_TextChanged(object sender, EventArgs e)
        {
            string input = alturaTriangulo.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            alturaTriangulo.Text = validInput.ToString();
            alturaTriangulo.SelectionStart = alturaTriangulo.Text.Length;
        }

        private void ladoTriangulo_TextChanged(object sender, EventArgs e)
        {
            string input = ladoTriangulo.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            ladoTriangulo.Text = validInput.ToString();
            ladoTriangulo.SelectionStart = ladoTriangulo.Text.Length;

        }
    }
}
