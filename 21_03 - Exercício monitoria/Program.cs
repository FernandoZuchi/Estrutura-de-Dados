using System.Collections.Specialized;

internal class Program
{
    static void Main(string[] args)
    {
        double[] vetor = new double[5]{ 1, -3, 2.1, 2.8, 2.22};
        Console.WriteLine(Maior(vetor));
    }
    static double Maior(double [] vet)
    {
        return Maior(vetor, 1, vetor[0]);
    }
    static double Maior(double vetor, int posicao, double maior)
    {
        if(posicao < 0 || pposicao >= vetor.Length)
        {
            return maior;
        }
        if(vetor[posicao] > maior)
        {
            maior = vetor[posicao];
        }
        return Maior(vetor, posicao + 1, maior);
    }
}