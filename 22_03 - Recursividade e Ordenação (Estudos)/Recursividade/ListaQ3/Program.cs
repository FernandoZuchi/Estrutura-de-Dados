class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o montante reservado para aposentadoria");
        double montante = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o valor que pretende retirar por mês");
        double retirada = Convert.ToDouble(Console.ReadLine());
        
        Aposentadoria(montante, retirada, 0);
    }

    static void Aposentadoria(double montante, double retirada, double meses)
    {

        if(montante < retirada)
        {
            Console.WriteLine("Retirada completa!");
            Console.WriteLine($"Mês/Meses: {meses}");
            Console.WriteLine($"Montante restante corrigido: {montante}");
            return;
        }

        meses++;
        montante *= 1 + 0.055;
        Console.WriteLine($"Mês/Meses: {meses}");
        Console.WriteLine($"Montante corrigido: {montante}");


        Aposentadoria(montante - retirada, retirada, meses);
    }
}