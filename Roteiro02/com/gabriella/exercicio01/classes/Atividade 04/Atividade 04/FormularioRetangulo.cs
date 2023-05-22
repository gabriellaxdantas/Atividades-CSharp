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
    public partial class FormularioRetangulo : Form
    {
        public FormularioRetangulo()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioRetangulo_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcular;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormularioRetangulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcular_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(baseRetangulo.Text, out double baseR))
            {
                double.TryParse(altRetangulo.Text, out double altR);
               

                double area = (baseR * altR);
                double perimetro = 2 * (baseR + altR);
                retanguloImg.Image = Properties.Resources.retangulo;
                areaTx.Text = "Área do retângulo: " + area;
                periTx.Text = "Perímetro do retângulo: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para o lado do retângulo.");
            }
        }

        private void FormularioRetangulo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void baseRetangulo_TextChanged(object sender, EventArgs e)
        {
            string input = baseRetangulo.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            baseRetangulo.Text = validInput.ToString();
            baseRetangulo.SelectionStart = baseRetangulo.Text.Length;
        }

        private void altRetangulo_TextChanged(object sender, EventArgs e)
        {
            string input = altRetangulo.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            altRetangulo.Text = validInput.ToString();
            altRetangulo.SelectionStart = altRetangulo.Text.Length;
        }
    }
}
