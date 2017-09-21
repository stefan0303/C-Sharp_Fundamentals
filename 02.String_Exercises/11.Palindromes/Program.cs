using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {

        char[] splitter = { ' ', '.', ',', '?', '!' };
        string[] sentence = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries).ToArray();
        SortedSet<string> palindromes = new SortedSet<string>();

        string reverce = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            char[] array = sentence[i].ToCharArray();
            for (int m = array.Length - 1; m >= 0; m--)
            {
                reverce = reverce + array[m];
            }
            if (reverce == sentence[i])
            {
                palindromes.Add(sentence[i]);
            }
            reverce = "";
        }
        palindromes.Reverse();
        Console.WriteLine("[{0}]", string.Join(", ", palindromes));

    }
}

