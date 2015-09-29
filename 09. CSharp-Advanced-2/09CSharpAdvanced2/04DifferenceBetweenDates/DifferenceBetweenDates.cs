using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter the first date:");
        string firstDateAsString = Console.ReadLine();
        Console.WriteLine("Enter the second date:");
        string secondDateAsString = Console.ReadLine();
        string format = "d.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(firstDateAsString, format, 
        CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondDateAsString, format,
        CultureInfo.InvariantCulture);
        int differenceInDays = CalcDifferenceBetweenDates(firstDate, secondDate);
        Console.WriteLine(differenceInDays);
    }
    static int CalcDifferenceBetweenDates(DateTime firstDate, DateTime secondDate) 
    {
        TimeSpan ts = secondDate - firstDate;
        int differance = ts.Days;
        return differance;
    }
}
