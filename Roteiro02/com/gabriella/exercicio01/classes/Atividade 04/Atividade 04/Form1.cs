using Atividade_04.Formas;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           


        }

        private void labelCirculo_Click(object sender, EventArgs e)
        {

        }

        private void labelTri_Click(object sender, EventArgs e)
        {

        }

        private void labelRet_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            Button btnCirculo = sender as Button;
            Circulo circulo = new Circulo();
            circulo.FormaClicada(btnCirculo.Name);
        }
        private void buttonQuadrado_Click(object sender, EventArgs e)
        {
            Button btnQuadrado = sender as Button;
            Quadrado quadrado = new Quadrado();
            quadrado.FormaClicada(btnQuadrado.Name);
        }

        private void buttonTriangulo_Click(object sender, EventArgs e)
        {
            Button btnTriangulo = sender as Button;
            Triangulo triangulo = new Triangulo();
            triangulo.FormaClicada(btnTriangulo.Name);
        }

        private void buttonRetangulo_Click(object sender, EventArgs e)
        {
            Button btnRetangulo = sender as Button;
            Retangulo retangulo = new Retangulo();
            retangulo.FormaClicada(btnRetangulo.Name);
        }

        private void buttonOctagono_Click(object sender, EventArgs e)
        {
            Button btnOctagono = sender as Button;
            Octagono octagono = new Octagono();
            octagono.FormaClicada(btnOctagono.Name);
        }

        private void buttonPentagono_Click(object sender, EventArgs e)
        {
            Button btnPentagono = sender as Button;
            Pentagono pentagono = new Pentagono();
            pentagono.FormaClicada(btnPentagono.Name);
        }

        private void buttonHexagono_Click(object sender, EventArgs e)
        {
            Button btnHexagono = sender as Button;
            Hexagono hexagono = new Hexagono();
            hexagono.FormaClicada(btnHexagono.Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPentagono_Click(object sender, EventArgs e)
        {

        }
    }
}
