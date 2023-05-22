using System;

namespace Roteiro2Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, novopreco, desconto;
            preco=double.Parse(Console.ReadLine());
            desconto=(preco*0.10);
            novopreco=preco-desconto;
            Console.WriteLine("O novo valor do produto é:{0}", novopreco);

        }
    }
}
