class Program
{
    static void Main(string[] args)
    {
        int[] vet = { 5, 2, 3, 6, 1, 7, 4 };
        BubbleSort(vet);
        Imprime(vet);
    }

    static void BubbleSort(int[] vet)
    {
        bool trocou = false;
        int aux;

        do
        {
            trocou = false;

            for(int i = 1; i < vet.Length - 1; i++)
            {
                if(vet[i] > vet[i + 1])
                {
                    aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = vet[i];
                    trocou = true;
                }
            }
        } 
        while (trocou);
    }
    static void Imprime(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
    }

}