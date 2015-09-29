using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal integer:");
        string hexadecimal = Console.ReadLine();
        int num = 0;
        long hexNum = 0;
        long degree = hexadecimal.Length - 1;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            char ch = hexadecimal[i];
            switch (ch.ToString())
            {
                case "A": num = 10;
                    break;
                case "B": num = 11;
                    break;
                case "C": num = 12;
                    break;
                case "D": num = 13;
                    break;
                case "E": num = 14;
                    break;
                case "F": num = 15;
                    break;
                default: num = Convert.ToInt32(ch.ToString());
                    break;
            }
            hexNum += num * (long)Math.Pow(16, degree);
            degree--;
        }
        Console.WriteLine("{0}", hexNum);
    }
}