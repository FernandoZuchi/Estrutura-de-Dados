using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] { 5, 2, 1, 6, 3, 8 };
        OrdenarPorInsercao(vetor);
        Imprimir(vetor);
    }
    // Ordenação pelo método bolha
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

    // Ordenação pelo método inserção -  cartas no baralho = considera que a 1ª carta está ordenada e começa a ordenação a partir dela
    static void OrdenarPorInsercao(int[] vet)
    {
        int atual, i;

        for(int ultimoOrdenado = 0; ultimoOrdenado < vet.Length - 1; ultimoOrdenado++)
        {
            atual = vet[ultimoOrdenado + 1];
            for (i = ultimoOrdenado; i >= 0 && vet[i] > atual; i--)
                vet[i + 1] = vet[i];
            
            vet[i + 1] = atual;
        }
    }

    // Ordenação pelo método da seleção, seleciona os menores e colocam-nos nas primeiras posições
    static void OrdenarPorSelecao(int[] vet)
    {
        int indiceMenor, aux;
        for(int i = 0; i < vet.Length - 1; i++)
        {
            indiceMenor = i;

            for (int j = i + 1; j < vet.Length; j++)
            {
                if(vet[j] < vet[indiceMenor])
                {
                    indiceMenor = j;
                }
            }
            if(indiceMenor != i)
            {
                aux = vet[i];
                vet[i] = vet[indiceMenor];
                vet[indiceMenor] = aux;
            }
        }
    }
}
