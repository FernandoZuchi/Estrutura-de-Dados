class Program
{
    // Dado um vetor V ordenado com n posições reais, criar um algoritmo para retornar a posição de um valor x no vetor V através da realização de uma busca binária recursiva
    static void Main(string[] args)
    {
        int[] vet = {1, 2, 3, 5, 8, 13, 21, 34}; 
        int pos = BuscaBinaria(vet, 13); // Ou seja, quero encontrar o elemento de valor 5 no vetor
        Console.WriteLine(pos);
        // E quero saber o índice dele (Este é o valor da variável "chave")
    }
    static int BuscaB(int[] v, int ini, int fim, int x)
    {
        int meio = (ini + fim) / 2; // Ponto médio - Delimita entre quais indices fazemos a busca
        if(v[meio] == x) return meio; // Pegar um ponto médio - Retorna o índice desejado
        if(ini == fim) return -1; // Significa que chegou ao final da busca
        if(v[meio] > x) // Busca na primeira metade - X estaria a esquerda do índice meio
            return BuscaB(v, ini, meio - 1, x); // Buscar da posição inicial até meio - 1
        else
            return BuscaB(v, meio + 1, fim, x); // Buscar a partir do meio até o final do vetor
    }
    static int BuscaBinaria(int[] v, int chave)
    {
        // v é um vetor
        // Será retornado k tal qual que (v[k] == chave)
        // Ou -1 caso contrário

        return BuscaB(v,0,v.Length-1,chave); // Faz a busca binária de chave no vetor no intervalo 0 a v.
        // Ou seja, procurar a chave entre a posição zero e a última posição do vetor
    }
}
