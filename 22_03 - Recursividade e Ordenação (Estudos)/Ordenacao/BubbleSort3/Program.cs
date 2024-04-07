class Program
{
    static void Main(string[] args)
    {
        int[] vet = {5, 3, 2, 7, 1, 4, 6};
        BubbleSort(vet);
        Imprime(vet);
    }

    static void BubbleSort(int[] vet)
    {
        int aux;
        bool trocou;

        do
        {
            trocou = false;
            for(int i = 0; i < vet.Length - 1; i++)
            {
                if(vet[i] > vet[i + 1])
                {
                    aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = aux;
                    trocou = true;
                }
            }
        }
        while(trocou);

    }

    static void Imprime(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
    }
}