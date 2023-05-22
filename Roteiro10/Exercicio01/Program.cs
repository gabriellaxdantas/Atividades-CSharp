using System;

namespace Roteiro10Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
             int [,] matriz = new int [3,4];
            int maior=0, linha=0, coluna=0;
            
            for(int i =0; i< 3; i++){
                Console.WriteLine("Linha {0}", i);
                for(int j=0; j< 4; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz[i,j]=int.Parse(Console.ReadLine());
                    if(matriz[i,j]>maior){
                        maior=matriz[i,j];
                        linha=i;
                        coluna=j;
                    } 
                }
            }
            Console.WriteLine("O maior valor é {0}. A linha em que o valor está localizado é {1} e a coluna é {2}", maior, linha, coluna);

        }
    }
}
