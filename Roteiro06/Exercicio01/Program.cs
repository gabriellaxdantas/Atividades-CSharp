using System;

namespace Roteiro6Exercicio2
{
    class Program
    {
        static double somandoNums (double n1, double n2){
             double soma;
            soma =n1+n2;
            return soma;
        }
        static void Main(string[] args)
        {
            double n1, n2, res=0;
            Console.WriteLine("Informe dois números:");

            n1=double.Parse(Console.ReadLine());
            n2=double.Parse(Console.ReadLine());

            res=somandoNums(n1, n2);
            Console.WriteLine("Soma = " + res);
        }
    }
}
