using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        long n = long.Parse(Console.ReadLine());
        string binary = "";
        long result = 0;
        while (n != 0)
        {
            int remain = (int)n % 2;
            n /= 2;
            binary = remain + binary;
        }
        Console.WriteLine(binary);
    }
}
