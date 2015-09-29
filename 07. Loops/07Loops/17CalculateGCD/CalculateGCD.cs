using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter integer a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer b:");
        int b = int.Parse(Console.ReadLine());
        int remainder = 1;
        while (remainder !=0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        Console.WriteLine(a);
    }
}
