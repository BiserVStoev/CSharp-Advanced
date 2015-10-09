using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine(@"Enter positive integer ""n<=100"": ");
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        bool isPrime = true;
        if (n >= 1)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
