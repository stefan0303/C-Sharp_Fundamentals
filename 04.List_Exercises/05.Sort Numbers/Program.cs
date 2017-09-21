using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        var numbers = new List<decimal>();
        foreach (decimal num in nums)
        {
            numbers.Add(num);
        }
        numbers.Sort();
        Console.WriteLine(string.Join(" <= ", numbers));
    }
}

