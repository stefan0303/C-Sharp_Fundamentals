using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbers = new List<int>();
        foreach (var num in nums)
        {
            numbers.Add(num);
        }
        int count = 1;
        int maxcount = 0;

        int beststart = 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == numbers.Count - 1)
            {
                break;
            }
            else if (numbers[i] == numbers[i + 1])
            {
                count = count + 1;

                if (count > maxcount)
                {
                    maxcount = count;
                    beststart = numbers[i];
                }
            }
            else if (numbers[i] != numbers[i + 1])
            {
                count = 1;
            }
        }
        if (beststart == 1)
        {
            Console.WriteLine(numbers[0]);
        }
        for (int i = 0; i < maxcount; i++)
        {
            Console.Write(beststart + " ");
        }
    }
}

