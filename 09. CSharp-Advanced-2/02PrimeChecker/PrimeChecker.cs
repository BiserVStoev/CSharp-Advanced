using System;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        if (n == 0 || n == 1)
        {
            Console.WriteLine(false);
            return;
        }
        Console.WriteLine("{0}", CheckPrimeNumber(n));
    }
    private static bool CheckPrimeNumber(long n)
    {
        int i = 0;
        bool checkPrime = false;
        int sqrtN = (int)Math.Sqrt(n);
        for (i = 2; i <= sqrtN; i++)
        {
            if (n % i == 0)
            {
                checkPrime = false;
                break;
            }
        }
        if (i > sqrtN)
        {
            checkPrime = true;
        }
        return checkPrime;
    }
}