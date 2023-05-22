using System;

namespace Roteiro11Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            StreamWriter sw = new StreamWriter("C:\\Users\\1406159\\POEMA.txt");

            Console.Write("Entre com um texto: ");
            texto = Console.ReadLine();
            
            sw.WriteLine(texto);
            sw.Close();
        }
    }
}
