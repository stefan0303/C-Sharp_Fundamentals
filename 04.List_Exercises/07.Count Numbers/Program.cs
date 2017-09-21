using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbers = new List<int>();
        foreach (int num in nums)
        {
            numbers.Add(num);
        }
        numbers.Sort();

        int count = 1;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == numbers.Count - 1)
            {
                Console.WriteLine(numbers[i] + " -> " + count);
            }
            else if (numbers[i] == numbers[i + 1])
            {
                count = count + 1;

            }
            else if ((numbers[i] != numbers[i + 1]))
            {
                Console.WriteLine(numbers[i] + " -> " + count);
                count = 1;
            }

        }

    }
}
