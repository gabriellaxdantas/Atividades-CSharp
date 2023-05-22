using System;

namespace Roteiro3Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, soma=0;
            num1=double.Parse(Console.ReadLine());
            num2=double.Parse(Console.ReadLine());
            num3=double.Parse(Console.ReadLine());
            if(num3<num1 && (num1<num2)){
                soma=num1+num2;
                Console.WriteLine(soma);
            }
            else if(num2<num1 && (num1<num3)){
            soma=num1+num3;
            Console.WriteLine(soma);
            if(num2<num1 && (num1<num3)){
                soma=num1+num3;
                Console.WriteLine(soma);
            }
            else{
                soma=num2+num3;
                Console.WriteLine(soma);
            }
            }
    


        }
    }
}
