using System;

namespace Roteiro2Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, subtracao;
            Console.WriteLine("Insira os valores em seguida:");
            num1=double.Parse(Console.ReadLine());
            num2=double.Parse(Console.ReadLine());

            subtracao=num1-num2;

            Console.WriteLine("A subtração de {0} por {1} é {2}", num1, num2, subtracao);
        }
    }
}
