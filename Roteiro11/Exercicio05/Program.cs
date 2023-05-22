using System;

namespace Roteiro11Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
                    int [,] m = new int[3,3];
                Console.WriteLine("----- Matriz antiga -----");
                lerArquivo();
                Console.WriteLine("");
                preencheMatriz(m);
                StreamWriter sw = new StreamWriter("C:\\Users\\1406159\\Desktop\\mat.txt");
                for(int i=0; i<m.GetLength(0); i++){
                for(int j=0; j<m.GetLength(1); j++){ 
                    sw.Write(m[i,j] + " ");
                }
                sw.WriteLine("");
            }
            Console.WriteLine("----- Matriz nova -----");
            sw.Close();
            lerArquivo();
        }
    }
}
