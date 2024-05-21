class Program{
    static void Main(string[] args)
    {
        int[,] matriz1 = new int[3,3];
        int[,] matriz2 = new int[3,3];
        int[,] somaMatriz = new int[3,3];

        System.Console.WriteLine("Informe os elementos da primeira matriz");
        LerMatriz(matriz1);

        System.Console.WriteLine("Informe os elementos da primeira matriz");
        LerMatriz(matriz2);
        SomaMatriz(matriz1,matriz2,somaMatriz);

        System.Console.WriteLine("Soma das matrizes: ");
        ImprimirMatriz(somaMatriz);
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

    static void SomaMatriz(int[,] matriz1, int[,] matriz2, int[,] somaMatriz)
    {
        for(int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1.GetLength(1); j++)
            {
                somaMatriz[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }
    }

    static void ImprimirMatriz(int[,] somaMatriz)
    {
        for (int i = 0; i < somaMatriz.GetLength(0); i++)
        {
            for (int j = 0; j < somaMatriz.GetLength(1); j++)
            {
                Console.Write("{0}    ",somaMatriz[i,j]);
            }
            Console.WriteLine();
        }
    }
}