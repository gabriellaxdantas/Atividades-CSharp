using System;

namespace Roteiro4Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, soma;
            Console.WriteLine("Informe o dia, mês e ano a seguir:");
            dia=int.Parse(Console.ReadLine());
            mes=int.Parse(Console.ReadLine());
            ano=int.Parse(Console.ReadLine());

            switch(mes){
                case(1):
                soma=dia;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(2):
                soma=dia+31;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(3):
                soma=dia+31+28;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(4):
                soma=dia+31+28+31;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(5):
                soma=dia+31+28+31+30;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(6):
                soma=dia+31+28+31+30+31;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                 case(7):
                soma=dia+31+28+31+30+31+30;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(8):
                soma=dia+31+28+31+30+31+30+31;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(9):
                soma=dia+31+28+31+30+31+30+31+31;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(10):
                soma=dia+31+28+31+30+31+30+31+31+30;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                 case(11):
                soma=dia+31+28+31+30+31+30+31+31+30+31;
                 Console.WriteLine("{0}/{1}", soma, ano);
                break;

                case(12):
                soma=dia+31+28+31+30+31+30+31+31+30+31+30;
                Console.WriteLine("{0}/{1}", soma, ano);
                break;
                
            }
            

        }
    }
}
