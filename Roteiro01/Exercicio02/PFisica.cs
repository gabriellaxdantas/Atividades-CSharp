public class PF : Contribuintes {
    protected String cpf;
    public PF(String n,double r,String c) {
       nome = n;
       rendaBrt = r;
       cpf = c;
    }
    public override double calcImposto() {
        double imposto;
        if (rendaBrt <= 1400.00)
        {
            imposto = 0;
        }
        else if (rendaBrt <= 2100.00)
        {
            imposto = (rendaBrt * 0.1) - 100.00;
        }
        else if (rendaBrt <= 2800.00)
        {
            imposto = (rendaBrt * 0.15) - 270.00;
        }
        else if (rendaBrt <= 3600.00)
        {
            imposto = (rendaBrt * 0.25) - 500.00;
        }
        else
        {
            imposto = (rendaBrt * 0.3) - 700.00;
        }
        return imposto;
    }

    public override String exibirSigla(){

        return "PF";
    }
    
    

}