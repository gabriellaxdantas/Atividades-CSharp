using System;

namespace Roteiro3Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, absoluto;
            num=double.Parse(Console.ReadLine());
            if(num<0){
                absoluto=(num*(-1));
            }
            else{
                absoluto=num;
            }
            Console.WriteLine(absoluto);

        }
    }
}
