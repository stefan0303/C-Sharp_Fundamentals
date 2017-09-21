using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        for (int i = 1; i < nums.Count; i++) //ot purvata do predposlednata cifra
        {
            if (nums[i - 1] == nums[i])
            {
                nums[i - 1] = nums[i - 1] + nums[i];
                nums.RemoveAt(i);
                i = i - 2;            //moje i prosto i=0  
                if (i < 0)      //da ne izliza ot granicite na listat
                    i = 0;

            }
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}

