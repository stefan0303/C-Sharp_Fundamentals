using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var remove = new string[] { "@", "#", "$", "&" };
        Dictionary<string, int> countries = new Dictionary<string, int>();
        SortedDictionary<string, decimal> cityes = new SortedDictionary<string, decimal>();

        while (input != "stop")
        {
            foreach (var c in remove)
            {
                input = input.Replace(c, string.Empty);
            }
            List<string> sentence = input.Split('\\').ToList();
            var removeTwo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "@", "#", "&" };

            foreach (var m in removeTwo)
            {
                sentence[1] = sentence[1].Replace(m, "");
                sentence[0] = sentence[0].Replace(m, "");
            }

            char[] first = sentence[0].ToCharArray();         
            string country;
            string city;
            int countrys = 0;
            long population;

            if (char.IsLower(first[0]))
            {
                city = sentence[0];
                country = sentence[1];                       
                population = Convert.ToInt64(sentence[2]);  
                if (countries.ContainsKey(country))
                {
                    int currentCitys = countries[country];
                    countries[country] = currentCitys + 1;
                }
                else
                {

                    countries.Add(country, 1);
                }
                if (cityes.ContainsKey(city))
                {

                    cityes[city] = population;
                }
                else
                {
                    cityes.Add(city, population);
                }
            }
            else
            {
                city = sentence[1];
                country = sentence[0];              
                population = Convert.ToInt32(sentence[2]);
                if (countries.ContainsKey(country))
                {
                    int currentCitys = countries[country];
                    countries[country] = currentCitys + 1;
                }
                else
                {
                    countries.Add(country, 1);
                }
                if (cityes.ContainsKey(city))
                {
                    cityes[city] = population;
                }
                else
                {
                    cityes.Add(city, population);
                }
            }

            input = Console.ReadLine();
            var output = countries.OrderBy(c => c.Key);
            if (input == "stop")
            {
                foreach (var r in output)
                {
                    Console.WriteLine(r.Key + " -> " + r.Value);
                    // r.Key
                    // r.Value 
                }
                var items = cityes.OrderByDescending(p => p.Value);
                int count = 0;
                foreach (var i in items)
                {
                    Console.WriteLine("{0} -> {1}", i.Key, i.Value);
                    count++;
                    if (count == 3) break;
                }
            }
        }
    }
}

