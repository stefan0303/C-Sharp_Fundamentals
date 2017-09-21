using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string people = Console.ReadLine().Trim().Replace(" ", "");
        string[] inputSongs = Console.ReadLine().Split(',');

        List<string> participant = people.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(); //izpulniteli
        List<string> songs = new List<string>();
        foreach (string song in inputSongs)
        {
            songs.Add(song.Trim());
        }
        string nameSongAward = Console.ReadLine();

        string[] name_song_award;
        name_song_award = nameSongAward.Split(',').ToArray();
        SortedDictionary<string, List<string>> name_Awards = new SortedDictionary<string, List<string>>();

        while (name_song_award[0] != "dawn")
        {
            string name = name_song_award[0].Trim();
            string song = name_song_award[1].Trim();
            // song = name_song_award[1].Substring(1, name_song_award.Length - 1);
            string award = name_song_award[2].Trim();

            if (!name_Awards.ContainsKey(name) && participant.Contains(name) && songs.Contains(song))
            {
                name_Awards.Add(name, new List<string>());//add name and list of Awards
                name_Awards[name].Add(award);

            }
            else if (participant.Contains(name) && songs.Contains(song) && !name_Awards[name].Contains(award))
            {
                name_Awards[name].Add(award);
            }
            nameSongAward = Console.ReadLine();

            name_song_award = nameSongAward.Split(',').ToArray();

            if (nameSongAward == "dawn")
            {
                break;
            }
        }

        foreach (var name in name_Awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine(name.Key + ": " + name.Value.Count + " awards");
            foreach (var value in name.Value.OrderBy(x => x))
            {
                string output = "--" + value;
                Console.WriteLine(output);
            }
        }
        if (name_Awards.Count == 0)
        {
            Console.WriteLine("No awards");
        }
    }
}