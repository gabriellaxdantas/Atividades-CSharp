public class PJ : Contribuintes {
    protected String cnpj;
    public PJ(String n,double r,String c) {
        nome = n;
        rendaBrt = r;
        cnpj = c;
    }
    public override double calcImposto(){
        return (rendaBrt * 0.10);
    }

    public override String exibirSigla(){

        return "PJ";
    }
}