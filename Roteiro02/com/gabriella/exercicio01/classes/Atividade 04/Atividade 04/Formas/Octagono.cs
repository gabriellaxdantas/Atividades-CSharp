using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Octagono : Forma
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 8 * Lado;
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você selecionou o OCTÓGONO.");
            Form formularioOctogono = new FormularioOctogono();
            formularioOctogono.ShowDialog();
        }
    }
}
