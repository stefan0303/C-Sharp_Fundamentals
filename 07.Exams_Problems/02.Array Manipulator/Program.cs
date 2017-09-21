using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> list = new List<int>();
        foreach (var num in nums)
        {
            list.Add(num);
        }

        string[] command = Console.ReadLine().Split(' ');


        while (command[0] != "print")
        {
            switch (command[0])
            {
                case "add":
                    Add(list, command);
                    break;
                case "addMany":
                    addMany(list, command);
                    break;
                case "contains":
                    contains(list, command);
                    break;
                case "remove":
                    Remove(list, command);
                    break;
                case "shift":
                    Shifting(list, command);
                    break;
                case "sumPairs":
                    list = SumPairs(list);
                    break;
            }

            command = Console.ReadLine().Split();
        }
        Console.WriteLine("[" + string.Join(", ", list) + "]");
    }

    private static List<int> SumPairs(List<int> list)
    {
        List<int> distinct = new List<int>();
        foreach (var item in list)
        {
            distinct.Add(item);
        }
        for (int i = 0; i < list.Count() / 2; i++)
        {
            distinct[i] = distinct[i] + distinct[i + 1];
            distinct.RemoveAt(i + 1);
        }

        list = distinct;
        return list;
    }

    private static void Remove(List<int> list, string[] command)
    {
        int removed = int.Parse(command[1]);
        list.RemoveAt(removed);
    }

    private static void Add(List<int> list, string[] command)
    {
        int index = int.Parse(command[1]);
        int inserted = int.Parse(command[2]);
        list.Insert(index, inserted);
    }

    private static void addMany(List<int> nums, string[] command)
    {
        int index = int.Parse(command[1]);
        for (int i = command.Length - 1; i >= 2; i--)
        {
            int element = int.Parse(command[i]);
            nums.Insert(index, element);
        }
    }

    private static void contains(List<int> nums, string[] commands)
    {
        int element = int.Parse(commands[1]);
        if (nums.Contains(element))
        {
            Console.WriteLine(nums.IndexOf(element));
        }
        else Console.WriteLine("-1");
    }

    private static void Shifting(List<int> nums, string[] commands)
    {
        int numberOfPositions = int.Parse(commands[1]);
        while (numberOfPositions > 0)
        {
            int first = nums[0];
            nums.RemoveAt(0);
            nums.Add(first);
            numberOfPositions--;
        }
    }
}
