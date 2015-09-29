using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine(@"Enter ""x"": ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter ""y"": ");
        double y = double.Parse(Console.ReadLine());
        bool isInside = ((x * x) + (y * y)) <= 2 * 2;
        Console.WriteLine(isInside);
    }
}
