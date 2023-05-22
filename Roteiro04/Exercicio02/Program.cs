using System;

namespace Roteiro4Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char escolha;

            Console.WriteLine("Informe dois valores a seguir:");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação a ser feita: [a] para soma, [b] para subtração, [c] para multiplicação, [d] para divisão.");
            escolha=char.Parse(Console.ReadLine());
            switch(escolha){
                case 'a':
                Console.WriteLine(num1+num2);
                break;
                case 'b':
                Console.WriteLine(num1-num2);
                break;
                case 'c':
                Console.WriteLine(num1*num2);
                break;
                case 'd':
                Console.WriteLine(num1/num2);
                break;

            }
            
        }
    }
}
