using System;
using System.Numerics;
class Calculate2
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        if (n < 100 && k < n && k > 1)
        {
            BigInteger result = 1;
            for (int i = n; i > k; i--)
            {
                result *= i;
            }
            Console.WriteLine("The result of the divison is: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        Console.WriteLine();
    }
}
