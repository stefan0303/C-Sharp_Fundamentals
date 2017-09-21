using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string key = Console.ReadLine();
        string sentence = Console.ReadLine();
        string command = sentence;//check is the sentence is final
        Dictionary<string, long> teamPoints = new Dictionary<string, long>();//Dictionary with team and points
        Dictionary<string, long> teamGoals = new Dictionary<string, long>();//Dictionary with teams and goals
        while (command.ToLower() != "final")
        {
            int index = sentence.IndexOf(key);//find first key index
            sentence = sentence.Substring(index + key.Length, sentence.Length - index - key.Length);
            index = sentence.IndexOf(key);

            string teamOne = sentence.Substring(0, index);//find the first Team
            index = sentence.IndexOf(key);
            sentence = sentence.Substring(index + key.Length, sentence.Length - index - key.Length);
            index = sentence.IndexOf(key);
            sentence = sentence.Substring(index + key.Length, sentence.Length - index - key.Length);
            index = sentence.IndexOf(key);
            string teamTwo = sentence.Substring(0, index);//find team two

            string result = sentence.Substring(sentence.Length - 4, 4).Trim();//find the result ot the match


            long scoreFirstTeam = Convert.ToInt64(result.Substring(0, 1)); //score of firstTeam
            long scoreSecondTeam = Convert.ToInt64(result.Substring(2, 1)); //score of second team
            teamOne = ReverseString(teamOne);
            teamTwo = ReverseString(teamTwo);
            teamOne = teamOne.ToUpper();  //make team UpperCase
            teamTwo = teamTwo.ToUpper();  //make team UpperCase


            if (!teamPoints.ContainsKey(teamOne))
            {
                teamPoints.Add(teamOne, 0);
                teamGoals.Add(teamOne, 0);

            }

            if (!teamPoints.ContainsKey(teamTwo))
            {
                teamPoints.Add(teamTwo, 0);
                teamGoals.Add(teamTwo, 0);
            }

            if (scoreFirstTeam > scoreSecondTeam) //win first team
            {
                teamPoints[teamOne] += 3;
                teamGoals[teamOne] += scoreFirstTeam;
                teamGoals[teamTwo] += scoreSecondTeam;
            }
            else if (scoreSecondTeam > scoreFirstTeam) //win second team
            {
                teamPoints[teamTwo] += 3;
                teamGoals[teamTwo] += scoreSecondTeam;
                teamGoals[teamOne] += scoreFirstTeam;
            }
            else if (scoreFirstTeam == scoreSecondTeam) //Draw
            {
                teamPoints[teamOne] += 1;
                teamPoints[teamTwo] += 1;
                teamGoals[teamOne] += scoreFirstTeam;
                teamGoals[teamTwo] += scoreSecondTeam;
            }
            sentence = Console.ReadLine();
            command = sentence;
        }
        //Print the standings table ordered descending by points in format
        var printStandings = teamPoints.OrderByDescending(p => p.Value).ThenBy(n => n.Key);
        int count = 1;
        Console.WriteLine("League standings:");
        foreach (var team in printStandings)//
        {
            Console.WriteLine(count + ". " + team.Key + " " + team.Value);
            count++;
        }

        Console.WriteLine("Top 3 scored goals:");

        var printGoals = teamGoals.OrderByDescending(g => g.Value).ThenBy(n => n.Key).Take(3);
        foreach (var score in printGoals)
        {
            Console.WriteLine("- " + score.Key + " -> " + score.Value);

        }
    }
    public static string ReverseString(string s)//Reverse a string
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
