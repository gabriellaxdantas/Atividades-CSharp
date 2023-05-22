using System;

namespace Roteiro5Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        int idade, n=0, soma=0;
        double media;
        idade=int.Parse(Console.ReadLine());
        while(idade!=0){
            soma+=idade;
            idade=int.Parse(Console.ReadLine());
            n++;
        }
        media=(soma/n);
        Console.WriteLine("A idade média desse grupo é: {0}", media);
        }
    }
}
