using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        numbers.Sort();
        numbers.Reverse();

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
        }
        decimal average = (decimal)sum / numbers.Count;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > average && i < 5)
            {
                Console.Write(numbers[i] + " ");
            }
            else if (numbers[i] >= average && i == numbers.Count - 1)
            {
                Console.WriteLine("No");
            }
        }
        Console.WriteLine();
    }
}

