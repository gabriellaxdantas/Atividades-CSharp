using System;

namespace Roteiro2Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            nota1=double.Parse(Console.ReadLine());
            nota2=double.Parse(Console.ReadLine());
            media=(nota1*2)+(nota2*3)/5;
            Console.WriteLine("A média é: {0}", media);
        }
    }
}
