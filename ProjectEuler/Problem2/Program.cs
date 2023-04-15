internal class Program
{
    private static void Main(string[] args)
    {
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine(Fibonacci(1, 2, limit));
        Console.WriteLine(Fibonacci(limit));        
    }

    // My solution.
    public static int Fibonacci(int n1, int n2, int limit)
    {
        int sum = 0;

        if (n1 < limit && n2 < limit)
        {
            int n3 = n1 + n2;
            int n4 = n2 + n3;

            sum += n1 + n2;
            sum += Fibonacci(n3, n4, limit);
            if (n1 % 2 != 0)
                sum -= n1;

            if (n2 % 2 != 0)
                sum -= n2;
        }
        else
            sum = 0;
        return sum;
    }

    // Official solution.
    private static int Fibonacci(int limit)
    {
        int sum = 0;
        int a = 1;
        int b = 1;
        int c = a + b;

        while (c < limit) 
        {
            sum += c;
            a = b + c;
            b = c + a;
            c = a + b;
        }

        return sum;
    }

}