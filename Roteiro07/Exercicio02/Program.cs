using System;

namespace Roteiro7Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float [] notas = new float [10];
            float soma=0, media=0;
            for (int i=0; i<10; i++){
                notas[i]= float.Parse(Console.ReadLine());
                soma+=notas[i];
            }
            for (int i=0; i<10; i++){
                Console.WriteLine(notas[i]);
            }
            media=soma/10;
            Console.WriteLine(media);
        }
    }
}
