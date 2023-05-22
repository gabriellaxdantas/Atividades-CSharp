using System;

namespace Roteiro5Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           double salario=0, novosalario;
           
           while(salario!=-1){
                salario=double.Parse(Console.ReadLine());
               novosalario=salario*1.25;
               Console.WriteLine("Seu novo salário é: {0}", novosalario);
           }
        }
    }
}
