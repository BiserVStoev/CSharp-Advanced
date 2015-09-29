using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine(@"Enter side ""a"" of the trapezoid: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter side ""b"" of the trapezoid: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the trapezoid: ");
        double height = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * height;
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}
