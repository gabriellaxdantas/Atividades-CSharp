using System;

namespace Roteiro4Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           int hora;
           Console.WriteLine("Informe a hora:");
           hora=int.Parse(Console.ReadLine());

           switch(hora){
               case 3:
               Console.WriteLine("Matinas");
               break;

               case 5:
               Console.WriteLine("Laudes");
               break;

               case 7:
               Console.WriteLine("Prima");
               break;

               case 9:
               Console.WriteLine("Tercia");
               break;

               case 12:
               Console.WriteLine("Sexta");
               break;

               case 15:
               Console.WriteLine("Noa");
               break;

               case 18:
               Console.WriteLine("Vésperas");
               break;

               case 21:
               Console.WriteLine("Completas");
               break;
           }


           
        }
    }
}
