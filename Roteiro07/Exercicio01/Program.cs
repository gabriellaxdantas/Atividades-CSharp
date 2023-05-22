using System;

namespace Roteiro7Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] nums = new int [5];
        int soma=0;
    for (int i=0; i<5; i++){
        nums [i] = int.Parse(Console.ReadLine());
        soma+=nums[i];
    }
    Console.WriteLine(soma);
        }
    }
}
