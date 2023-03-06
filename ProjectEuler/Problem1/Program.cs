internal class Program
{
    private static void Main(string[] args)
    {
        //int sum = 0;
        //for (int i = 0; i < 1000; i++)
        //{
        //    if(i % 3 == 0 || i % 5 == 0)
        //    {
        //        sum += i;
        //    }
        //}
        //Console.WriteLine(sum);

        int limit = 999;
        int result = SumDividedBy(3, limit)
            + SumDividedBy(5, limit)
            - SumDividedBy(15, limit);

        Console.WriteLine(result);
    }

    private static int SumDividedBy(int n, int limit)
    {
        int p = limit / n;
        return n * (p * (p + 1)) / 2;
    }
}