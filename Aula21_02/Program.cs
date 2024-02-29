void ImprimeSomaIntervalo(int menor, int maior, int soma)
{
    if(menor > maior)
    {
        Console.WriteLine(soma);
        return;
    }

    soma += menor;
    ImprimeSomaIntervalo(menor + 1, maior, soma);
}

ImprimeSomaIntervalo(3, 5, 0);