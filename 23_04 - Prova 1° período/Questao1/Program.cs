class Program
{
    //Faça um programa que leia números inteiros e conte quantos números terão nos intervalos:
    //0 a 9
    //10 a 99
    //100 a 999
    //Maiores que 100
    static void Main(string[] args)
    {
        int numero = 0;
        int contador09 = 0;
        int contador1099 = 0;
        int contador100a999 = 0;
        int contador1000 = 0;

        while (numero >= 0)
        {
            Console.Write("Digite um numero (negativo para sair): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                contador09++;
            }
            if (numero >= 10 && numero <= 99)
            {
                contador1099++;
            }
            if (numero >= 100 && numero <= 999)
            {
                contador100a999++;
            }
            if (numero >= 1000)
            {
                contador1000++;
            }
        }
        Console.Write("Foram digitados {0} numeros de 0 a 9, {1} numeros de 10 a 99, {2} numeros de 100 a 999 e {3} numeros acima de 1000.", contador09, contador1099, contador100a999, contador1000);
    }
}
