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
    public partial class FormularioCirculo : Form
    {
        public FormularioCirculo()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioCirculo_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcula;
        }

        private void FormularioCirculo_Load(object sender, EventArgs e)
        {

        }


        private void raioCirculo_TextChanged(object sender, EventArgs e)
        {

            string input = raioCirculo.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            raioCirculo.Text = validInput.ToString();
            raioCirculo.SelectionStart = raioCirculo.Text.Length;


           
            
        }

        private void FormularioCirculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcula_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (double.TryParse(raioCirculo.Text, out double raio))
            {

                double area = Math.PI * raio * raio;
                double perimetro = 2 * Math.PI * raio;
                circuloImg.Image = Properties.Resources.circulo;
                areaTx.Text = "Área do círculo: " + area;
                periTx.Text = "Perímetro do círculo: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para o raio do círulo.");
            }
        }
    }
}
