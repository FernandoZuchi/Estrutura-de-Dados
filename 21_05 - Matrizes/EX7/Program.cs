class Program
{
    static void Main()
    {
        double[] vector = new double[5];
        double[,] matrix = new double[5, 5];
        double[] result = new double[5];

        Console.WriteLine("Enter the elements for the vector:");
        ReadVector(vector);

        Console.WriteLine("Enter the elements for the 5x5 matrix:");
        ReadMatrix(matrix);

        MultiplyVectorByMatrix(vector, matrix, result);

        Console.WriteLine("The result of multiplying the vector by the matrix is:");
        PrintVector(result);
    }

    static void ReadVector(double[] vector)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Element [{i}]: ");
            vector[i] = double.Parse(Console.ReadLine());
        }
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

    static void MultiplyVectorByMatrix(double[] vector, double[,] matrix, double[] result)
    {
        int size = vector.Length;
        for (int i = 0; i < size; i++)
        {
            result[i] = 0;
            for (int j = 0; j < size; j++)
            {
                result[i] += vector[j] * matrix[j, i];
            }
        }
    }

    static void PrintVector(double[] vector)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine($"Element [{i}]: {vector[i]}");
        }
    }
}