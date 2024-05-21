// Calcular a média ponderada das notas de um aluno e determinar se ele foi aprovado ou reprovado:

class Program
{
    static void Main(string[] args)
    {
        int matricula;
        double nota1, nota2, nota3;

        do
        {
            Console.WriteLine("Digite a matrícula do aluno (ou um número negativo para sair):");
            matricula = Convert.ToInt32(Console.ReadLine());

            if (matricula < 0)
                break;

            Console.WriteLine("Digite as três notas do aluno:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * 4 + nota2 * 3 + nota3 * 3) / 10;

            Console.WriteLine($"A média ponderada do aluno é {media}");

            if (media >= 5)
                Console.WriteLine("APROVADO");
            else
                Console.WriteLine("REPROVADO");

        } while (matricula >= 0);
    }
}
