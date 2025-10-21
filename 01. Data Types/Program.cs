using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        string input = Console.ReadLine();

        PrintResult(type, input);
    }

    static void PrintResult(string type, string input)
    {
        if (type == "int")
        {
            int number = int.Parse(input);
            Console.WriteLine(number * 2);
        }
        else if (type == "real")
        {
            double number = double.Parse(input);
            Console.WriteLine($"{number * 1.5:F2}");
        }
        else if (type == "string")
        {
            Console.WriteLine($"${input}$");
        }
    }
}