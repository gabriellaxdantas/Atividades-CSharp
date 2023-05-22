using System;

namespace Roteiro11Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        string linha;

        StreamReader sr = new StreamReader("C:\\Users\\1406159\\Desktop\\texto.txt");

        linha = sr.ReadLine();
        while(linha != null){
        Console.WriteLine(linha);

        linha = sr.ReadLine();
        }
        sr.Close();
        }
    }
}
