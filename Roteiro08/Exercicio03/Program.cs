using System;

namespace Roteiro8Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
         int [] vetorA = new int [10];
         int [] vetorB = new int [10];
         int [] vetorC = new int [20];

         for (int i =0; i<10; i++){
             Console.WriteLine("Informe um valor para a posição {0} do vetor A:", i);
             vetorA[i]=int.Parse(Console.ReadLine());
         }
         for (int i=0; i<10; i++){
              Console.WriteLine("Informe um valor para a posição {0} do vetor B:", i);
             vetorB[i]=int.Parse(Console.ReadLine());
         }
            int j=0, k=0;
         for (int i = 0; i <20; i+=2){
                vetorC[i]=vetorA[j];
                j++;
                
            }
           for (int i =1; i<20; i+=2){
                vetorC[i]=vetorB[k];
            k++;
         }
         for(int i=0; i<20; i++){
             Console.WriteLine(vetorC[i]);
         }







        }
    }
}
