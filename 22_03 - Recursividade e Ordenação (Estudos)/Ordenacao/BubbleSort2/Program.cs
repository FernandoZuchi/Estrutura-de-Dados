class Program
{
    static void Main(String[] args)
    {
        int[] vet = {5, 2, 3, 6, 1, 7, 4};
        BubbleSort(vet);
    }
    static void BubbleSort(int[] vet)
    {
        for(var i = vet.Length - 1; i > 0; i--)
        {
            for(var j = 0; j < i; j++)
            {
                if(vet[j] > vet[j + 1])
                {
                    var aux = vet[j];
                    vet[j] = vet[j + 1];
                    vet[j + 1] = aux;
                }
            }
        }
    }
}