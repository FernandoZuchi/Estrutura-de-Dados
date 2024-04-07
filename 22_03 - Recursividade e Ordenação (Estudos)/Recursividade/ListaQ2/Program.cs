class Program
{
    static void Main(string[] args)
    {
        int[] vet = {3, -2, -6, 2, 1, -1, -9, -6, -5};
        Console.WriteLine(Negativos(vet, 0));
        Imprime(vet);
    }
    static int Negativos(int[] vet, int i)
    {
        int cont = 0;

        if(i == vet.Length)
        {
            return 0;
        }

        if(vet[i] < 0)
        {
            vet[i] *= -1;
            cont++;
        }

        return Negativos(vet, i + 1) + cont;
    }

    static void Imprime(int[] vet)
    {
        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }
    }
}