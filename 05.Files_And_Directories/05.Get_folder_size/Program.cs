using System;
using System.IO;

//You are given a folder named TestFolder. Get the size of all files in the folder, which 
//are NOT directories. Print the result on the console in Megabytes.

class Program
{
    static void Main()
    {
        //  Directory.CreateDirectory("Test");//make directory in debug folder
        //  Directory.Delete("Test"); //delete a directory
        TraverceDirectory(@""); //Write here the directory
    }
    public static void TraverceDirectory(string directory)//Rekursia
    {
        Console.WriteLine("--" + directory + "--");

        string[] allFiles = Directory.GetFiles(directory);//Drirectory all files and write them
        foreach (var file in allFiles)
        {
            Console.WriteLine(file);
        }
        string[] allDirs = Directory.GetDirectories(directory);//all down directorys
        foreach (var dir in allDirs)
        {
            TraverceDirectory(dir);
        }
    }
}

