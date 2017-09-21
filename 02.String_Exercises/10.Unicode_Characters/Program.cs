using System;


class Program
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        foreach (var letter in input)
        {
            string escape = "\\u" + ((int)letter).ToString("x").PadLeft(4, '0');
            Console.Write(escape);
        }
        Console.WriteLine();
    }
}

