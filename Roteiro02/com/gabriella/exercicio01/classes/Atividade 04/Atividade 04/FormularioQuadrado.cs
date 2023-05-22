using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04
{
    public partial class FormularioQuadrado : Form
    {
        public FormularioQuadrado()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioQuadrado_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcular;

        }

        private void FormularioQuadrado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = ladoQuadrado.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            ladoQuadrado.Text = validInput.ToString();
            ladoQuadrado.SelectionStart = ladoQuadrado.Text.Length;
        }


        private void FormularioQuadrado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcular_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ladoQuadrado.Text, out double lado))
            {
                // O valor foi convertido com sucesso
                // Calcula a área do quadrado
                double area = lado * lado;
                double perimetro = lado + lado + lado + lado;
                quadradoImg.Image = Properties.Resources.quadrado;
                areaTx.Text = "Área do quadrado: " + area;
                periTx.Text = "Perímetro do quadrado: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para o lado do quadrado.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
