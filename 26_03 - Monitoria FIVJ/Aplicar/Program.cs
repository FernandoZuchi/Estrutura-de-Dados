class Program
{
    // Função para calcular o Imposto de Renda
    static double CalcularImpostoRenda(double salario)
    {
        double impostoDeRenda = 0;

        if(salario <= 2259.20)
            impostoDeRenda = 0;
        else if(salario >= 2259.21 && salario <= 2826.65)
            impostoDeRenda = (salario - 169.44) * 0.075;
        else if(salario >= 2826.66 && salario <= 3751.05)
            impostoDeRenda = (salario  - 381.44) * 0.15;
        else if(salario >= 3751.06 && salario <= 4664.68)
            impostoDeRenda = (salario - 662.77) * 0.225;
        else if(salario >= 4664.68)
            impostoDeRenda = (salario - 896.19) * 0.275;


        return impostoDeRenda;
    }

    static void Main(string[] args)
    {
        // Solicita o salário do funcionário
        Console.Write("Digite o salário do funcionário: R$ ");
        double salario = Convert.ToDouble(Console.ReadLine());

        // Calcula o Imposto de Renda
        double impostoDeRenda = CalcularImpostoRenda(salario);

        // Exibe o valor do Imposto de Renda
        Console.WriteLine($"O funcionário deve pagar R$ {impostoDeRenda} Imposto de Renda.");
    }
}