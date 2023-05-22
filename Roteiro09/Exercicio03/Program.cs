using System;

namespace Roteiro9Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
         int [,] matriz = new int [3,3];
         int [] vetorMatriz = new int [3];
            for(int i =0; i< 3; i++){
                Console.WriteLine("Linha {0}", i);
                for(int j=0; j< 3; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz[i,j]=int.Parse(Console.ReadLine());
                    if(j==i){
                        vetorMatriz[i]=matriz[i,j];
                 }  
             }   
        }

        Console.WriteLine("elementos na diagonal:");
        for(int i=0; i <3; i++){
            Console.WriteLine(vetorMatriz[i]);
        }

        for(int i=0; i<3; i++){
        Console.WriteLine("Linha {0}", i);
        
        for(int j=0; j<3; j++){
            Console.WriteLine(matriz[i,j]);
        }
        }


        }
    }
}
