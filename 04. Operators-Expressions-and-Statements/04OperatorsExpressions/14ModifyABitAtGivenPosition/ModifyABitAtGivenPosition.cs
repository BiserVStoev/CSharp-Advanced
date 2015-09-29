using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter ""p"": ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter ""v""(0/1): ");
        int v = int.Parse(Console.ReadLine());
        if (v == 0) 
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
        else 
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }

    }
}
