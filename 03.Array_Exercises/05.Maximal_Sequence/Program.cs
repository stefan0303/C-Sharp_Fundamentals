using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int countCurrentSequence = 0;

        int countMaxSequence = 0;
        int startMaxSequence = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] - numbers[i - 1] >= 1)
            {
                countCurrentSequence++;
                var startCurrentSequence = i - countCurrentSequence;

                if (countCurrentSequence > countMaxSequence)
                {
                    countMaxSequence = countCurrentSequence;
                    startMaxSequence = startCurrentSequence;
                }
            }
            else
            {
                countCurrentSequence = 0;
            }
        }

        for (int i = startMaxSequence; i <= (startMaxSequence + countMaxSequence); i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}

