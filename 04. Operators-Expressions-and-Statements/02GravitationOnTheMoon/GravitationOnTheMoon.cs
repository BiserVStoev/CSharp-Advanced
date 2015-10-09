using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Your weight on the Moon is: " + weightOnMoon);
    }
}
