// Calcular o número de meses necessários para pagar uma dívida:


class Program
{
    static void Main(string[] args)
    {
        double debt = 10000;
        double investment = 1500;
        double debtInterestRate = 0.025;
        double investmentInterestRate = 0.04;
        int months = 0;

        while (debt > 0)
        {
            debt *= (1 + debtInterestRate);
            investment *= (1 + investmentInterestRate);
            debt -= investment;
            months++;
        }

        Console.WriteLine($"Número de meses necessários para pagar a dívida: {months}");
    }
}