class Program
{
    static void Main(string[] args)
    {
        // Encontre o maior número em um vetor de números reais utilizando uma chamda recursiva
        int[] vet = {2, 6, 5, 9, 7, 9, 12, 15, 19, 22, 1, 3};
        int i = 0;
        Console.WriteLine(MaiorNum(vet, i));
    }
    static int MaiorNum(int[] vet, int i)
    {
        // Condição de parada - Índice atinge o final do vetor
        if(i == vet.Length - 1)
        {
            return vet[i];
        }

        // Chamada recursiva
        int maior = MaiorNum(vet, i + 1);

        if(vet[i] > maior)
        {
            return vet[i];
        }
        else
        {
            return maior;
        }

    }
}