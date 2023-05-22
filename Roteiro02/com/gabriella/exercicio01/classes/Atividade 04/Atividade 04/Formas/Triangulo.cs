using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Base;
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você selecionou o TRIÂNGULO.");
            Form formularioTriangulo = new FormularioTriangulo();
            formularioTriangulo.ShowDialog();
        }
    }
}
