using System;

class NumbersFrom1Ton
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

