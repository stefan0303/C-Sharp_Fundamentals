using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] wordsInput = Console.ReadLine().Split().ToArray();
        char[] firstWord = wordsInput[0].ToCharArray();
        char[] secondWord = wordsInput[1].ToCharArray();

        firstWord = firstWord.Distinct().ToArray();//no dublicate chars in array
        secondWord = secondWord.Distinct().ToArray();
     
        int bigestLenght = 0;
        if (firstWord.Length == secondWord.Length)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");

        }

    }
}

