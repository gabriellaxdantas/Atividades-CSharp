using System;

namespace Roteiro3Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            num=double.Parse(Console.ReadLine());
            if(num>0){
                Console.WriteLine("O número é positivo");
            }
            else if(num<0){
                Console.WriteLine("O número é negativo");
            }
            else{
                Console.WriteLine("O número é nulo");
            }
        }
    }
}
