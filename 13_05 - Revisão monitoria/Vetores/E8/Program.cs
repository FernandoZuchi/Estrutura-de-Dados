// Faça uma função que receba um vetor de números inteiros e um valor inteiro. A função deverá procurar este segundo valor neste vetor e retornar seu índice se for encontrado. Se o elemento não for encontrado, retornar -1

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso da função
        int[] vetor = { 1, 3, 5, 7, 9 };
        int valorProcurado = 5;

        int indice = ProcurarValor(vetor, valorProcurado);

        if (indice != -1)
        {
            Console.WriteLine($"O valor {valorProcurado} foi encontrado no índice {indice} do vetor.");
        }
        else
        {
            Console.WriteLine($"O valor {valorProcurado} não foi encontrado no vetor.");
        }
    }

    static int ProcurarValor(int[] vetor, int valorProcurado)
    {
        // Itera pelo vetor para encontrar o valor procurado
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valorProcurado)
            {
                return i; // Retorna o índice se o valor for encontrado
            }
        }

        return -1; // Retorna -1 se o valor não for encontrado
    }
}