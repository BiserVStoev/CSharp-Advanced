using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter integer 1<n<100:");
        int n = int.Parse(Console.ReadLine());
        BigInteger Factorial2N = 1;
        BigInteger FactorialN = 1;
        BigInteger FactorialNPlus1 = 1;
        if (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i <= 2 * n; i++) 
            {
                Factorial2N *= i;
                if (i <= n)
                {
                    FactorialN *= i;
                }
            }
            for (int i = 1; i <= n+1; i++)
            {
                FactorialNPlus1 *= i;
            }
            Console.WriteLine("{0}", Factorial2N/(FactorialNPlus1*FactorialN));
        }
    }
}
