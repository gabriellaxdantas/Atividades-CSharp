using System;

namespace Roteiro2Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int area, basemaior, basemenor, altura;

             Console.WriteLine("Insira o valor da base maior:");
            basemaior=int.Parse(Console.ReadLine());

             Console.WriteLine("Insira o valor da base menor:");
            basemenor=int.Parse(Console.ReadLine());

             Console.WriteLine("Insira o valor da altura:");
            altura=int.Parse(Console.ReadLine());

            area=(( basemaior - basemenor) * altura) / 2;
            Console.WriteLine("A area é {0}", area);

        }
    }
}
