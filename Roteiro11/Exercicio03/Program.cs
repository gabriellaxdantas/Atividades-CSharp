using System;

namespace Roteiro11Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;

            StreamReader sr = new StreamReader("C:\\Users\\1406159\\Desktop\\texto.txt");

            linha = sr.ReadLine();

            while(linha != null){
                for(int i=1; i<=20; i++){
                    Console.WriteLine(linha);
                    linha = sr.ReadLine();
                    }

                    Console.Write("-> MAIS... [ENTER] \n");
                    Console.ReadKey();
                }
                
                sr.Close();
        }
    }
}
