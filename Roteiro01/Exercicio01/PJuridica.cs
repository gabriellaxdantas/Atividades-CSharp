public class PJuridica : Contribuinte {
    protected String cnpj;
    public PJuridica(String n,double r,String c) {
        nome = n;
        rendaBrt = r;
        cnpj = c;
    }
    public override double calcImposto(){
        return (rendaBrt * 0.10);
    }

}