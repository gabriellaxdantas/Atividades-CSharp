using System;

namespace Roteiro8Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] vetorA = new int [10];
        int [] vetorB = new int [10];
        int [] num = new int [10];
        int soma=0, multipli=0;

        for(int i=0; i<10; i++){
        Console.WriteLine("Informe os valores para o vetor A:");
        num[i]=int.Parse(Console.ReadLine());
            if(num[i] != vetorB[i]){
        vetorA[i]=num[i];
        }
        }

        for(int i=0; i<10; i++){
            Console.WriteLine("Informe os valores para o vetor B:");
            num[i]=int.Parse(Console.ReadLine());
            if(num[i] != vetorA[i]){
            vetorB[i]=num[i];
            }
        }
        for(int i=0; i<10; i++){
           soma= vetorA[i]+vetorB[i];
        }
          Console.WriteLine("A soma é: {0}", soma);
         for(int i=0; i<10; i++){
           multipli= vetorA[i]*vetorB[i];
        }
        Console.WriteLine("A multiplicação é: {0}", multipli);


        }
    }
}
