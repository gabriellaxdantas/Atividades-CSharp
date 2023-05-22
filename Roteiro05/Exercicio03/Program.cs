using System;

namespace Roteiro5Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
         int num=1, intervalo1=0, intervalo2=0, intervalo3=0, intervalo4=0;
         while(num!=-1){
             num=int.Parse(Console.ReadLine());
             if(num>=0 && num <=25){
                 intervalo1++;
             }
             if(num>=26 && num <=50){
                 intervalo2++;
             }
              if(num>=51 && num <=75){
                 intervalo3++;
             }
              if(num>=76 && num <=100){
                 intervalo4++;
             }
         }
         Console.WriteLine("O total no intervalo de 0 a 25 é:{0}, o total no intervalo 26 a 50 é; {1}, o total no intervalo 51 a 75 é: {2} e o total no intervalo 76 a 100 é: {3}", intervalo1, intervalo2, intervalo3, intervalo4);

        }
    }
}
