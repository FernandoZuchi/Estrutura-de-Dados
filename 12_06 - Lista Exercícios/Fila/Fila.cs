class Fila<T>
{
    private No<T>? inicio = null;
    private No<T>? final = null;

    public No<T>? Inicio => inicio;

    public void Adicionar(T valor)
    {
        var novo = new No<T>{valor = valor };

        if(final = null)
            final = inicio = novo;
        else
        {
            final.Proximo = novo;
            final = novo;
        }
    }

    public void Remover()
    {
        if(inicio == null)
            throw new Exception("Fila vazia!");
        
        inicio = inicio.Proximo;

        if(inicio == null)
            final = null;
    }
}