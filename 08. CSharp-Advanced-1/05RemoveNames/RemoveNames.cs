using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> namesOne = new List<string>();
        Console.WriteLine("Enter the first set of names:");
        string[] firstNames = Console.ReadLine().Split();
        for (int i = 0; i < firstNames.Length; i++)
        {
            namesOne.Add(firstNames[i]);
        }
        List<string> namesTwo = new List<string>();
        Console.WriteLine("Enter the second set of names:");
        string[] secondNames = Console.ReadLine().Split();
        for (int i = 0; i < secondNames.Length; i++)
        {
            namesTwo.Add(secondNames[i]);
        }
        List<string> namesGeneral = new List<string>();
        foreach (var name in namesOne)
        {
            if (namesTwo.Contains(name))
            {
                continue;
            }
            else
            {
                namesGeneral.Add(name);
            }
        }
        foreach (var name in namesGeneral)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();
    }
}
