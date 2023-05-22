public abstract class Contribuintes {
    protected String nome;
    protected double rendaBrt;

    abstract public double calcImposto();
    abstract public string exibirSigla();

    

    public String getNome(){
        return nome;
    }


}