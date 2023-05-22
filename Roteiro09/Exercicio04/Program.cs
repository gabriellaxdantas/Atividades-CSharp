using System;

namespace Roteiro9Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz = new int [2,3];
            int cont=0;
            for(int i =0; i< 2; i++){
                Console.WriteLine("Linha {0}", i);
                for(int j=0; j< 3; j++){
                    Console.WriteLine("Informe um valor para a linha {0} coluna {1}", i, j);
                    matriz[i,j]=int.Parse(Console.ReadLine());
                    if(matriz[i,j]%2==0 && matriz[i,j]<0){
                        cont++;
                    } 
                }
            }

            int [] vetor = new int [cont];
            int k=0;
            for(int i=0; i<2; i++){
              for (int j = 0; j<3; j++){
                  if(matriz[i,j]%2==0 && matriz[i,j]<0){
                      vetor[k]=matriz[i,j];
                      k++;
                }
              }  
            }
            Console.WriteLine("Vetor de pares negativos:");
            for(int i=0; i<cont; i++){
                Console.WriteLine(vetor[i]);
            }
            for(int i =0; i<2; i++){
                Console.WriteLine("Linha {0}", i);
                for(int j=0; j<3; j++){
                    Console.WriteLine(" Linha {0} Coluna {1} = {2}", i,j, matriz[i,j]);
                }
            }
        }
    }
}
