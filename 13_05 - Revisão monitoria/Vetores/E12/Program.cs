using System;
// ) Com relação ao exercício anterior, calcule e mostre o
//percentual dos apostadores que fizeram de 10 a 13 pontos e
//o percentual dos apostadores que fizeram menos do que 10
//pontos
class Program
{
    static void Main(string[] args)
    {
        int[] gabarito = new int[13]; // Vetor para armazenar o gabarito
        int totalApostadores = 5; // Total de apostadores

        // Leitura do gabarito
        Console.WriteLine("Digite o gabarito (1 para coluna 1, 0 para coluna do meio e 2 para coluna 2):");
        LerVetor(gabarito);

        // Variáveis para contagem de apostadores com 10 a 13 pontos e menos de 10 pontos
        int apostadores10a13 = 0;
        int apostadoresMenos10 = 0;

        // Verificação dos acertos dos 5 apostadores e contagem de pontuações
        for (int i = 0; i < totalApostadores; i++)
        {
            int[] apostador = new int[13]; // Vetor para armazenar o cartão de apostas do apostador

            // Leitura do cartão de apostas do apostador
            Console.WriteLine($"Digite as apostas do apostador {i + 1}:");
            LerVetor(apostador);

            int acertos = VerificarAcertos(gabarito, apostador);
            Console.WriteLine($"O apostador {i + 1} teve {acertos} acerto(s).");

            // Atualiza as contagens de acordo com a pontuação do apostador
            if (acertos >= 10)
            {
                apostadores10a13++;
            }
            else
            {
                apostadoresMenos10++;
            }
        }

        // Calcula e mostra os percentuais
        double percentual10a13 = (double)apostadores10a13 / totalApostadores * 100;
        double percentualMenos10 = (double)apostadoresMenos10 / totalApostadores * 100;

        Console.WriteLine($"Percentual de apostadores com 10 a 13 pontos: {percentual10a13}%");
        Console.WriteLine($"Percentual de apostadores com menos de 10 pontos: {percentualMenos10}%");
    }

    // Função para ler um vetor de 13 elementos
    static void LerVetor(int[] vetor)
    {
        for (int i = 0; i < 13; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Função para verificar os acertos de um apostador
    static int VerificarAcertos(int[] gabarito, int[] apostador)
    {
        int acertos = 0;

        for (int i = 0; i < 13; i++)
        {
            if (gabarito[i] == apostador[i])
            {
                acertos++;
            }
        }

        return acertos;
    }
}
