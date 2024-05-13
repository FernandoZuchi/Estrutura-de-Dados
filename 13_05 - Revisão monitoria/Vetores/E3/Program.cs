// Faça um algoritmo que leia, via teclado, 20 valores do tipo inteiro e determine qual o menor valor existente no vetor e imprima esse valor e seu índice no vetor

class Program
{
    static void Main(string[] args)
    {
        int[] valores = new int[20];

        Console.WriteLine("Digite 20 valores:");

        // Leitura dos valores
        for (int i = 0; i < 20; i++)
        {
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Encontrar o menor valor e seu índice
        int menorValor = valores[0];
        int indiceMenor = 0;

        for (int i = 1; i < 20; i++)
        {
            if (valores[i] < menorValor)
            {
                menorValor = valores[i];
                indiceMenor = i;
            }
        }

        // Imprimir o menor valor e seu índice
        Console.WriteLine($"O menor valor é {menorValor} e está na posição {indiceMenor} do vetor.");
    }
}