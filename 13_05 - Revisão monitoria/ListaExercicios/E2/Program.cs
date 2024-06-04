class Program
{
    // Escreva um procedimento que receba um vetor de valores reais
    //e leia valores do teclado para preencher todo o vetor apenas com valores
    //positivos. Observe que valores negativos devem ser ignorados e a leitura
    static void Main(string[] args)
    {
        // Declara e inicializa o vetor
        double[] vetorValores = new double[5];

        // Chama a função para ler valores positivos do teclado
        LerValoresPositivosVetor(vetorValores);

        // Imprime os valores do vetor
        Console.WriteLine("\nValores digitados:");
        for (int i = 0; i < vetorValores.Length; i++)
        {
            Console.Write($"{vetorValores[i]} ");
        }
    }
    //deve ser encerrada assim que a última posição do vetor for preenchida.
    static void LerValoresPositivosVetor(double[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            double valor;

            while (true)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                valor = Convert.ToDouble(Console.ReadLine());

                if (Convert.ToDouble(valor) && valor > 0)
                {
                    vetor[i] = valor;
                    break; // Sai do loop while quando um valor positivo é lido
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite um valor positivo.");
                }
            }
        }
    }

}