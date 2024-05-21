// Dado um array contendo a idade de 10 alunos, faça um algoritmo que calcule o número de alunos com idade superior a média

class Program
{
    static void Main(string[] args)
    {
        int[] idades = new int[10];
        int soma = 0;

        Console.WriteLine("Digite as idades dos 10 alunos:");
        for (int i = 0; i < 10; i++)
        {
            idades[i] = Convert.ToInt32(Console.ReadLine());
            soma += idades[i];
        }

        double media = soma / 10.0; // Convertendo um dos operandos para double para garantir a divisão correta
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            if (idades[i] > media)
            {
                count++;
            }
        }

        Console.WriteLine($"Número de alunos com idade superior à média: {count}");
    }
}