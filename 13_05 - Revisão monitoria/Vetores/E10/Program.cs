//  Faça um programa que leia um conjunto de 20 valores e 
//armazene-os num vetor V. Particione-o em dois outros 
//vetores, P e I, conforme os valores de V forem pares ou 
//ímpares. No final, imprima os valores dos 3 vetores.

class Program
{
    static void Main(string[] args)
    {
        int[] V = new int[20]; // Vetor para armazenar os 20 valores
        int[] P = new int[20]; // Vetor para armazenar os valores pares
        int[] I = new int[20]; // Vetor para armazenar os valores ímpares

        // Leitura dos 20 valores
        Console.WriteLine("Digite 20 valores:");
        for (int i = 0; i < 20; i++)
        {
            V[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Particionamento dos valores em P e I
        int countP = 0; // Contador para os valores pares
        int countI = 0; // Contador para os valores ímpares

        for (int i = 0; i < 20; i++)
        {
            if (V[i] % 2 == 0) // Verifica se o valor é par
            {
                P[countP] = V[i]; // Armazena o valor par em P
                countP++;
            }
            else // O valor é ímpar
            {
                I[countI] = V[i]; // Armazena o valor ímpar em I
                countI++;
            }
        }

        // Impressão dos valores dos três vetores
        Console.WriteLine("Valores do vetor V:");
        ImprimirVetor(V);
        Console.WriteLine("Valores do vetor P:");
        ImprimirVetor(P, countP); // Apenas os valores válidos em P
        Console.WriteLine("Valores do vetor I:");
        ImprimirVetor(I, countI); // Apenas os valores válidos em I
    }

    // Método para imprimir os valores de um vetor
    static void ImprimirVetor(int[] vetor, int tamanho = 20)
    {
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}
