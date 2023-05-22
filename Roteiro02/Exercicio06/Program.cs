using System;

namespace Roteiro2Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
        double catA, catB, hipotenusaquadrado, hipotenusa;

          Console.WriteLine("Informe o valor dos catetos a seguir:");
          catA=double.Parse(Console.ReadLine());
          catB=double.Parse(Console.ReadLine());

          hipotenusaquadrado= (catA*catA)+(catB*catB);
          hipotenusa=Math.Sqrt(hipotenusaquadrado);
          Console.WriteLine("O valor da hipotenusa é {0}", hipotenusa);
        }
    }
}
