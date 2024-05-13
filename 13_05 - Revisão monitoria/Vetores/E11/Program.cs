// Faça um programa que leia um vetor G[13] que é o
//gabarito de um teste da loteria esportiva, contendo os valores
//1 quando for coluna 1, 0 quando for coluna do meio e 2
//quando for coluna 2.
//Ler a seguir, para 5 apostadores, seu cartão de apostas
//(R[13]) e depois da leitura imprimir quantos acertos o
//apostador teve.
//Faça o teste através de funções

class Program
{
    static void Main(string[] args)
    {
        int[] gabarito = new int[13]; // Vetor para armazenar o gabarito

        // Leitura do gabarito
        Console.WriteLine("Digite o gabarito (1 para coluna 1, 0 para coluna do meio e 2 para coluna 2):");
        LerVetor(gabarito);

        // Verificação dos acertos dos 5 apostadores e impressão dos resultados
        for (int i = 0; i < 5; i++)
        {
            int[] apostador = new int[13]; // Vetor para armazenar o cartão de apostas do apostador

            // Leitura do cartão de apostas do apostador
            Console.WriteLine($"Digite as apostas do apostador {i + 1}:");
            LerVetor(apostador);

            int acertos = VerificarAcertos(gabarito, apostador);
            Console.WriteLine($"O apostador {i + 1} teve {acertos} acerto(s).");
        }
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