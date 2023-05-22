using System;

namespace Roteiro7Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] conjuntoA = new int [10];
           int [] conjuntoB = new int [11];
           int soma=0;

            for (int i=0; i<10; i++){
                Console.WriteLine("Informe um valor para a posição {0} do vetor A:", i);
                conjuntoA[i]=int.Parse(Console.ReadLine());
            }
            for (int j=0, i=0; j<11; j++, i++){
                 Console.WriteLine("Informe um valor para a posição {0} do vetor B:", j);
                 conjuntoB[j]=int.Parse(Console.ReadLine());
            }
            for(int i = 0, j= 1; j<11; j++, i++){
                if (i%2==0){
                soma = conjuntoA[i] + conjuntoB[j];
                Console.WriteLine("A soma de {0} posição {1} do vetor A + {2} posição {3} do vetor B é: {4}", conjuntoA[i], i, conjuntoB[j], j, soma);
                }
            }
  


        }
    }
}
