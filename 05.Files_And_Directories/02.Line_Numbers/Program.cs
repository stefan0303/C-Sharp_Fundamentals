using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\Stefan\Documents\Visual Studio 2013\Projects\Files_Directories\Input_files\03_LineNumbers\03_LinesIn.txt"; //input Folder

        string outputPath = @"C:\Users\Stefan\Desktop\Results.txt"; //output Folder

        string[] input = File.ReadAllLines(inputPath);//Makes string of evry line in text file

        using (var writer = File.AppendText(outputPath))//Read the output file dirctly
        {
            for (int i = 0; i < input.Length; i++)
            {
                writer.Write(i + 1 + ".  ");
                writer.WriteLine(input[i]);
            }

        }

    }
}

