class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite o segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite o terceiro numero: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        maiorParaMenor(num1,num2,num3);
    }
    static void maiorParaMenor(int num1, int num2, int num3)
    {      
        int maior, meio, menor;  

        // Verifica qual é o maior número
        if(num1 >= num2 && num1 >= num3)
        {
            maior = num1;

            // Verifica qual é o número do meio
            if(num2 >= num3)
            {
                meio = num2;
            }
            else
            {
                meio = num3;
            }

            // Verificando o número que sobrou para confirmar se é o menor
            if(num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }
        }
        else if(num2 >= num1 && num2 >= num3)
        {
            maior = num2;

            // Verifica qual é o número do meio
            if(num1 >= num3)
            {
                meio = num1;
            }
            else
            {
                meio = num3;
            }


            // Verificando o número que sobrou para confirmar se é o menor
            if(num1 <= num3)
            {
                menor = num1;
            }
            else
            {
                menor = num3;
            }
        }
        else
        {
            maior = num3;

            // Verifica qual é o número do meio
            if(num1 >= num2)
            {
                meio = num1;
            }
            else
            {
                meio = num2;
            }


            // Verificando o número que sobrou para confirmar se é o menor
            if(num1 <= num2)
            {
                menor = num1;
            }
            else
            {
                menor = num2;
            }
        }
        // ORDEM DECRESCENTE
        Console.WriteLine("Números em ordem decrescente: {0},{1},{2}",maior,meio,menor);
    }
}