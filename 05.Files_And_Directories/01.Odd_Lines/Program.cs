
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\Stefan\Documents\Visual Studio 2013\Projects\Files_Directories\Input_files\02_OddLines\03_OddLinesIn.txt"; //input Folder

        string outputPath = @"C:\Users\Stefan\Desktop\Results.txt"; //output Folder

        StreamReader reader = File.OpenText(inputPath);//read Input
        var writer = File.AppendText(outputPath);       //we write here

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();

                int counter = 0;
                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

