using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime CurrentDate = DateTime.Now;
        Console.Write("Please enter your birthday: ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        System.TimeSpan ageNow = CurrentDate - birthday;
        double yourAge = ageNow.TotalDays / 365.25;
        Console.WriteLine("Your age now is: " + ((int)yourAge));
        Console.WriteLine("Your age in 10 years will be: " + ((int)yourAge + 10));
    }
}
