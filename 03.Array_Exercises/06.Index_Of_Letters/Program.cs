using System;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        for (int i = 0; i < input.Length; i++)
        {
            for (int r = 0; r < alphabet.Length; r++)
            {
                if (input[i] == alphabet[r])
                {
                    Console.WriteLine($"{input[i]} -> {r}");
                }
            }
        }
    }
}

