using System;

namespace Roteiro2Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int angulo1, angulo2, angulo3, total=180;

            Console.WriteLine("Insira o valor do primeiro angulo:");
            angulo1=int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo angulo:");
            angulo2=int.Parse(Console.ReadLine());

            angulo3=(total-angulo1-angulo2);
            Console.WriteLine("O valor do terceiro angulo é: {0}", angulo3);
        }
    }
}
