using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double and 3for string: ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Please enter an int: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string a = Console.ReadLine();
                Console.WriteLine(a + "*");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

    }

}