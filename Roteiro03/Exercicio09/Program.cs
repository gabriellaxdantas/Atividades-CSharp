using System;

namespace Roteiro3Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariobruto, horas, salariohora, salarioliquido, desconto;

            Console.WriteLine("Informe o número de horas trabalhadas:");
            horas=double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da hora de trabalho:");
            salariohora=double.Parse(Console.ReadLine());

            salariobruto=horas*salariohora;
            if(salariobruto<350.00){
                salarioliquido=salariobruto;
                Console.WriteLine("O valor do salário liquido é: {0}", salarioliquido);
            }
            else if(salariobruto>350.00 && salariobruto<1000.00){
                desconto=salariobruto*0.10;
                salarioliquido=salariobruto-desconto;
                Console.WriteLine("O valor do salário liquido é: {0}", salarioliquido);
            }
            else if(salariobruto>1000.00){
                desconto=salariobruto*0.20;
                salarioliquido=salariobruto-desconto;
                Console.WriteLine("O valor do salário liquido é: {0}", salarioliquido);
            }


        }
    }
}
