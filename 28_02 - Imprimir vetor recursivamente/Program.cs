internal class Program
{
    private static void Main(string[] args)
    {
        //Faça um procedimento recursivo que receba um vetor de inteiros e imprima todos os elementos desse vetor Procedimento recursivo = Chama a si próprio
        var vetor = new int[] {1, 2, 4, 5};

        ImprimirVetorRecursivo(vetor, 0);
    }

    static void ImprimirVetorRecursivo(int[] vetor,int indice){
        if(indice < vetor.Length){
            System.Console.WriteLine(vetor[indice]);
            ImprimirVetorRecursivo(vetor, indice + 1);
        }
    }
} 