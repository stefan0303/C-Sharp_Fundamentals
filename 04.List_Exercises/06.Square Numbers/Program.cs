using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
        var numbers = new List<int>();
        foreach (int num in nums)
        {
            if (Math.Sqrt(num) == (int)Math.Sqrt(num))
            {
                numbers.Add(num);
            }

        }
        numbers.Sort();
        numbers.Reverse();
        Console.WriteLine(string.Join(" ", numbers));
    }
}
