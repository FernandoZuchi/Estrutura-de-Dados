class Program
{
    static void Main(string[] args)
    {
        int[] vet = { 5, 2, 3, 6, 1, 7, 4 };
        SelectSort(vet);
        Imprime(vet);
    }

    static void SelectSort(int[] vet)
    {
        int aux, indiceMenor;

        for(int i = 0; i < vet.Length - 1; i++)
        {
            indiceMenor = i;
            for(int j = i + 1; j < vet.Length; j++)
            {
                if(vet[j] < vet[indiceMenor])
                {
                    indiceMenor = j;
                }

                if(vet[indiceMenor] < vet[i])
                {
                    aux = vet[i];
                    vet[i] = vet[indiceMenor];
                    vet[indiceMenor] = aux;
                }
            }
        }
    }

    static void Imprime(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
    }
}