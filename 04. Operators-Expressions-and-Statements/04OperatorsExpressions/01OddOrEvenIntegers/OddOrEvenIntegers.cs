using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Write an integer: ");
        int n = int.Parse(Console.ReadLine());
        bool isEven = n % 2 == 0;
        Console.WriteLine(isEven);
    }
}
