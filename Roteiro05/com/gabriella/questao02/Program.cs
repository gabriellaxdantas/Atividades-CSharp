
class Program
{
    static void Main(){
        RodarCalculadora();
    }

    static void RodarCalculadora(){
        try{

            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Qual operação deseja fazer?:");
            Console.WriteLine("1 - Soma / 2 - Subtração / 3 - Multiplicação / 4 - Divisão / 5 - Módulo");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.Write("Informe o número correspondente a operação desejada: ");
            int operacao = int.Parse(Console.ReadLine());

            Console.Write("Informe o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = Calculadora.Soma(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 2:
                    resultado = Calculadora.Subtracao(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 3:
                    resultado = Calculadora.Multiplicacao(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 4:
                    resultado = Calculadora.Divisao(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 5:
                    resultado = Calculadora.Modulo(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                default:
                    throw new ArgumentException("Operação informada inválida. Digite um valor válido.");
            }
        }
        catch (FormatException){

            Console.WriteLine("Valor informado inválido.");
        }
        catch (DivideByZeroException ex){

            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (ArgumentException ex){

            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (Exception){

            Console.WriteLine("Ocorreu um erro.");
        }
    }
}
