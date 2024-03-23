internal class Program
{
    private static void Main(string[] args)
    {
        // Faça uma função recursiva que receba um vetor de inteiros por parâmetro e retorne a soma dos elementos pertencentes a este valor
        int [] vetor = {1, 2, 3, 4, 5};
        int soma = Soma(vetor, 0);
        Console.WriteLine(soma);
    }
    static int Soma(int[] vetor, int indice)
    {
        if(indice < vetor.Length)
        {
           return vetor[indice] + Soma(vetor, indice + 1);
        }
        else
        {
            return 0;
        }
    }
}