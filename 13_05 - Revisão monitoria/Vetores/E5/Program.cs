//  Faça um procedimento que faça a leitura um vetor de 10 elementos inteiros e imprima somente os valores armazenados nos índices pares

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];

        // Realizando a leitura do vetor
        LerVetor(vetor);

        // Imprimindo os valores armazenados nos índices pares
        ImprimirIndicesPares(vetor);
    }

    static void LerVetor(int[] vetor)
    {
        Console.WriteLine("Digite os 10 valores do vetor:");
        for (int i = 0; i < 10; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void ImprimirIndicesPares(int[] vetor)
    {
        Console.WriteLine("Valores armazenados nos índices pares:");

        // Iterando pelos índices pares e imprimindo os valores correspondentes
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}