public class RubberDuck : Pato, IGrunir, INadar{
    public RubberDuck(string nome) : base(nome){
        
    }
    public void Gruni(){

        Console.WriteLine("squeak!");

    }
    public void Nada(){
        Console.WriteLine("eu posso nadar!!");
    }
}