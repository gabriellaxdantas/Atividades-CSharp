using System;

namespace Roteiro2Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
        double raio, comprimento, area, volume, pi=3.14159;
        Console.WriteLine("Informe o raio:");
        raio=double.Parse(Console.ReadLine());

         comprimento=((2*pi)*raio);

         area=(pi*(raio*raio));

         volume=(4/(3*pi*(Math.Pow(raio, 3))));
    }
}
}
