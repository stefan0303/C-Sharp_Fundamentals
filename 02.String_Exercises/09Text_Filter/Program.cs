using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] spliter = { ' ', ',' };
        string[] bannedWords = Console.ReadLine().Split(spliter, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] sentence = Console.ReadLine().Split().ToArray();

        for (int i = 0; i < bannedWords.Length; i++)
        {
            for (int word = 0; word < sentence.Length; word++)
            {
                if (sentence[word].Contains(bannedWords[i]))
                {
                    sentence[word] = sentence[word].Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                }

            }

        }
        Console.WriteLine();
        foreach (var word in sentence)
        {
            Console.Write(word + " ");
        }
    }
}

