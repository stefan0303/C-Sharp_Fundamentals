using System.Collections.Generic;
using System.IO;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string textForRead = "C:\\Users\\Stefan\\Desktop.test2.txt"; //input file of text 

        string wordsTofind = @"C:\Users\Stefan\Documents\Visual Studio 2013\Projects\Files_Directories\Input_files\04_WordCount\words2.txt"; //output Folder

        string[] allWords = File.ReadAllText(textForRead).ToLower().Split(' ').ToArray(); //Allwords of text file in array

        string[] findWords = File.ReadAllText(wordsTofind).Split(' ').ToArray();

        SortedDictionary<string, int> words_count = new SortedDictionary<string, int>();
        int countWords = 0;
        for (int i = 0; i < findWords.Length; i++)
        {

            for (int m = 0; m < allWords.Length; m++)
            {
                if (allWords[m].Contains(findWords[i]))
                {
                    countWords = countWords + 1;
                }

            }
            words_count.Add(findWords[i], countWords);
            // Console.WriteLine(findWords[i]+"-"+countWords);

            countWords = 0;
        }
        string resulFile = @"C:\Users\Stefan\Desktop\result.txt"; //this is results text file
        var sortKeysValues = words_count.OrderByDescending(x => x.Value);
        using (var writer = File.AppendText(resulFile))
        {
            foreach (var item in sortKeysValues)
            {
                writer.WriteLine(item.Key + "-" + item.Value);
                //  Console.WriteLine(item.Key + "-" + item.Value);
            }
        }
    }

}

