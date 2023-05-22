public class MallardDuck : Pato, IVoar, IGrunir, INadar{
    public MallardDuck(string nome) : base(nome){
        
    }
    public void Voa(){

        Console.WriteLine("eu posso voar!");
    }

    public void Gruni(){

        Console.WriteLine("quack!");
    }
    public void Nada(){
        Console.WriteLine("Eu posso nadar!!");
    }
}