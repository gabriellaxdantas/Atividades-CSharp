using System;

namespace Roteiro7Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] conjuntoNums = new int [10];
            int multiplicacao=1, soma=0;
            for(int i =0; i<10; i++){
                Console.WriteLine("Informe um valor para a posição {0} do vetor:", i);
                conjuntoNums[i]= int.Parse(Console.ReadLine());
                if (i %2==0){
                    multiplicacao *= conjuntoNums[i]; 
                }
                else 
                soma += conjuntoNums[i];
                }
                Console.WriteLine("A multiplicação dos pares é: {0}", multiplicacao);
                Console.WriteLine("A soma dos impares é {0}", soma);
            }
        }
    }

