using System;

namespace Roteiro11Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
                    int [,] Matriz = new int [3,3];
                    for(int i=0; i<Matriz.GetLength(0); i++){
                for(int j=0; j<Matriz.GetLength(1); j++){
                    Console.Write("Entre com um valor para a posição (" + i + ", " + j + "): ");
                    Matriz[i,j] = int.Parse(Console.ReadLine());
                }
                 int [,] m = new int[3,3];
                preencheMatriz(m);
                StreamWriter sw = new StreamWriter("C:\\Users\\1406159\\Desktop\\mat.txt");
                for(int i=0; i<m.GetLength(0); i++){
                for(int j=0; j<m.GetLength(1); j++){ 
                    sw.Write(m[i,j] + " ");
                }
                sw.WriteLine("");
            
        sw.Close();
            }
        }
    }
    }
