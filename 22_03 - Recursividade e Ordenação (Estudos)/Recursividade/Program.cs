class Program // Recursivadade - "Empilhamento e desempilhamento"
{
    static void Main(string[] args)
    {
       Console.WriteLine(Multiplica(5,5));
       Console.WriteLine(Fat(5));
       Console.WriteLine(Fib(6));
    }
    static int Multiplica(int m, int n)
    {
        //Condição de parada
        if(n == 0)
        {
            return 0;
        }
        else
        {
            return m + Multiplica(m, n - 1);
        }
    }
    // Fatorial de um número usando recursividade
    static int Fat(int n)
    {
        //Condição de parada
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Fat(n - 1);
        }
    }
    // Série de Fibonacci - Soma dos dois antecessores (Apenas a partir do 3)
    static int Fib(int n)
    {
        // Condição de parada - A sequência de Fibonnaci funciona apenas para > 2
        if(n <= 2)
        {
            return 1;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}