using System;

class Program {
    static bool EhPrimo(int num) {
        if (num < 2) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args) {
        int n;
        while (true) {
            Console.Write("Informe um número inteiro: ");
            try {
               n = int.Parse(Console.ReadLine());
                if (EhPrimo(n)) {
                    Console.WriteLine("O número {0} é primo", n);
                } else {
                    Console.WriteLine("O número {0} não é primo", n);
                }
                break;
            } catch (FormatException erro) {
                Console.WriteLine("O valor informado não é um inteiro. Por favor digite um número válido:");
                Console.WriteLine(erro.Message);
            }
        }
    }
}