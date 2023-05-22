using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Hexagono : Forma
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return 3 * Math.Sqrt(3) / 2 * Math.Pow(Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 6 * Lado;
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você selecionou o HEXÁGONO.");
            Form formularioHexagono = new FormularioHexagono();
            formularioHexagono.ShowDialog();
        }
    }
}
