using System;

class Program
{
    static void Main()
    {
        // Criando a matriz
        double[,] matriz = new double[5, 5];

        // Preenchendo a matriz
        PreencherMatriz(matriz);

        // Exibindo a matriz original
        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        // Trocando as diagonais
        TrocarDiagonais(matriz);

        // Exibindo a matriz após a troca
        Console.WriteLine("\nMatriz após a troca das diagonais:");
        ImprimirMatriz(matriz);
    }

    static void PreencherMatriz(double[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz:");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    static void TrocarDiagonais(double[,] matriz)
    {
        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho; i++)
        {
            double temp = matriz[i, i];
            matriz[i, i] = matriz[i, tamanho - 1 - i];
            matriz[i, tamanho - 1 - i] = temp;
        }
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
