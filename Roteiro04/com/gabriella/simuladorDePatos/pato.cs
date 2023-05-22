public abstract class Pato
{
    public string nome {get; set;}

    public Pato (string nome){
        this.nome = nome;
    }
    public void Mostrar(){
        Console.WriteLine("Olá, eu sou o pato {0}", nome);
    }
}