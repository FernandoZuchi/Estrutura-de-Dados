class Program
{
    static void Main(string[] args)
    {
        int[] vet = {5, 2, 3, 6, 1, 7, 4};
        BubbleSort(vet); // Ordena o vetor com o método BubbleSort
        Imprime(vet); // Imprime o vetor
    }
    static void BubbleSort(int[] vet)
    {
        int aux; // Variável auxiliar, muito usada nesse tipo de algorítmo
        bool trocou; // Variável de controle para utilizar no do while

        do
        {
            trocou = false; // Troca o valor da variável de controle para false, pq ainda nao houve troca
            for(int i = 0; i < vet.Length - 1; i++)
            {
                if(vet[i] > vet[i + 1])
                {
                    aux = vet[i + 1]; 
                    vet[i + 1] = vet[i];
                    vet[i] = aux;
                    trocou = true;
                }
            }
        } 
        while (trocou);
    }
    static void Imprime(int[] vet)
    {
        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
    }
}