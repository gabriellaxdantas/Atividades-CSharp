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
    public partial class FormularioHexagono : Form
    {
        public FormularioHexagono()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioHexagono_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcula;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ladoHex_TextChanged(object sender, EventArgs e)
        {

            string input = ladoHex.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            ladoHex.Text = validInput.ToString();
            ladoHex.SelectionStart = ladoHex.Text.Length;
           
           
        }
        private void FormularioHexagono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcula_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcula_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(ladoHex.Text, out double lado))
            {

                double area = (3 * Math.Sqrt(3) * Math.Pow(lado, 2)) / 2;
                double perimetro = 6 * lado;
                hexagonoImg.Image = Properties.Resources.hexagono;
                areaTx.Text = "Área do hexagono: " + area;
                periTx.Text = "Perímetro do hexagono: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para o lado do hexagono.");
            }
        }
    }
}
