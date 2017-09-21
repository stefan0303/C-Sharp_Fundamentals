using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//number of lines
        List<string> paths = new List<string>();
        string input = "";
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Trim();
            paths.Add(input);
        }
        string[] query = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();//THE Query

        List<string> path = new List<string>();

        string extension = "";
        string queryExtention = "";
        string rootPath = "";
        string queryPath = "";
        BigInteger size;
        Dictionary<string, BigInteger> path_size = new Dictionary<string, BigInteger>();//dic with path name and size

        for (int i = 0; i < paths.Count; i++)//Read the list Paths
        {
            path = paths[i].Split(new[] { '\\', '.', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            extension = path[path.Count - 2];
            queryExtention = query[0];
            rootPath = path[0];
            queryPath = query[2];
            size = BigInteger.Parse(path[path.Count - 1]);
            if (extension == queryExtention && rootPath == queryPath)//the exe is the same
            {
                if (!path_size.ContainsKey(extension))
                {
                    path_size.Add(path[path.Count - 3] + "." + extension, size);
                }
                else
                {
                    path_size[path[path.Count - 3] + "." + extension] = size;
                }
            }
        }
        if (path_size.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            var sort_path_size = path_size.OrderByDescending(s => s.Value).ThenBy(s => s.Key);
            foreach (var item in sort_path_size)
            {
                Console.WriteLine((item.Key).Trim() + " - " + item.Value + " KB");
            }
        }
    }
}

