using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] < 0)
                nums.RemoveAt(i);
            i--;               //ako ima dve ili poveshe posledovatelni otricatelni chisla
        }
        nums.Reverse();
        if (nums.Count <= 0)
        {
            Console.WriteLine("empty");
        }
        else if (nums.Count > 0)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

