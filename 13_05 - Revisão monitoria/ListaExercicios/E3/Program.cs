class Program
{
    static void Main()
    {
        string texto = "Teste 123";
        InverterMaiusculasMinusculas(texto);
    }

    static void InverterMaiusculasMinusculas(string texto)
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char c = texto[i];
            if (c >= 'A' && c <= 'Z') // Verifica se é maiúsculo
            {
                Convert.ToChar(c += ('a' - 'A')); // Converte para minúsculo
            }
            else if (c >= 'a' && c <= 'z') // Verifica se é minúsculo
            {
                Convert.ToChar(c -= ('a' - 'A')); // Converte para maiúsculo
            }
            Console.Write(c);
        }
        Console.WriteLine();
    }
}
