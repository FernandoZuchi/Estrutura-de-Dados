// Calcular quantos anos serão necessários para que Zé seja maior que Chico:

class Program
{
    static void Main(string[] args)
    {
        double chicoAltura = 1.50;
        double zeAltura = 1.40;
        int anos = 0;

        while (zeAltura <= chicoAltura)
        {
            chicoAltura += 0.02; // Chico cresce 2 cm por ano
            zeAltura += 0.03;    // Zé cresce 3 cm por ano
            anos++;
        }

        Console.WriteLine($"Serão necessários {anos} anos para Zé ser maior que Chico.");
    }
}