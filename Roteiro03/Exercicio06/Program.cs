using System;

namespace Roteiro3Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            num1=double.Parse(Console.ReadLine());
            num2=double.Parse(Console.ReadLine());
            num3=double.Parse(Console.ReadLine());
            if(num1>num2 && num1>num3){
                Console.WriteLine("O maior numero é o {0}", num1);
            }
            if(num2>num1 && num2>num3){
                 Console.WriteLine("O maior numero é o {0}", num2);
            }
            if(num3>num1 && num3>num2){
                 Console.WriteLine("O maior numero é o {0}", num3);
            }
              else if(num1<num3 && num1<num2){
                 Console.WriteLine("O menor numero é o {0}", num1);
            }
            else if(num2<num1 && num2<num3){
                 Console.WriteLine("O menor numero é o {0}", num2);
            }
            else if(num3<num1 && num3<num2){
                 Console.WriteLine("O menor numero é o {0}", num3);
            }


        }
    }
}
