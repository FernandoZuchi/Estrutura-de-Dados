using System.ComponentModel;

namespace Aula06;

class Program
{
    static void Main(string[] args)
    {
        var lista = new ListaContigua();

        lista.AdicionarNoFinal(7);
        lista.AdicionarNoFinal(10);
        lista.AdicionarNoFinal(5);

        Imprimir(lista);

        lista.RemoverNoFinal();

        Imprimir(lista);
    }

    static void Imprimir(ListaContigua lista)
    {
        for (int i = 0; i < lista.Tamanho; i++)
        {
            Console.Write($"{lista.Get(i)}  ");
        }

        Console.WriteLine();
    }
}
