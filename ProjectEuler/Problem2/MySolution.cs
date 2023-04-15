internal class MySolution
{
    private static void Main(string[] args)
    {
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine(Fibonacci(1, 2, limit));

    }

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

}