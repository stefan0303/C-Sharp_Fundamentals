using System;

class Program
{
    static void Main()
    {
        char[] inputSentence = Console.ReadLine().ToCharArray();
        for (int i = 0; i < 20; i++)
        {
            if (i >= inputSentence.Length)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write(inputSentence[i]);
            }
        }
        Console.WriteLine();
    }
}

