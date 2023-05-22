using System;

namespace Roteiro5Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1, soma=0, qtde=0;
            
            while(num!=30000){
                num=int.Parse(Console.ReadLine());
                if(num!=30000){
                soma+=num;
                qtde++;
                }
            }
            Console.WriteLine("A soma é: {0} e a quantidade de números digitados é {1}", soma, qtde);
        }
    }
}
