using System;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int n = int.Parse(Console.ReadLine());
        int trailingZeros = 0;
        int k = 0;
        while (Math.Pow(5, k) < n)
        {
            k++;
            trailingZeros += n / (int)(Math.Pow(5, k));
        }
        Console.WriteLine(trailingZeros);
    }
}
