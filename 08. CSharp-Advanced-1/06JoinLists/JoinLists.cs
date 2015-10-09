using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        List<string> numbersOneList = new List<string>();
        Console.WriteLine("Enter first set of numbers:");
        string[] firstNumbers = Console.ReadLine().Split();
        for (int i = 0; i < firstNumbers.Length; i++)
        {
            numbersOneList.Add(firstNumbers[i]);
        }
        List<string> numbersTwoList = new List<string>();
        Console.WriteLine("Enter second set of numbers:");
        string[] secondNumbers = Console.ReadLine().Split();
        for (int i = 0; i < secondNumbers.Length; i++)
        {
            numbersTwoList.Add(secondNumbers[i]);
        }
        for (int i = 0; i < firstNumbers.Length; i++)
        {
            if (!numbersTwoList.Contains(firstNumbers[i]))
            {
                numbersTwoList.Add(firstNumbers[i]);
            }
            else
            {
                continue;
            }
        }
        numbersTwoList.Sort();
        foreach (var number in numbersTwoList)
        {
            Console.Write("{0} ", number);
        }
    }
}
