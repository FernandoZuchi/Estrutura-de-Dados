class Pilha<T>
{
    private No<T> topo = null;
    public No<T> Topo => topo;

    public void Empilhar(T valor)
    {
        var novo = new No{ valor = valor };

        novo.Proximo = topo;
        topo = novo;
    }

    public void Desempilhar()
    {
        if(topo == null)
            throw new Exception("Pilha vazia!");

        topo = topo.Proximo;
    }
}