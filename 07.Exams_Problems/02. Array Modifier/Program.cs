using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        List<string> command = Console.ReadLine().Split(' ').ToList();

        while (command[0] != "End")
        {
            if (command[0] == "decrease")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] = numbers[i] - 1;
                }
            }
            long number;
            if (command[0] == "swap")
            {
                int first = (Convert.ToInt32((command[1])));
                int second = (Convert.ToInt32(command[2]));
                number = numbers[first];
                numbers[first] = numbers[second];
                numbers[second] = number;
            }
            if (command[0] == "multiply")
            {
                int first = (Convert.ToInt32((command[1])));
                int second = (Convert.ToInt32(command[2]));
                numbers[first] = numbers[second] * numbers[first];
            }

            command = Console.ReadLine().Split(' ').ToList();
            if (command[0] == "end")
            {
                break;
            }
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}

