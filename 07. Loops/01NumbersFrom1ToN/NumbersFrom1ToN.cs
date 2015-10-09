using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        while (counter < n)
        {
            counter++;
            Console.Write("{0} ",counter);
        }
    }
}
