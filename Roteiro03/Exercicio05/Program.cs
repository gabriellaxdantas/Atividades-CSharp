using System;

namespace Roteiro3Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num=int.Parse(Console.ReadLine());
            if(num % 2 ==0 && num % 7 == 0){
            Console.WriteLine("O número {0} é divisivel por 2 e por 7", num); 
            }
            else{
                Console.WriteLine("O número {0} não é divisivel por 2 e por 7", num);
            }
           
        }
    }
}
