using System;

namespace Roteiro9Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz = new int [3,3];
            int simetrica =0;
            for(int i =0; i< 3; i++){
                Console.WriteLine("Linha {0}", i);
                for(int j=0; j< 3; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz[i,j]=int.Parse(Console.ReadLine());
                     if(matriz[i,j]==matriz[j,i]){
                       simetrica++;
                }
            }
        }
      

            if(simetrica==9){
                Console.WriteLine("A matriz é simetrica");
            }
            else{
                Console.WriteLine("Nao é simetrica");
            }
            

        }
    }
}
