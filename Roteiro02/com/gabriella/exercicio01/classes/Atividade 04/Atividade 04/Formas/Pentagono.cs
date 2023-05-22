using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Pentagono : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea()
        {
            return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) / 4 * Math.Pow(Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 5 * Lado;
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você selecionou o PENTÁGONO.");
            Form formularioPentagono = new FormularioPentagono();
            formularioPentagono.ShowDialog();
        }
    }
}
