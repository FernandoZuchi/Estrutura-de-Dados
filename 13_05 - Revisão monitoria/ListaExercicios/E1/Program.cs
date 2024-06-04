using System;

class Program
{
    // Faça um procedimento que receba por parâmetro um vetor de
    //inteiros e inverta as posições dos elementos desse vetor. Exemplo: para o
    //vetor {1, 2, 4, 7, 4} deve ser alterado para {4, 7, 4, 2, 1}
    static void Main()
    {
        int[] vetor = { 1, 2, 4, 7, 4 };

        Console.WriteLine("Vetor original:");
        ImprimirVetor(vetor);

        InverterVetor(vetor);

        Console.WriteLine("Vetor invertido:");
        ImprimirVetor(vetor);
    }

    static void InverterVetor(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = vetor[i];            // Armazena o valor atual em temp
            vetor[i] = vetor[n - 1 - i];    // Atribui o valor oposto ao valor atual
            vetor[n - 1 - i] = temp;        // Atribui o valor armazenado em temp à posição oposta
        }
    }

    static void ImprimirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + (i < vetor.Length - 1 ? ", " : ""));
        }
        Console.WriteLine();
    }
}
