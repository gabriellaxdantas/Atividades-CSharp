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
    public partial class FormularioOctogono : Form
    {
        public FormularioOctogono()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioOctogono_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcular;
        }

        private void FormularioOctogono_Load(object sender, EventArgs e)
        {

        }
        private void FormularioOctogono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcular_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ladoOctogono.Text, out double lado))
            {
                

                double area = 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
                double perimetro = 8 * lado;
                octogonoImg.Image = Properties.Resources.octagono;
                areaTx.Text = "Área do octógono: " + area;
                periTx.Text = "Perímetro do octógono: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para o lado do octógono.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ladoOctogono_TextChanged(object sender, EventArgs e)
        {

            string input = ladoOctogono.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            ladoOctogono.Text = validInput.ToString();
            ladoOctogono.SelectionStart = ladoOctogono.Text.Length;
        }
    }
}
