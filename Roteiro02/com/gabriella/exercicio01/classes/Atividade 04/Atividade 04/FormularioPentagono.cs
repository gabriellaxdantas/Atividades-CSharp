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
    public partial class FormularioPentagono : Form
    {
        public FormularioPentagono()
        {
            InitializeComponent();
            this.KeyPreview = true; // Habilita o formulário a receber eventos de teclado
            this.KeyDown += FormularioPentagono_KeyDown; // Adiciona o evento KeyDown ao formulário
            this.AcceptButton = btnCalcular;

        }

        private void FormularioPentagono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é a tecla Enter
            {
                btnCalcular_Click(sender, e); // Chama o método btnCalcular_Click
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ladoPentagono.Text, out double lado))
            {


                double area = (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) / 4 * Math.Pow(lado, 2);
                double perimetro = 5 * lado;
                pentagonoImg.Image = Properties.Resources.pentagono;
                areaTx.Text = "Área do pentágono: " + area;
                periTx.Text = "Perímetro do pentágono: " + perimetro;
            }
            else
            {
                // O valor digitado não é um número válido
                MessageBox.Show("Digite um número válido para o lado do pentágono.");
            }
        }


        private void FormularioPentagono_Load(object sender, EventArgs e)
        {

        }

        private void ladoPentagono_TextChanged(object sender, EventArgs e)
        {
            string input = ladoPentagono.Text;
            StringBuilder validInput = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    validInput.Append(c);
                }
            }
            ladoPentagono.Text = validInput.ToString();
            ladoPentagono.SelectionStart = ladoPentagono.Text.Length;
        }
    }
}
