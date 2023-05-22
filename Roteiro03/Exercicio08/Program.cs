using System;

namespace Roteiro3Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            nota1=double.Parse(Console.ReadLine());
            nota2=double.Parse(Console.ReadLine());
            nota3=double.Parse(Console.ReadLine());
            nota4=double.Parse(Console.ReadLine());

            media=(nota1+nota2+nota3+nota4/4);
            if(media>=60){
                Console.WriteLine("Aprovado");
            }
            else{
                Console.WriteLine("Reprovado");
            }
        }
    }
}
