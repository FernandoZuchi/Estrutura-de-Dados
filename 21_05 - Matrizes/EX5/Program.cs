using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[5, 5];

        CreateIdentityMatrix(matrix);

        Console.WriteLine("The identity matrix is:");
        PrintMatrix(matrix);
    }

    static void CreateIdentityMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == j)
                {
                    matrix[i, j] = 1;
                }
                else
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}