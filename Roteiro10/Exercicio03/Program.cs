using System;

namespace Roteiro10Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
               int [,] matriz = new int [4,3];
             int [] maiorValor = new int [4];
            
            
            for(int i =0; i< 4; i++){
                Console.WriteLine("Linha {0}", i);
                maiorValor[i]=0;
                for(int j=0; j< 3; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz[i,j]=int.Parse(Console.ReadLine());
                    if(matriz[i,j]>maiorValor[i]){
                        maiorValor[i]=matriz[i,j];
                    }
                     
                }
               
            }
            for(int i=0; i<4; i++){
                Console.WriteLine(maiorValor[i]);
            }


        }
    }
}
