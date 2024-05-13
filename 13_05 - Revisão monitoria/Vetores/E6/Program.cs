// Faça um programa que leia um vetor com 15 valores reais. A seguir, encontre o menor elemento do vetor e a sua posição dentro do vetor, mostrando: "O menor elemento do vetor está na posição XXXX e tem o valor YYYYY."

class Program
{
    static void Main(string[] args)
    {
        double[] vetor = new double[15];

        // Leitura dos valores do vetor
        Console.WriteLine("Digite os 15 valores do vetor:");

        for (int i = 0; i < 15; i++)
        {
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Encontrar o menor elemento e sua posição
        double menorElemento = vetor[0];
        int posicaoMenor = 0;

        for (int i = 1; i < 15; i++)
        {
            if (vetor[i] < menorElemento)
            {
                menorElemento = vetor[i];
                posicaoMenor = i;
            }
        }

        // Imprimir o resultado
        Console.WriteLine($"O menor elemento do vetor está na posição {posicaoMenor} e tem o valor {menorElemento}.");
    }
}