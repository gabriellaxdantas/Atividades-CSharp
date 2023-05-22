using System;

namespace Roteiro6Exercicio2
{
    class Program
    {
        static double mediaAri (double nota1, double nota2, double nota3){
            double mediaA=0;
            mediaA= (nota1 +nota2 +nota3) /3;
            return mediaA;
             }

         static double mediaPon (double nota1, double nota2, double nota3){
            double mediaP=0;
            mediaP=(((nota1*2) + (nota2*3) +(nota3*5))/10);
            return mediaP; 
            }


        static void Main(string[] args)
        {
            double nota1, nota2, nota3, res=0;
            int opcao;
            Console.WriteLine("Informe as notas:");
            nota1=double.Parse(Console.ReadLine());
            nota2=double.Parse(Console.ReadLine());
            nota3=double.Parse(Console.ReadLine());

            Console.WriteLine("1 para media aritimetica e 2 para media ponderada (outros valores serão desconsiderados)");
            opcao=int.Parse(Console.ReadLine());
            if(opcao == 1){
               res= mediaAri(nota1, nota2, nota3);  
            } 
            else if (opcao == 2){
                res= mediaPon(nota1, nota2, nota3);
            }
            else{
                Console.WriteLine("Opção invalida");
            }
            Console.WriteLine(res);


      }
    }
 }
 


