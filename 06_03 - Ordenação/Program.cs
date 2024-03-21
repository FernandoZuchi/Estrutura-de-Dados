internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] { 5, 2, 1, 6, 3, 8 };
        OrdenarPeloMetodoBolha(vetor);
        Imprimir(vetor);
    }
    static void OrdenarPeloMetodoBolha(int[] vetor)
    {
        int aux;
        bool houveTroca;

        do
        {
            houveTroca = false;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    houveTroca = true;
                }
            }
        } while (houveTroca);
    }
    static void Imprimir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
            Console.Write($"{vetor[i]}  ");

        Console.WriteLine();
    }
}
