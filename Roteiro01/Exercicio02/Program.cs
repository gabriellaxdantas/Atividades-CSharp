using System;

namespace Roteiro1Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, X;
            Console.WriteLine("EXEMPLO 4 - Programa em C#");
            X=int.Parse(Console.ReadLine());
            a=X/1000;
            b = (X % 1000) / 100;
            c = ((X % 1000) % 100)/ 10;
            d = ((X % 1000) % 100) % 10;
            Console.WriteLine("{0}{1}{2}{3}",d, c, b, a);
            Console.WriteLine();
            
        }
    }
}
