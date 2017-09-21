using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string[] sentence = Console.ReadLine().Split(' ').ToArray();
        char[] wordOne = sentence[0].ToCharArray();
        char[] wordTwo = sentence[1].ToCharArray();

        int maxValue = Math.Max(wordTwo.Length, wordOne.Length);

        int result = 0;
        for (int i = 0; i < maxValue; i++)
        {
            if (i > wordOne.Length - 1)
            {
                result = result + wordTwo[i];
            }
            else if (i > wordTwo.Length - 1)
            {
                result = result + wordOne[i];
            }
            else
            {
                result = result + (wordOne[i] * wordTwo[i]);
            }
        }
        Console.WriteLine(result);
    }
}
