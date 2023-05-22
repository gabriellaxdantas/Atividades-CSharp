using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_04.Formas
{
    public class Retangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public override void FormaClicada(string nomeForma)
        {
            MessageBox.Show("Você selecionou o RETÂNGULO.");
            Form formularioRetangulo = new FormularioRetangulo();
            formularioRetangulo.ShowDialog();
        }
    }
}
