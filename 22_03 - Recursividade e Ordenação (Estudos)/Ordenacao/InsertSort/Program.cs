class Program
{
    static void Main(string[] args)
    {
        int [] vet = {2, 1, 5, 9, 3, 4, 8};
        InsertSort(vet);
        Imprime(vet);
    }
    // Ordenar um vetor 
    static void InsertSort(int[] vet)
    {
        // A parte ordenada do vetor está entre 0 e i
        for (int i = 1; i < vet.Length; i++)
        {
            int chave = vet[i]; // Valor a ser inserido na parte ordenada
            int j = i - 1; // O j irá percorrer do elemento anterior a chave até zero

            // Localizando a posição j de Chave na parte ordenada:
            while(j >= 0 && chave < vet[j])
            {
                vet[j+1] = vet[j]; // Empurrando pro final do vetor elementos > chave
                j--; // Para percorrer de j até zero
            }
            vet[j + 1] = chave; // Inserimos a chave na posição correta do vetor
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