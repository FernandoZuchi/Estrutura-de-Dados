//  Dada uma tabela com as notas de uma turma de 20 alunos, faça funções que retornem: 
// a) A média da turma. 
// b) a quantidade de alunos aprovados (>=60)
// c) a quantidade de alunos reprovados.(< 60) 

class Program
{
    static void Main(string[] args)
    {
        // Tabela com as notas dos alunos (exemplo)
        int[] notas = { 75, 80, 45, 90, 60, 55, 70, 65, 85, 40, 95, 50, 78, 82, 63, 72, 68, 57, 87, 73 };

        // Chamando as funções e imprimindo os resultados
        Console.WriteLine($"Média da turma: {CalcularMedia(notas):0.##}");
        Console.WriteLine($"Quantidade de alunos aprovados: {QuantidadeAprovados(notas)}");
        Console.WriteLine($"Quantidade de alunos reprovados: {QuantidadeReprovados(notas)}");
    }

    // Função para calcular a média da turma
    static double CalcularMedia(int[] notas)
    {
        int total = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }

        return total / (notas.Length * 1.0);
    }

    // Função para contar a quantidade de alunos aprovados (nota >= 60)
    static int QuantidadeAprovados(int[] notas)
    {
        int count = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= 60)
            {
                count++;
            }
        }

        return count;
    }

    // Função para contar a quantidade de alunos reprovados (nota < 60)
    static int QuantidadeReprovados(int[] notas)
    {
        int count = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 60)
            {
                count++;
            }
        }

        return count;
    }
}