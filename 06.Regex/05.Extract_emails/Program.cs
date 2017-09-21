using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
       var text = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        const string MatchEmailPattern =
       @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
       + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
       + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
        Regex rx = new Regex(MatchEmailPattern);
        // Find matches.
        foreach (var item in text)
        {
            var matches = rx.Matches(item);
            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
        
        // Report the number of matches found.
      
        // Report on each match.
        
    }
}

