using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Quadrado : Forma
    {


        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você selecionou o QUADRADO.");
            Console.WriteLine(nomeForma);

            
            Form formularioQuadrado = new FormularioQuadrado();
            formularioQuadrado.ShowDialog();

          

        }
    }
}