 class Program
{
    static void Main(){

        int[] vet = new int[10];

        for (int i = 0; i < 10; i++){

            try{

                Console.Write("Informe um número inteiro para a posição {0}: ", i);
                string valorVet = Console.ReadLine();
                int valor;

                if (!int.TryParse(valorVet, out valor)){

                    throw new FormatException("Valor informado inválido. Informe um número inteiro.");

                }

                vet[i] = valor;
            }
            catch (FormatException ex){

                Console.WriteLine("Erro: " + ex.Message);
                i--;
            }
            catch (IndexOutOfRangeException){

                Console.WriteLine("Erro: Posição escolhida inválida. Informe uma posição de 0 a 9.");
                i--; 
            }
            catch (Exception){

                Console.WriteLine("Ocorreu um erro.");
                break; 
            }
        }

        Console.WriteLine("Valores armazenados no vetor:");
        for (int i = 0; i < 10; i++){

            Console.WriteLine($"Posição {i}: {vet[i]}");
        }
    }
}
