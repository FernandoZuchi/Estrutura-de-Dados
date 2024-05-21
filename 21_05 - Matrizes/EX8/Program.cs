class Program
{
    static void Main()
    {
        double[,] matrix1 = new double[3, 3];
        double[,] matrix2 = new double[3, 3];
        double[,] resultMatrix = new double[3, 3];

        Console.WriteLine("Enter the elements for the first 3x3 matrix:");
        ReadMatrix(matrix1);

        Console.WriteLine("Enter the elements for the second 3x3 matrix:");
        ReadMatrix(matrix2);

        MultiplyMatrices(matrix1, matrix2, resultMatrix);

        Console.WriteLine("The result of multiplying the two matrices is:");
        PrintMatrix(resultMatrix);
    }

    static void ReadMatrix(double[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    static void MultiplyMatrices(double[,] matrix1, double[,] matrix2, double[,] resultMatrix)
    {
        int size = matrix1.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < size; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}