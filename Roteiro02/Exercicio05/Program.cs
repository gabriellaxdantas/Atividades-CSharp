using System;

namespace Roteiro2Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
         double salariomin, salariofunc, qtdsalarios;

         Console.WriteLine("Informe o valor do salario minimo:");
         salariomin=double.Parse(Console.ReadLine());

          Console.WriteLine("Informe o valor do salario do funcionario:");
         salariofunc=double.Parse(Console.ReadLine());

         qtdsalarios=salariofunc/salariomin;
         Console.WriteLine("O funcionario recebe {0} salarios minimos", qtdsalarios);

        }
    }
}
