class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite um numero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite um numero: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2 && n1> n3 && n2> n3)
        {
            Console.Write("{0}, {1}, {2}",n1,n2, n3);
        }
        else if (n1 > n3 && n1> n2 && n3 > n2)
        {
            Console.Write("{0}, {1}, {2}", n1, n3, n2);
        }
        else if (n2 > n1 && n2 > n3 && n1 > n3)
        {
            Console.Write("{0}, {1}, {2}",n2, n1, n3);
        }
        else if(n2 > n1 && n2 > n3 && n3 > n1)
        {
            Console.Write("{0}, {1}, {2}",n2, n3, n1);
        }
        else if(n3 > n1 && n3 > n2 && n1 > n2)
        {
            Console.Write("{0}, {1}, {2}", n3, n1, n2);
        }
        else if(n3 > n1 && n3> n2 && n2 >n1)
        {
            Console.Write("{0}, {1}, {2}", n3, n2, n1);
        }
    }
}