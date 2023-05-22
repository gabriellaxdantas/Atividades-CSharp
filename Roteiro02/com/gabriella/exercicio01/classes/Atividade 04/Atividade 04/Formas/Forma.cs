using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_04.Formas
{
    public abstract class Forma
    {
       
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public virtual void FormaClicada (string nomeForma)
        {
            
        }
       

    }
}
