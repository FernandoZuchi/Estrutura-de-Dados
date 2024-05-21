// Encontrar o maior e o menor valor entre 10 valores:


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        int valor = Convert.ToInt32(Console.ReadLine());

        int menor = valor;
        int maior = valor;

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("Digite o próximo valor:");
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor > maior)
            {
                maior = valor;
            }

            if (valor < menor)
            {
                menor = valor;
            }
        }

        Console.WriteLine($"O maior valor é {maior} e o menor valor é {menor}.");
    }
}