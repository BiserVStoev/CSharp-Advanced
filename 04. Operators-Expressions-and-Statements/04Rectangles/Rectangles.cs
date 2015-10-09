using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("The perimeter is: " + perimeter);
        Console.WriteLine("The area is: " + area);
    }
}
