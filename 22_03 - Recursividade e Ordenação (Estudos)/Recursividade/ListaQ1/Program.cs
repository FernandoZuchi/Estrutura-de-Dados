class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro e positivo: ");
        int num = Convert.ToInt32(Console.ReadLine());

        ImprimeDivisiveis(num);
    }

    static void ImprimeDivisiveis(int n)
    {
        int i = 0;

        // Condição de parada
        if(i >= n)
        {
            return;
        }

        // Verificando divisíveis
        if(n % 2 == 0)
        {
            Console.WriteLine($"{n} e divisível por 2");
        }

        if(n % 3 == 0)
        {
            Console.WriteLine($"{n} e divisível por 3");
        }

        ImprimeDivisiveis(n - 1);

    }
}