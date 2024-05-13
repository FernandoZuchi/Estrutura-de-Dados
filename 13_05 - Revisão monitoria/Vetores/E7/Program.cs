//  Faça um programa que leia um vetor de 15 posições (reais) e depois um valor a ser procurado no vetor. Imprima se o valor foi ou não encontrado e a quantidade de vezes que o valor está presente no vetor

class Program
{
    static void Main(string[] args)
    {
        double[] vetor = new double[15];

        // Leitura dos valores do vetor
        Console.WriteLine("Digite os 15 valores do vetor:");
        for (int i = 0; i < 15; i++)
        {
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Leitura do valor a ser procurado
        Console.WriteLine("Digite o valor a ser procurado no vetor:");
        double valorProcurado = Convert.ToDouble(Console.ReadLine());

        // Verificação se o valor está presente e contagem de ocorrências
        bool encontrado = false;
        int contador = 0;
        for (int i = 0; i < 15; i++)
        {
            if (vetor[i] == valorProcurado)
            {
                encontrado = true;
                contador++;
            }
        }

        // Impressão do resultado
        if (encontrado)
        {
            Console.WriteLine($"O valor {valorProcurado} foi encontrado no vetor, aparecendo {contador} vez(es).");
        }
        else
        {
            Console.WriteLine($"O valor {valorProcurado} não foi encontrado no vetor.");
        }
    }
}
