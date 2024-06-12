class Program
{
    static void Main()
    {
        Pilha pilha = new Pilha();

        pilha.Empilhar(1);
        pilha.Empilhar(2);
        pilha.Empilhar(3);
        Imprime(pilha);
    }

    static void Imprime(Pilha<T> pilha)
    {
        No aux = pilha.Topo;

        while (aux != null)
        {
            Console.WriteLine("{0}", aux.Valor);
            aux = aux.Proximo;
        }
    }
}