class Program
{
    // Faça uma função recursiva que recebe um número inteiro por parâmetro e retorne true se o número for um número perfeito e false caso contrário. Um número perfeito é um número natural para o qual a soma de todos os seus divisores naturais próprio é igual ao próprio número
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro");
        int num = Convert.ToInt32(Console.ReadLine());
        int divisor = 1;

        if (Perfeito(num, divisor, 0))
        {
            Console.WriteLine($"O número {num} é perfeito!");
        }
        else
        {
            Console.WriteLine($"O número {num} não é perfeito!");
        }
    }

    static bool Perfeito(int num, int divisor, int soma)
    {
        // Condição de parada, divisor percorreu até o número
        // Chegando na condição de parada ele retorna se a soma é igual ao número (sim = true) || (não = false)
        if (divisor == num)
            return soma == num;

        // Validação recursiva para verificar os divisores do num, se for divisível, acumula na variável soma
        if (num % divisor == 0)
            soma += divisor;

        
        // Chamada recursiva, caso não tenha entrado na condição de parada, chama o procedimento agora passando o próximo divisor como parâmetro
        return Perfeito(num, divisor + 1, soma);


    }
}