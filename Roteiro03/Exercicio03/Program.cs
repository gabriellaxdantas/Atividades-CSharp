using System;

namespace Roteiro3Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num=int.Parse(Console.ReadLine());
            if(num % 2 ==0){
                Console.WriteLine("O número é par");
            }
            else{
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}
