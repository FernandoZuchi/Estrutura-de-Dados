class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SomaParesEntre(1, 5));
    }
    static int SomaParesEntre(int min, int max)
    {
        if(min > max)
            return 0;

        return (min % 2 == 0 ? min : 0) + SomaParesEntre(min + 1, max);
    }
    // Uma forma de fazer
    // static int SomaParesEntre(int min, int max, int soma)
    // {
    //     if(min > max)
    //         return soma;

    //     if(min % 2 == 0)
    //         soma += min;

    //     return SomaParesEntre(min + 1, max, soma);
    // }

    // static void Imprime(int qtdeVezes)
    // {
    //     if(qtdeVezes == 0)
    //         return;

    //     Imprime(qtdeVezes - 1);

    //     Console.WriteLine($"{qtdeVezes}) Estude Estrutura de Dados!");
    // }
}