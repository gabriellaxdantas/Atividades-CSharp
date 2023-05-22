class Calculadora
{
    public static double Soma(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtracao(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiplicacao(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divisao(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Não é possível realizar divisão por 0.");
        }
        return num1 / num2;
    }

    public static double Modulo(double num1, double num2)
    {
        return num1 % num2;
    }
}