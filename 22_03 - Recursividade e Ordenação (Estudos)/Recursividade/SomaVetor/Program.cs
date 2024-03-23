// Somar todos elementos do vetor de forma recursiva
class Program
{
    static void Main(string[] args)
    {
        int[] vet = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(Soma(vet, 0)); 
    }
    static int Soma(int[] vet, int i)
    {    
        return i == vet.Length ?  0 : Soma(vet, i + 1) + vet[i];
    }
}