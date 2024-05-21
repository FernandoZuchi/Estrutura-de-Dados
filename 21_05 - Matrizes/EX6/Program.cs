class Program
{
    static void Main()
    {
        double[,] matrix = {
            { 1.5, 2.3, 3.7 },
            { 4.1, 5.6, 6.8 },
            { 7.2, 8.4, 9.9 }
        };

        double sum = SumMatrixElements(matrix);
        Console.WriteLine($"The sum of all elements in the matrix is: {sum}");
    }

    static double SumMatrixElements(double[,] matrix)
    {
        double sum = 0;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
            }
        }

        return sum;
    }
}