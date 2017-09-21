using System.IO;

class Program
{
    static void Main()
    {
        string textForReadOne = @"C:\Users\Stefan\Documents\Visual Studio 2013\Projects\Files_Directories\Input_files\05_MergingFiles\01_FileOne.txt"; //input file of text 

        string textForReadTwo = @"C:\Users\Stefan\Documents\Visual Studio 2013\Projects\Files_Directories\Input_files\05_MergingFiles\01_FileTwo.txt"; //output Folder

        string merge_file = @"C:\Users\Stefan\Desktop\result.txt";

        StreamReader readOne = File.OpenText(textForReadOne);
        StreamReader readTwo = File.OpenText(textForReadTwo);
        var writer = File.AppendText(merge_file);

        using (readOne)
        {

            using (writer)
            {
                string lineOne = readOne.ReadLine();
                string lineTwo = readTwo.ReadLine();
                while (lineOne != null && lineTwo != null)//makes new text file one line from first file then one line from second file
                {
                    writer.WriteLine(lineOne);
                    writer.WriteLine(lineTwo);
                    lineOne = readOne.ReadLine();
                    lineTwo = readTwo.ReadLine();
                }

            }
        }

    }
}

