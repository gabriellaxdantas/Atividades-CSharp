using System;

namespace Roteiro7Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numsA = new int [10];
            int [] numsB = new int [10];
            int soma=0;
            for (int i=0; i<10; i++){
                Console.WriteLine("Informe o valor da posição {0} do primeiro vetor:", i);
                numsA[i]=int.Parse(Console.ReadLine());
            }
             for (int i=0; i<10; i++){
                 Console.WriteLine("Informe o valor da posição {0} do segundo vetor:", i);
                numsB[i]=int.Parse(Console.ReadLine());
            }
             for (int i=0; i<10; i++){
                soma=numsA[i]+numsB[i];
                Console.WriteLine("A soma da posição {0} dos vetores 1 e 2 é:", i);
                Console.WriteLine(soma);
            }
        }
    }
}
