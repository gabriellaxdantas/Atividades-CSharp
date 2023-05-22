using System;

namespace Roteiro4Exercicio1_If
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char escolha;
            Console.WriteLine("Informes os dois valores a seguir:");
            num1=double.Parse(Console.ReadLine());
            num2=double.Parse(Console.ReadLine());
            Console.WriteLine("Pressione [1] para soma, [2] para subtração, [3] para multiplicação e [4] para divisão.");
            escolha=char.Parse(Console.ReadLine());

            if(escolha==1){
                Console.WriteLine(num1+num2);
            }
            else if(escolha==2){
                Console.WriteLine(num1-num2);
            }
            else if(escolha==3){
                Console.WriteLine(num1*num2);
            }
            else if(escolha==4){
                Console.WriteLine(num1/num2);
            }
        }
    }
}
