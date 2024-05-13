// Verificar se um número é primo:


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro positivo:");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{num} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{num} não é um número primo.");
        }
    }
}