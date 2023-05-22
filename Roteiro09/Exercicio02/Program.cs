using System;

namespace Roteiro9Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz1 = new int [3,3];
            int [,] matriz2 = new int [3,3];
            int identica = 0;
            for(int i =0; i< 3; i++){
                Console.WriteLine("Linha {0} matriz 1", i);
                for(int j=0; j< 3; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz1[i,j]=int.Parse(Console.ReadLine());
                    
            }
        }

        for(int i =0; i< 3; i++){
                Console.WriteLine("Linha {0} matriz 2", i);
                for(int j=0; j< 3; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz2[i,j]=int.Parse(Console.ReadLine());
                    
            }
        }
     for(int i =0; i<3; i++){
         for(int j = 0; j<3; j++){
                     if(matriz1[i,j]==matriz2[i,j]){
                         identica++;
                     }
                 }
             }

        if(identica==9){
            Console.WriteLine("As matrizes sao identticas");
        }
        else{
            Console.WriteLine("Nao são identicas");
        }

        }
    }
}
