using System;

namespace Roteiro3Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            num1=double.Parse(Console.ReadLine());
            num2=double.Parse(Console.ReadLine());
            if(num1>num2){
                Console.WriteLine("O {0} é maior", num1);
            }
            else{
                Console.WriteLine("O {0} é maior", num2);
            }
        }
    }
}
