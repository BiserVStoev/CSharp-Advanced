using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        Console.WriteLine("Enter integers n and k in the range (1<k<n<100): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNMinusK = 1;
        if (k < 1 || k > n || n > 100)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK *= i;
            }
            for (int i = 1; i <= n-k; i++)
            {
                factorialNMinusK *= i;
            }
            Console.WriteLine("{0}", factorialN/(factorialK*factorialNMinusK));
        }
    }
}
