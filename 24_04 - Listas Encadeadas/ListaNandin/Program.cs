class Program
{
    static void Main(string[] args)
    {
        ListaEncadeada lista = new ListaEncadeada();
        lista.AdicionarNoInicio(3);
        lista.AdicionarNoInicio(2);
        lista.AdicionarNoInicio(1);
        lista.AdicionarNoFinal(4);
        lista.AdicionarNoFinal(4);
        lista.RemoverNoInicio();
        lista.RemoverNoFinal();
        Imprime(lista);
    }

    static void Imprime(ListaEncadeada lista)
    {
        // Ponteiro auxiliar para percorrer a lista
        No? aux = lista.Primeiro;

        // Percorre a lista até encontrar o final
        while (aux != null)
        {
            // Imprime o valor do nó atual
            Console.Write("{0} ", aux.Valor);
            // Avança para o próximo nó
            aux = aux.Proximo;
        }
    }
}
