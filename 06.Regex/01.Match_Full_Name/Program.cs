using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
        Regex regex = new Regex(pattern);
        List<string> output = new List<string>();
        while (input != "end")
        {

            Match match = regex.Match(input);
            if (match.Length > 0)
            {
                output.Add(match.Groups[0].ToString());
            }


            input = Console.ReadLine();
        }
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}

