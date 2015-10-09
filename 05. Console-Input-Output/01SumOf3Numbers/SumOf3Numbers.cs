using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}", a + b + c);
    }
}
