using System;
using System.Text.RegularExpressions;
class Program
{
    //[+d* \/-] Match all space and '-' between digits
    //\d*[+  -]\d*
    static void Main()
    {
        string input = Console.ReadLine();
        string patternWithSpace = @"[+]359 2 [1-9][1-9][1-9] [1-9][1-9][1-9][1-9]";
        string patternWithTire = @"[+]359-2-[1-9][1-9][1-9]-[1-9][1-9][1-9][1-9]";
        Regex regex = new Regex(patternWithSpace);
        Regex regexTwo = new Regex(patternWithTire);
        while (input != "end")
        {
            if (input.Length <= 15)
            {
                Match match = regex.Match(input);
                Match matchTwo = regexTwo.Match(input);
                if (match.Length > 0)
                {
                    Console.Write(match.Groups[0]);
                    Console.WriteLine();
                }
                if (matchTwo.Length > 0)
                {
                    Console.WriteLine(matchTwo.Groups[0]);
                    Console.WriteLine();
                }
            }

            input = Console.ReadLine();
        }


    }
}

