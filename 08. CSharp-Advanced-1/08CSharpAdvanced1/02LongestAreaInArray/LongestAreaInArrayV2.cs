using System;

    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("N should be integer, stupid!!!");
                Environment.Exit(1);
            }

            string[] numbers = new string[n];
            int count = 0;
            int biggestCount = 0;
            string resultStr = "";
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();

                if (i == 0)
                {
                    count++;
                    continue;
                }

                if (numbers[i].Equals(numbers[i - 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > biggestCount)
                {
                    biggestCount = count;
                    resultStr = numbers[i];
                }
            }

            Console.WriteLine(biggestCount);
            for (int i = 0; i < biggestCount; i++)
            {
                Console.WriteLine(resultStr);
            }
        }
    }