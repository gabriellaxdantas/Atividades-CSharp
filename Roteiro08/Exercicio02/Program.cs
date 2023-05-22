using System;

namespace Roteiro8Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
         int [] vetorNums = new int [5];
         int somaP =0, somaN=0;
         for (int i =0; i<5; i++){
             Console.WriteLine("Informe um valor para a posição {0} do vetor:", i);
             vetorNums[i]=int.Parse(Console.ReadLine());
         }
        Console.WriteLine("Os números postivos são:");
         for (int i =0; i<5; i++){
              if (vetorNums[i]> 0){
                Console.WriteLine("número {0} na posição {1}", vetorNums[i], i);
                somaP +=vetorNums[i];
             }
         }
          Console.WriteLine("Soma dos positivos: {0}", somaP);
          
          Console.WriteLine("Os números negativos são:");
         for (int i=0; i<5; i++){
             if (vetorNums[i]<0){
                Console.WriteLine("número {0} na posição {1}", vetorNums[i], i);
                somaN +=vetorNums[i];
             }
         }
         Console.WriteLine("Soma dos negativos: {0}", somaN);



        }
    }
}
