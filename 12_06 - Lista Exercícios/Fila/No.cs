class No<T>
{
    private T? valor;
    private No<T> proximo = null;

    public No<T> Proximo
    {
        get{return proximo;}
        set{valor = value;}
    }

    public No<T> Proximo
    {
        get{return proximo;}
        set{valor = value};
    }
}