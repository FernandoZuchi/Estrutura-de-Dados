// Faça um algoritmo para ler e somar dois vetores de 10 elementos inteiros. Imprima ao final os valores dessa soma, elemento a elemento

class Program
{
    static void Main(string[] args)
    {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] soma = new int[10];

        Console.WriteLine("Digite os valores do primeiro vetor:");
        for (int i = 0; i < 10; i++)
        {
            vetor1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Digite os valores do segundo vetor:");
        for (int i = 0; i < 10; i++)
        {
            vetor2[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            soma[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("A soma dos vetores é:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(soma[i]);
        }
    }
}