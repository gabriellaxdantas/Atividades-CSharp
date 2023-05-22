class Program
{
    static void Main(){
        
        double soma = 0;
        int quantidade = 0;
        double media = 0;

        try{

            while (soma <= 100){

                Console.Write("Digite um número inteiro: ");
                string input = Console.ReadLine();
                int numero;

                if (!int.TryParse(input, out numero)){

                    throw new FormatException("Valor informado inválido. Informe um número inteiro.");

                }

                if (soma + numero > 100){

                    throw new ExcecaoAcimaDeCem("Soma acima de 100.");
                }

                soma += numero;
                quantidade++;
                media = soma / quantidade;
            }

            soma -= quantidade; 
            quantidade--;

        }
        catch (FormatException ex){

            Console.WriteLine("Erro: " + ex.Message);

        }

        catch (ExcecaoAcimaDeCem ex){

            Console.WriteLine("Erro: " + ex.Message);

        }

        catch (Exception){

            Console.WriteLine("Ocorreu um erro.");

        }

        Console.WriteLine("Valor somado antes de atingir 100: " + soma);
        Console.WriteLine("Quantidade de números somados: " + quantidade);
        Console.WriteLine("Média: " + media);
    }
}