class ListaEncadeada
{
    // Referência para o primeiro nó da lista
    private No? primeiro = null;

    // Método get para acessar o primeiro nó
    public No? Primeiro
    {
        get { return primeiro; }
    }

    // Método para adicionar um novo nó(valor) no início da lista
    public void AdicionarNoInicio(int valor)
    {
        // Cria um novo nó e atribui o valor fornecido utilzizando o set(novo.Valor)
        No novo = new No();
        novo.Valor = valor;

        // Se a lista estiver vazia, o novo nó se torna o primeiro
        if (primeiro == null)
            primeiro = novo;
        else
        {
            // Caso contrário, o novo nó aponta para o atual primeiro nó
            novo.Proximo = primeiro;
            // E o novo nó se torna o primeiro nó da lista
            primeiro = novo;
        }
    }

    // Método para adicionar um novo nó no final da lista
    public void AdicionarNoFinal(int valor)
    {
        // Cria um novo nó e atribui o valor fornecido
        No novo = new No();
        novo.Valor = valor;

        // Se a lista estiver vazia, o novo nó se torna o primeiro
        if (primeiro == null)
            primeiro = novo;
        else
        {
            // Caso contrário, percorre a lista até encontrar o último nó
            No aux = primeiro;
            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }
            // O último nó passa a apontar para o novo nó
            aux.Proximo = novo;
        }
    }

    // Método para remover o primeiro nó da lista
    public void RemoverNoInicio()
    {
        // Lança uma exceção se a lista estiver vazia
        if (primeiro == null)
            throw new Exception("Lista vazia!");

        // Se houver apenas um nó, a lista fica vazia
        if (primeiro.Proximo == null)
            primeiro = null;
        else
        {
            // Caso contrário, o segundo nó se torna o primeiro
            primeiro = primeiro.Proximo;
        }
    }

    // Método para remover o último nó da lista
    public void RemoverNoFinal()
    {
        // Lança uma exceção se a lista estiver vazia
        if (primeiro == null)
            throw new Exception("Lista vazia");

        // Se houver apenas um nó, a lista fica vazia
        if (primeiro.Proximo == null)
            primeiro = null;
        else
        {
            // Caso contrário, percorre a lista até encontrar o penúltimo nó
            No aux = primeiro;
            while (aux?.Proximo?.Proximo != null)
                aux = aux.Proximo;

            // O penúltimo nó passa a não apontar para mais ninguém
            aux.Proximo = null;
        }
    }
}
