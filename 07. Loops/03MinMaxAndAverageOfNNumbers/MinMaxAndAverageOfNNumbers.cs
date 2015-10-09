using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter length of loop: ");
        int length = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < length; i++)
        {
            int number = int.Parse(Console.ReadLine());
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
            avg = sum / length;
        }

        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:F2}", avg);
    }
}
