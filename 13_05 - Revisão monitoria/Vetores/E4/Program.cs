// Desenvolva um programa que leia um vetor de números reais, um escalar e imprima o resultado da multiplicação do vetor pelo escalar

class Program
{
    static void Main(string[] args)
    {
        // Definindo o tamanho do vetor
        int tamanho = 5; // Você pode alterar o tamanho conforme necessário

        // Criando o vetor de números reais
        double[] vetor = new double[tamanho];

        // Lendo os valores do vetor
        Console.WriteLine($"Digite os {tamanho} valores do vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Lendo o escalar
        Console.WriteLine("Digite o valor do escalar:");
        double escalar = Convert.ToDouble(Console.ReadLine());

        // Multiplicando o vetor pelo escalar
        double[] resultado = MultiplicarPorEscalar(vetor, escalar);

        // Imprimindo o resultado
        Console.WriteLine("Resultado da multiplicação do vetor pelo escalar:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(resultado[i]);
        }
    }

    static double[] MultiplicarPorEscalar(double[] vetor, double escalar)
    {
        // Criando um novo vetor para armazenar o resultado
        double[] resultado = new double[vetor.Length];

        // Multiplicando cada elemento do vetor pelo escalar
        for (int i = 0; i < vetor.Length; i++)
        {
            resultado[i] = vetor[i] * escalar;
        }

        // Retornando o vetor resultado
        return resultado;
    }
}
