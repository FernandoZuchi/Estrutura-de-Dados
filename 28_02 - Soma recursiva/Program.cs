using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        var vetor = new int[] { 1, 2, 4, 5};      

    } 
    // Faça uma função recursiva que receba um vetor de inteiros por parâmetro e retorne a soma dos elementos pertencentes à este valor.

    static int Soma(int[] vetor, int indice = 0, int soma = 0)
    {
        if(indice >= vetor.Length)
        return 0; 

        soma += vetor[indice];

        return Soma(vetor, indice + 1, soma);
    }
}
