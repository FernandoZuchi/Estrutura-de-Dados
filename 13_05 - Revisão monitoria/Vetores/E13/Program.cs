using System;
// Faça um programa que leia um vetor de valores inteiros e
//imprima-o na ordem crescente. O vetor deve ter tamanho N
//(declare e utilize uma constante N)
class Program
{
    const int N = 10; // Tamanho do vetor

    static void Main(string[] args)
    {
        int[] vetor = new int[N]; // Vetor para armazenar os valores

        // Leitura dos valores
        Console.WriteLine($"Digite {N} valores:");
        for (int i = 0; i < N; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordenação do vetor em ordem crescente
        OrdenarVetor(vetor);

        // Impressão do vetor ordenado
        Console.WriteLine("Vetor em ordem crescente:");
        ImprimirVetor(vetor);
    }

    // Método para ordenar o vetor em ordem crescente
    static void OrdenarVetor(int[] vetor)
    {
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (vetor[i] > vetor[j])
                {
                    // Troca os valores de posição se estiverem fora de ordem
                    int temp = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = temp;
                }
            }
        }
    }

    // Método para imprimir o vetor
    static void ImprimirVetor(int[] vetor)
    {
        for (int i = 0; i < N; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}
