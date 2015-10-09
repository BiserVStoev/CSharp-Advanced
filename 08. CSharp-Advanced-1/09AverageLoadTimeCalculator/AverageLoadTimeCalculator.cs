using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        Console.WriteLine("Write next report: ");
        string line = Console.ReadLine();
        Dictionary<string, double> sites = new Dictionary<string, double>();
        Dictionary<string, int> counters = new Dictionary<string, int>();
        int counter = 1;
        while (line != string.Empty)
        {
            string[] list = line.Split(' ');
            string link = list[2];
            double loadTime = double.Parse(list[3]);

            if (!sites.Keys.Contains(link))
            {
                sites[link] = loadTime; counters.Add(link, 1);
            }
            else
            {
                counters[link] += 1;
                sites[link] = sites[link] + loadTime;
            }
            Console.WriteLine("Write next report:");
            line = Console.ReadLine();
        }
        foreach (string link in sites.Keys)
        {
            Console.WriteLine("{0} = {1:F7}", link, sites[link] / counters[link]);
        }

    }
}

