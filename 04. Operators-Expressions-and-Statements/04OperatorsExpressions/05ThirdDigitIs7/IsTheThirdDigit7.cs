using System;

class IsTheThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Write an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool thirdDigit = (number / 100) % 10 == 7;
        Console.WriteLine(thirdDigit);
    }
}
