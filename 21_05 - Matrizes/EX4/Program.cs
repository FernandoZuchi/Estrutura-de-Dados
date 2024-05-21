class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3,3];
        int[,] matrizInvertida = new int[3,3];

        Console.WriteLine("Insira os elementos para a matriz 10x10: ");  
        LerMatriz(matriz);
        

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        Console.WriteLine("Matriz invertida: ");
        inverterMatriz(matriz, matrizInvertida);
        ImprimirMatriz(matrizInvertida);
    }

    static void LerMatriz(int[,] matriz)
    {
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                System.Console.Write("Elemento [{0},{1}] : ", i, j);
                matriz[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void inverterMatriz(int[,] matriz, int[,] matrizInvertida)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matrizInvertida[j, i] = matriz[i, j];
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("{0}    ",matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
}