using System;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
