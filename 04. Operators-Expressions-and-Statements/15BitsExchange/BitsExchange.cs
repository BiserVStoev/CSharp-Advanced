using System;

class BitExchange
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        int mask = 7;
        int firstPos = 3;
        int secondPos = 24;

        long firstThree = (n >> firstPos) & mask;
        long secondThree = (n >> secondPos) & mask;

        n &= ~(mask << firstPos);
        n |= secondThree << firstPos;
        n &= ~(mask << secondPos);
        n |= firstThree << secondPos;
        Console.WriteLine(n);
    }
}

