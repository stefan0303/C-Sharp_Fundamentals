using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int difference = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int r = i; r < numbers.Length; r++)
            {
                if (Math.Abs(Math.Abs(numbers[i]) - Math.Abs(numbers[r])) == difference)
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}

