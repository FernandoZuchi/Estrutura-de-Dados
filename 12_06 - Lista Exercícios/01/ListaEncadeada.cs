class ListaEncadeada
{
    No primeiro = new No();
    public void AdicionarInicio(int valor)
    {
        No novo = new No {Valor = valor};

        if(primeiro == null)
            primeiro = novo;
        else
        {
            novo.Proximo = primeiro;
            primeiro = novo;
        }
    }

    public void AdicionarFinal(int valor)
    {
        No novo = new No {Valor = valor};

        if()
    }

    public void RemoverInicio()
    {

    }

    public void RemoverFinal()
    {

    }
}