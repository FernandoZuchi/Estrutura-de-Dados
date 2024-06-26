class ListaContigua2
{
    public ListaContigua2()
    {
        indiceIni = valores.Length / 2;
        indiceFim = indiceIni - 1;
    }

    public void AdicionarNoInicio(double valor)
    {
        if (indiceIni == 0)
            throw new Exception("Não é possível adicionar mais elementos ao início.");

        valores[--indiceIni] = valor;
    }
    
    public void AdicionarNoFinal(double valor)
    {
        if (indiceFim == valores.Length - 1)
            throw new Exception("Não é possível adicionar mais elementos no final.");

        valores[++indiceFim] = valor;
    }

    public void RemoverNoInicio()
    {
        if (Tamanho == 0)
            throw new Exception("Não existe elemento a ser removido.");
        
        indiceIni++;
    }

    public void RemoverNoFinal()
    {
        if (Tamanho == 0)
            throw new Exception("Não existe elemento a ser removido.");
        
        indiceFim--;
    }

    public double Get(int indice)
    {
        if (indice < 0 || indice >= Tamanho)
            throw new Exception("Índice inválido!");

        return valores[indiceIni + indice];
    }

    public int Tamanho { get => indiceFim - indiceIni + 1; }

    private int indiceIni;
    private int indiceFim;
    private double[] valores = new double[100];
}