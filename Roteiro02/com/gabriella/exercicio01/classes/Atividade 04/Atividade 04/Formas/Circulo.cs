using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você  selecionou o CÍRCULO.");
            Form formularioCirculo = new FormularioCirculo();
            formularioCirculo.ShowDialog();
        }
    }
}
