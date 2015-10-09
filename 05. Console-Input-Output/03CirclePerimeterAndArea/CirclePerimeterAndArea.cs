using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of a circle: ");
        double r = double.Parse(Console.ReadLine());
        double a = Math.PI * r * r;
        double p = 2 * Math.PI * r;
        Console.WriteLine("The perimeter of the circle is: {0:F2}", p);
        Console.WriteLine("The area of the circle is: {0:F2}", a);
    }
}